using System.Collections.Generic;
using System.Linq;
using Hilma.UBL.CommonAggregateComponents;

namespace Hilma.Espd.Tests.Extensions
{
  public static class CriterionExtensions
  {

    public static IEnumerable<TenderingCriterionProperty> DescendantProperties(this TenderingCriterion criterion)
    { 
        return criterion?.TenderingCriterionPropertyGroups.SelectMany(g => g.DescendantProperties())
          .Union(criterion.SubTenderingCriteria?.SelectMany(g => g.DescendantProperties()) ??
                 Enumerable.Empty<TenderingCriterionProperty>());
    }

    public static IEnumerable<TenderingCriterionProperty> DescendantProperties(this TenderingCriterionPropertyGroup tenderingCriterionPropertyGroup)
    {
      return tenderingCriterionPropertyGroup?.TenderingCriterionProperties
        .Union(tenderingCriterionPropertyGroup.SubsidiaryTenderingCriterionPropertyGroups?.SelectMany(g => g.DescendantProperties()) ??
               Enumerable.Empty<TenderingCriterionProperty>());
    }

    public static IEnumerable<TenderingCriterionPropertyGroup> DescendantGroups(this TenderingCriterion criterion)
    {

      var ownGroups = criterion?.TenderingCriterionPropertyGroups;
        return ownGroups.Union( criterion?.TenderingCriterionPropertyGroups?.SelectMany(g => g.DescendantGroups())
          .Union(criterion.SubTenderingCriteria?.SelectMany(g => g.DescendantGroups()) ??
                 Enumerable.Empty<TenderingCriterionPropertyGroup>()));
    }

    public static IEnumerable<TenderingCriterionPropertyGroup> DescendantGroups(this TenderingCriterionPropertyGroup tenderingCriterionPropertyGroup)
    {
      return tenderingCriterionPropertyGroup?.SubsidiaryTenderingCriterionPropertyGroups?
        .Union(tenderingCriterionPropertyGroup?.SubsidiaryTenderingCriterionPropertyGroups?.SelectMany(g => g.DescendantGroups())) ??
      Enumerable.Empty<TenderingCriterionPropertyGroup>();
    }
  }
}