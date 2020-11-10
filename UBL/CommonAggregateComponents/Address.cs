using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Xml.Linq;
using Hilma.UBL.Attributes;
using Hilma.UBL.Serializers;
using Hilma.UBL.UnqualifiedDataTypes;

namespace Hilma.UBL.CommonAggregateComponents
{
  [Contract]
  public class Address
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
    public Country Country { get; set; }
    public LocationCoordinate[] LocationCoordinates { get; set; }

    
    public XElement Serialize( string name )
    {
      return new XElement(UblNames.Cac + name,
        ID.Serialize(nameof(ID)),
        AddressTypeCode.Serialize(nameof(AddressTypeCode)),
        AddressFormatCode.Serialize(nameof(AddressFormatCode)),
        Postbox.Serialize(nameof(Postbox)),
        Floor.Serialize(nameof(Floor)),
        Room.Serialize(nameof(Room)),
        StreetName.Serialize(nameof(StreetName)),
        AdditionalStreetName.Serialize(nameof(AdditionalStreetName)),
        BlockName.Serialize(nameof(BlockName)),
        BuildingName.Serialize(nameof(BuildingName)),
        BuildingNumber.Serialize(nameof(BuildingNumber)),
        InhouseMail.Serialize(nameof(InhouseMail)),
        Department.Serialize(nameof(Department)),
        MarkAttention.Serialize(nameof(MarkAttention)),
        MarkCare.Serialize(nameof(MarkCare)),
        PlotIdentification.Serialize(nameof(PlotIdentification)),
        CitySubdivisionName.Serialize(nameof(CitySubdivisionName)),
        CityName.Serialize(nameof(CityName)),
        PostalZone.Serialize(nameof(PostalZone)),
        CountrySubentity.Serialize(nameof(CountrySubentity)),
        CountrySubentityCode.Serialize(nameof(CountrySubentityCode)),
        Region.Serialize(nameof(Region)),
        District.Serialize(nameof(District)),
        TimezoneOffset.Serialize(nameof(TimezoneOffset)),
        AddressLines?.Select( line => new XElement(UblNames.Cac + "AddressLine", line.Serialize("Line"))),
        Country?.Serialize(),
        LocationCoordinates?.Select( lc => lc.Serialize())
        );
    }
                 
  }
}