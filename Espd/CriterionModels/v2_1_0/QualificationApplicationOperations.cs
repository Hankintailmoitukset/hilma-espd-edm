using System;
using System.Collections.Generic;
using System.Linq;
using Hilma.Espd.EDM.CriterionModels.v2_1_0.Identifiers;
using Hilma.UBL.CommonAggregateComponents;
using Hilma.UBL.UnqualifiedDataTypes;

namespace Hilma.Espd.EDM.CriterionModels.v2_1_0
{
  public static class QualificationApplicationOperations
  {
    /// <summary>
    /// Finalize document properties
    /// </summary>
    public static QualificationApplicationRequest FinalizeDocument(this QualificationApplicationRequest request)
    {
      foreach (var criterion in request.TenderingCriteria ?? Enumerable.Empty<TenderingCriterion>())
      {
        FinalizeCriterion(criterion, request);
      }

      return request;
    }

    private static void FinalizeCriterion(TenderingCriterion criterion, QualificationApplicationRequest request)
    {
      var procurementHasLots = request.ProcurementProjectLots?.Length > 1;
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

        if (propertyGroup?.TenderingCriterionProperties != null)
        {
          propertyGroup.TenderingCriterionProperties =
            FilterAndFinalizeProperties(propertyGroup)
              .ToArray();
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
        var isLotGroup = group.TenderingCriterionProperties
          .Any(p =>
            Equals(p.ValueDataTypeCode, ResponseDataTypeCode.LotIdentifier) );

        if (!procurementHasLots && isLotGroup)
        {
          // If no lot, filter out all lot properties
          yield break;
        }

        foreach (var property in group.TenderingCriterionProperties)
        {
          if (Equals(property.ValueDataTypeCode, ResponseDataTypeCode.LotIdentifier))
          {
            // Duplicate lot property for each lot 
            foreach (var projectLot in request.ProcurementProjectLots)
            {
              yield return new TenderingCriterionProperty()
              {
                _cardinality = property._cardinality,
                Id = EuComGrowId.Random(),
                Name = property.Name,
                Description = property.Description,
                ExpectedID = new IdentifierType(projectLot.ID.Value),
                ValueDataTypeCode = ResponseDataTypeCode.LotIdentifier
              };
            }
          }
          else
          {
            // Generate new if for property
            property.Id = EuComGrowId.Random();
            yield return property;
          }
        }
      }
    }
  }
}
