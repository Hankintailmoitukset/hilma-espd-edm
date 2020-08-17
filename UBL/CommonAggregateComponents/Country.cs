using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;
using Hilma.UBL.Attributes;
using Hilma.UBL.Serializers;
using Hilma.UBL.UnqualifiedDataTypes;

namespace Hilma.UBL.CommonAggregateComponents
{
  [Contract]
  public class Country
  {
    /// <summary>
    /// A code that identifies the country. The lists of valid countries are registered with the ISO 3166-1 Maintenance agency,
    /// "Codes for the representation of names of countries and their subdivisions".
    /// It is recommended to use the Country Code ISO 3166-1 2A:2006 representation.
    /// </summary>
    /// <remarks>The country of the contracting body must always be specified. Compulsory use of the code list CountryCodeIdentifier (ISO 3166-1 2A:2006).</remarks>
    [Required]
    public CodeType IdentificationCode { get; set; }

    /// <summary>
    /// The name of the country.
    /// </summary>
    public string Name { get; set; }

    public XElement Serialize()
    {
      return new XElement(UblNames.Cac + nameof(Country),
        IdentificationCode.Serialize(nameof(IdentificationCode)),
        Name.Serialize(nameof(Name)));
    }

  }
}