using Hilma.UBL.Attributes;
using Hilma.UBL.UnqualifiedDataTypes;

namespace Hilma.UBL.CommonAggregateComponents
{
  [Contract]
  public class PeriodType
  {
    public DateType StartDate { get; set; }

    public TimeType StartTime { get; set; }

    public DateType EndDate { get; set; }

    public TimeType EndTime { get; set; }

    public MeasureType DurationMeasure { get; set; }

    public CodeType[] DescriptionCode { get; set; }

    public string[] Descriptions { get; set; }

  }

}