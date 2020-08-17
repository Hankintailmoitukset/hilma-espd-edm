using System.Xml.Linq;
using Hilma.UBL.Attributes;
using Hilma.UBL.Serializers;
using Hilma.UBL.UnqualifiedDataTypes;

namespace Hilma.UBL.CommonAggregateComponents
{
  [Contract]
  public class LocationCoordinate
  {

    public CodeType CoordinateSystemCode { get; set; }

    public MeasureType LatitudeDegreesMeasure { get; set; }

    public MeasureType LatitudeMinutesMeasure { get; set; }

    public CodeType LatitudeDirectionCode { get; set; }

    public MeasureType LongitudeDegreesMeasure { get; set; }

    public MeasureType LongitudeMinutesMeasure { get; set; }

    public CodeType LongitudeDirectionCode { get; set; }

    public MeasureType AltitudeMeasure { get; set; }

    public XElement Serialize()
    {
      return new XElement(UblNames.Cac + nameof(LocationCoordinate),
        CoordinateSystemCode.Serialize(nameof(CoordinateSystemCode)),
        LatitudeDegreesMeasure.Serialize(nameof(LatitudeDegreesMeasure)),
        LatitudeMinutesMeasure.Serialize(nameof(LatitudeMinutesMeasure)),
        LatitudeDirectionCode.Serialize(nameof(LatitudeDirectionCode)),
        LongitudeDegreesMeasure.Serialize(nameof(LongitudeDegreesMeasure)),
        LongitudeMinutesMeasure.Serialize(nameof(LongitudeMinutesMeasure)),
        LongitudeDirectionCode.Serialize(nameof(LongitudeDirectionCode)),
        AltitudeMeasure.Serialize(nameof(AltitudeMeasure))
        );
    }

  }
}