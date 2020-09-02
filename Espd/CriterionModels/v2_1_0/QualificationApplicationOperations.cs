﻿using System;
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
        var isLotGroup = group.TenderingCriterionProperties
          .Any(IsRequirementLotIdentifier);

        foreach (var property in group.TenderingCriterionProperties)
        {
          if (IsRequirementLotIdentifier(property))
          {
            // Set default lot
            if (selectedLots.Any())
            {
                // Duplicate lot property for each lot 
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
              yield return new TenderingCriterionProperty()
              {
                  _cardinality = property._cardinality,
                  ID = EuComGrowId.Random(),
                  Name = property.Name,
                  Description = property.Description,
                  ExpectedID = new EuComGrowId(0.ToString()),
                  TypeCode = CriterionElementType.Requirement,
                  ValueDataTypeCode = ResponseDataTypeCode.LotIdentifier
              };
            }
          }
          else
          {
            // Generate new if for property
            property.ID = EuComGrowId.Random();
            yield return property;
          }
        }

        bool IsRequirementLotIdentifier(TenderingCriterionProperty property)
        {
          if (property?.ValueDataTypeCode == null || (!property?.TypeCode?.Equals(CriterionElementType.Requirement) ?? false))
            return false;

          return property.ValueDataTypeCode.Value == ResponseDataTypeCode.LotIdentifier.Value;
        }
      }
    }
  }
}
