using Hilma.UBL.Attributes;
using Hilma.UBL.UnqualifiedDataTypes;

namespace Hilma.UBL.CommonAggregateComponents
{
  [Contract]
  public class PartyIdentificationType
  {
    /// <summary>
    /// The national identifier of a contracting body as it is legally registered (e.g. VAT identification).
    /// </summary>
    public IdentifierType ID { get; set; }
  }
}