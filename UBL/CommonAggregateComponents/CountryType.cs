using System.ComponentModel.DataAnnotations;
using UBL.UnqualifiedDataTypes;

namespace UBL.CommonAggregateComponents
{
  public class CountryType
  {
    /// <summary>
    /// A code that identifies the country. The lists of valid countries are registered with the ISO 3166-1 Maintenance agency,
    /// "Codes for the representation of names of countries and their subdivisions".
    /// It is recommended to use the Country Code ISO 3166-1 2A:2006 representation.
    /// </summary>
    /// <remarks>The country of the contracting body must always be specified. Compulsory use of the code list CountryCodeIdentifier (ISO 3166-1 2A:2006).</remarks>
    [Required]
    public IdentifierType? IdentificationCode { get; set; }

    /// <summary>
    /// The name of the country.
    /// </summary>
    public NameType? Name { get; set; }

  }
}