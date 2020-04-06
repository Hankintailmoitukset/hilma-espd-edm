using Hilma.UBL.Attributes;
using Hilma.UBL.UnqualifiedDataTypes;

namespace Hilma.UBL.CommonAggregateComponents
{
  [Contract]
  public class LocationCoordinateType
  {

    public CodeType CoordinateSystemCode { get; set; }

    public MeasureType LatitudeDegreesMeasure { get; set; }

    public MeasureType LatitudeMinutesMeasure { get; set; }

    public CodeType LatitudeDirectionCode { get; set; }

    public MeasureType LongitudeDegreesMeasure { get; set; }

    public MeasureType LongitudeMinutesMeasure { get; set; }

    public CodeType LongitudeDirectionCode { get; set; }

    public MeasureType AltitudeMeasure { get; set; }

  }
}