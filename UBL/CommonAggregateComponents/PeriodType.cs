using UBL.UnqualifiedDataTypes;

namespace UBL.CommonAggregateComponents
{
    public class PeriodType
  {
    public DateType? StartDate { get; set; }

    public TimeType? StartTime { get; set; }

    public DateType? EndDate { get; set; }

    public TimeType? EndTime { get; set; }

    public MeasureType DurationMeasure { get; set; }

    public CodeType[] DescriptionCode { get; set; }

    public TextType[] Descriptions { get; set; }

  }

}