using UBL.UnqualifiedDataTypes;

namespace UBL.CommonAggregateComponents
{
  public class AddressType
  {
    public IdentifierType? ID { get; set; }
    public CodeType? AddressTypeCode { get; set; }
    public CodeType? AddressFormatCode { get; set; }
    public TextType? Postbox { get; set; }
    public TextType? Floor { get; set; }
    public TextType? Room { get; set; }
    public NameType? StreetName { get; set; }
    public NameType? AdditionalStreetName { get; set; }
    public NameType? BlockName { get; set; }
    public NameType? BuildingName { get; set; }
    public TextType? BuildingNumber { get; set; }
    public TextType? InhouseMail { get; set; }
    public TextType? Department { get; set; }
    public TextType? MarkAttention { get; set; }
    public TextType? MarkCare { get; set; }
    public TextType? PlotIdentification { get; set; }
    public NameType? CitySubdivisionName { get; set; }
    public NameType? CityName { get; set; }
    public TextType? PostalZone { get; set; }
    public TextType? CountrySubentity { get; set; }
    public CodeType? CountrySubentityCode { get; set; }
    public TextType? Region { get; set; }
    public TextType? District { get; set; }
    public TextType? TimezoneOffset { get; set; }
    public TextType[]? AddressLines { get; set; }
    public CountryType? Country { get; set; }
    public LocationCoordinateType[]? LocationCoordinates { get; set; }
                 
  }
}