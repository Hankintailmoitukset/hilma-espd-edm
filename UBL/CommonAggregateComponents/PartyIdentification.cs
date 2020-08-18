using System.Xml.Linq;
using Hilma.UBL.Attributes;
using Hilma.UBL.Serializers;
using Hilma.UBL.UnqualifiedDataTypes;

namespace Hilma.UBL.CommonAggregateComponents
{
  [Contract]
  public class PartyIdentification
  {
    /// <summary>
    /// The national identifier of a contracting body as it is legally registered (e.g. VAT identification).
    /// </summary>
    public IdentifierType ID { get; set; }

    public XElement Serialize()
    {
      return new XElement(UblNames.Cac + nameof(PartyIdentification),
        ID?.Serialize(nameof(ID))
      );
    }
  }
}