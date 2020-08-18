using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;
using Hilma.UBL.Attributes;
using Hilma.UBL.Serializers;

namespace Hilma.UBL.CommonAggregateComponents
{
  /// <summary>
  /// The name of the contracting body as it is registered.
  /// </summary>
  [Contract]
  public class PartyName
  {
    /// <summary>
    /// Mandatory. Use the official name of the contracting body. The PartyName class has an associated basic element "cbc:Name". See XML example below.
    /// </summary>
    /// <remarks>Mandatory. Use the official name of the contracting body.</remarks>
    [Required]
    public string Name { get; set; }

    public XElement Serialize()
    {
      return new XElement(UblNames.Cac + nameof(PartyName),
        this.Name?.Serialize(nameof(Name))
        );
    }
  }
}