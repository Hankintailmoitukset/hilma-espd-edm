using System.ComponentModel.DataAnnotations;
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

    /// <summary>
    /// The main address line in an address. Usually the street name and number or post office box.
    /// </summary>
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

    /// <summary>
    /// The common name of a city where the address is located.
    /// </summary>
    public NameType? CityName { get; set; }

    /// <summary>
    /// The identifier for an addressable group of properties according to the relevant postal service, such as a ZIP code or Post Code.
    /// </summary>
    public TextType? PostalZone { get; set; }
    public TextType? CountrySubentity { get; set; }
    public CodeType? CountrySubentityCode { get; set; }
    public TextType? Region { get; set; }
    public TextType? District { get; set; }
    public TextType? TimezoneOffset { get; set; }
    public TextType[]? AddressLines { get; set; }

    [Required]
    public CountryType? Country { get; set; }
    public LocationCoordinateType[]? LocationCoordinates { get; set; }

    /// <summary>
    /// Contact of the contracting body
    /// </summary>
    public ContactType? Contact { get; set; }
                 
  }
}