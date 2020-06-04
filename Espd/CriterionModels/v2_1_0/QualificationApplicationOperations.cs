using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hilma.Espd.EDM.CriterionModels.v2_1_0.Identifiers;
using Hilma.UBL.CommonAggregateComponents;
using Hilma.UBL.UnqualifiedDataTypes;

namespace Hilma.Espd.EDM.CriterionModels
{
  public static class QualificationApplicationOperations
  {
    /// <summary>
    /// Finalize document properties
    /// </summary>
    public static QualificationApplicationRequest FinalizeDocument(this QualificationApplicationRequest request)
    {
      var hasLots = request.ProcurementProjectLots.Length > 1;

      void FinalizeGroup(IEnumerable<TenderingCriterionPropertyGroup> groups)
      {
        if (groups == null)
        {
          return;
        }

        foreach (var group in groups)
        {
          if (group?.TenderingCriterionProperties != null)
          {
            var propertiesToRemove = new List<TenderingCriterionProperty>();
            var propertiesToAdd = new List<TenderingCriterionProperty>();
            var isLotGroup = group.TenderingCriterionProperties
                .Any(p => 
                  p.ValueDataTypeCode == ResponseDataTypeCode.LotIdentifier
                  );
            
            void PopulateLots(TenderingCriterionProperty property)
            {
                propertiesToRemove.Add(property);
                propertiesToAdd.AddRange(request.ProcurementProjectLots
                  .Select(lot => new TenderingCriterionProperty()
                  {
                    _cardinality = property._cardinality,
                    Id = EuComGrowId.Random(),
                    Name = property.Name,
                    Description = property.Description,
                    ExpectedID = new IdentifierType(lot.ID.Value)
                  }));
            }

            if (!hasLots && isLotGroup)
            {
                propertiesToRemove.AddRange( group.TenderingCriterionProperties );
                
            }
            else
            {
              foreach (var property in group.TenderingCriterionProperties)
              {
                property.Id = EuComGrowId.Random();

                if (property.ValueDataTypeCode == ResponseDataTypeCode.LotIdentifier)
                {
                  PopulateLots(property);
                }
              }
            }

            group.TenderingCriterionProperties = group.TenderingCriterionProperties
              .Where(p => !propertiesToRemove.Contains(p))
              .Union(propertiesToAdd)
              .ToArray();
          }

          FinalizeGroup(group?.SubsidiaryTenderingCriterionPropertyGroups);
        }
      }
      
      foreach (var criterion in request.TenderingCriteria ?? Enumerable.Empty<TenderingCriterion>())
      {
        FinalizeGroup(criterion?.TenderingCriterionPropertyGroups);
      }

      return request;
    }
  }
}
