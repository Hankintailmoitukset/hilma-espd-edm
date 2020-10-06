using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using Hilma.Espd.EDM.CriterionModels.v2_1_1.Identifiers;
using Hilma.UBL.CommonAggregateComponents;
using Hilma.UBL.UnqualifiedDataTypes;

namespace Hilma.Espd.EDM.CriterionModels.v2_1_1
{
  public static class QualificationApplicationOperations
  {

    /// <summary>
    /// EG-Contribitions Threshold group id
    /// </summary>
    /// <returns></returns>
    public static readonly Guid ContributionThresholdGroupId = new Guid("53c9aad8-dc80-48f8-85d9-755c2aab8e95");

    /// <summary>
    /// Finalize document properties
    /// </summary>
    public static QualificationApplicationRequest FinalizeDocument(this QualificationApplicationRequest request, string[] selectedLots = null)
    {
      foreach (var criterion in request.TenderingCriteria ?? Enumerable.Empty<TenderingCriterion>())
      {
        FinalizeCriterion(criterion, request, selectedLots ?? new string[0]);
      }

      return request;
    }

    private static void FinalizeCriterion(TenderingCriterion criterion, QualificationApplicationRequest request,
      string[] selectedLots)
    {
      var procurementHasLots = selectedLots.Any();

      criterion.TenderingCriterionPropertyGroups = FinalizeGroups(criterion.TenderingCriterionPropertyGroups).ToArray();

      IEnumerable<TenderingCriterionPropertyGroup> FinalizeGroups(IEnumerable<TenderingCriterionPropertyGroup> groups)
      {
        if (groups == null)
        {
          yield break;
        }

        foreach (var group in groups)
        {
          yield return FinalizeGroup(@group);
        }
      }

      TenderingCriterionPropertyGroup FinalizeGroup(TenderingCriterionPropertyGroup propertyGroup)
      {
        if (propertyGroup == null)
          throw new ArgumentNullException(nameof(propertyGroup));

        if (propertyGroup?.TenderingCriterionProperties?.Any()??false)
        {
          propertyGroup.TenderingCriterionProperties =
            FilterAndFinalizeProperties(propertyGroup)
              .ToArray();
        }
        else
        {
          // Set empty property to conform to espd schema
          propertyGroup.TenderingCriterionProperties = new[]
          {
            CriterionHelper.EmptyCaptionProperty
          };
        }

        if (propertyGroup.SubsidiaryTenderingCriterionPropertyGroups != null)
        {
          propertyGroup.SubsidiaryTenderingCriterionPropertyGroups =
            FinalizeGroups(propertyGroup?.SubsidiaryTenderingCriterionPropertyGroups).ToArray();
        }

        return propertyGroup;
      }
      
      IEnumerable<TenderingCriterionProperty> FilterAndFinalizeProperties(
        TenderingCriterionPropertyGroup group)
      {
       
        foreach (var property in group.TenderingCriterionProperties)
        { 
          if (IsLotIdentifier(property) && IsRequirementProperty(property))
          {
            foreach( var lotProperty in SetRequirementLotIdentifierValue(property)) {
              yield return lotProperty;
            }
          }
          else
          {
            // Set default value to Contributions threshold value as per Comission suggestion
            if(group.ID.Value == ContributionThresholdGroupId.ToString()) {
              if( property.ValueDataTypeCode.Equals(ResponseDataTypeCode.Amount)) {
                // Set default threshold to 0
                property.ExpectedAmount = new AmountType { Value = 0, CurrencyID = "EUR" };
              }
              if (property.ValueDataTypeCode.Equals(ResponseDataTypeCode.Description))
              {
                // Set default threshold to 0
                property.ExpectedDescription = string.Empty;
              }
            }

            // Generate new if for property
            property.ID = EuComGrowId.Random();
            yield return property;
          }
        }

        IEnumerable<TenderingCriterionProperty> SetRequirementLotIdentifierValue(TenderingCriterionProperty property )
        {
          if (procurementHasLots)
          {
            // Duplicate requirement lot property for each lot
            foreach (var projectLot in selectedLots)
            {
              yield return new TenderingCriterionProperty()
              {
                _cardinality = property._cardinality,
                ID = EuComGrowId.Random(),
                Name = property.Name,
                Description = property.Description,
                ExpectedID = new EuComGrowId(projectLot),
                TypeCode = CriterionElementType.Requirement,
                ValueDataTypeCode = ResponseDataTypeCode.LotIdentifier
              };
            }
          }
          else
          {
            property.ID = EuComGrowId.Random();
            property.ExpectedID = new EuComGrowId(0.ToString());
            yield return property;
          }
        } 
        
        bool IsLotIdentifier(TenderingCriterionProperty property)
        {
          return property.ValueDataTypeCode.Value == ResponseDataTypeCode.LotIdentifier.Value;
        }

        bool IsRequirementProperty( TenderingCriterionProperty property ) {
          return (property?.TypeCode?.Equals(CriterionElementType.Requirement) ?? false);
        }
      }
      
    }
  }
}
