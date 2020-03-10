using System.ComponentModel.DataAnnotations;
using UBL.UnqualifiedDataTypes;

namespace UBL.CommonAggregateComponents
{
  public class TenderingCriterionPropertyGroup
  {
    public IdentifierType Id { get; set; }
    public string[] Name { get; set; }
    public string[] Description { get; set; }
    public string PropertyGroupTypeCode { get; set; }
    public string FulfilmentIndicatorTypeCode { get; set; }
    [Required]
    public TenderingCriterionProperty[] TenderingCriterionProperties { get; set; }
    public TenderingCriterionPropertyGroup[] SubsidiaryTenderingCriterionPropertyGroups { get; set; }

  }
}