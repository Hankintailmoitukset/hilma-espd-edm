using System.Xml.Linq;
using Hilma.UBL.Attributes;
using Hilma.UBL.Serializers;
using Hilma.UBL.UnqualifiedDataTypes;

namespace Hilma.UBL.CommonAggregateComponents
{
  /// <summary>
  /// A reference to evidence.
  /// </summary>
  [Contract]
  public class EvidenceSupplied
  {
    /// <summary>
    /// The identifier of the referenced evidence.
    /// </summary>
    public IdentifierType ID { get; set; }

    public XElement Serialize(string evidenceSuppliedName)
    {
      return new XElement( UblNames.Cac + nameof(EvidenceSupplied),
        ID.Serialize(nameof(ID))
        );
    }
  }
}