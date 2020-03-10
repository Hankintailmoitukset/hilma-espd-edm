using System;
using UBL.UnqualifiedDataTypes;

namespace UBL.CommonAggregateComponents
{
  public class TenderingCriterionProperty
  {
    public string Id { get; set; }
    public string[] Name { get; set; }
    public string[] Description { get; set; }
    public string TypeCode { get; set; }
    public string ValueDataTypeCode { get; set; }
    public string ValueUnitCode { get; set; }
    
    public string ValueCurrencyCode { get; set; }

    public string ExpectedAmount { get; set; }

    public string ExpectedI { get; set; }

    public string ExpectedCode { get; set; }

    public string ExpectedValueNumeric { get; set; }

    public string ExpectedDescription { get; set; }

    public string MaximumAmount { get; set; }

    public string MinimumAmount { get; set; }

    public string MaximumValueNumeric { get; set; }

    public string MinimumValueNumeric { get; set; }

    public string TranslationTypeCode { get; set; }

    public string[] CertificationLevelDescription { get; set; }

    public string CopyQualityTypeCode { get; set; }
    public PeriodType[] ApplicablePeriod { get; set; }
    public string[] TemplateEvidence { get; set; }

  }

  public class PeriodType
  {
    public DateTime? StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public MeasureType DurationMeasure { get; set; }

    public CodeType[] DescriptionCode { get; set; }

    public string[] Descriptions { get; set; }

  }

}