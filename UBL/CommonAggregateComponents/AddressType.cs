using System.ComponentModel.DataAnnotations;
using Hilma.UBL.Attributes;
using Hilma.UBL.UnqualifiedDataTypes;

namespace Hilma.UBL.CommonAggregateComponents
{
  [Contract]
  public class AddressType
  {
    public IdentifierType ID { get; set; }
    public CodeType AddressTypeCode { get; set; }
    public CodeType AddressFormatCode { get; set; }
    public string Postbox { get; set; }
    public string Floor { get; set; }
    public string Room { get; set; }

    /// <summary>
    /// The main address line in an address. Usually the street name and number or post office box.
    /// </summary>
    public string StreetName { get; set; }
    public string AdditionalStreetName { get; set; }
    public string BlockName { get; set; }
    public string BuildingName { get; set; }
    public string BuildingNumber { get; set; }
    public string InhouseMail { get; set; }
    public string Department { get; set; }
    public string MarkAttention { get; set; }
    public string MarkCare { get; set; }
    public string PlotIdentification { get; set; }
    public string CitySubdivisionName { get; set; }

    /// <summary>
    /// The common name of a city where the address is located.
    /// </summary>
    public string CityName { get; set; }

    /// <summary>
    /// The identifier for an addressable group of properties according to the relevant postal service, such as a ZIP code or Post Code.
    /// </summary>
    public string PostalZone { get; set; }
    public string CountrySubentity { get; set; }
    public CodeType CountrySubentityCode { get; set; }
    public string Region { get; set; }
    public string District { get; set; }
    public string TimezoneOffset { get; set; }
    public string[] AddressLines { get; set; }

    [Required]
    public CountryType Country { get; set; }
    public LocationCoordinateType[] LocationCoordinates { get; set; }

    /// <summary>
    /// Contact of the contracting body
    /// </summary>
    public ContactType Contact { get; set; }
                 
  }
}