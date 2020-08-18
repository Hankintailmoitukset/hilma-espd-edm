using System.Xml.Linq;
using Hilma.UBL.Attributes;
using Hilma.UBL.Serializers;
using Hilma.UBL.UnqualifiedDataTypes;

namespace Hilma.UBL.CommonAggregateComponents
{
  /// <summary>
  /// The contracting authority or contracting entity who is buying supplies, services or public works using a tendering procedure as described in the applicable directive (e.g. Directives 2014/24/EU, 2014/25/EU).
  /// </summary>
  [Contract]
  public class ContractingParty
  {
    /// <summary>
    /// For procurement procedures above the threshold it is compulsory to make reference to the Contract Notice of the procedure published in TED. See section "Reference to the Contract Notice" for a complete example.
    /// </summary>
    /// <remarks>
    /// Notices published at national level shall not contain information other than that contained in the notices dispatched to the Publications Office of the European Union or published on a buyer profile,
    /// but shall indicate the date of dispatch of the notice to the Publications Office of the European Union or its publication on the buyer profile (Directive 2014/24/EU, Art. 52.2).
    /// </remarks>
    public IdentifierType BuyerProfileUri { get; set; }

    /// <summary>
    /// Main data placeholder structure for, in this case, the contracting body.
    /// </summary>
    public Party Party { get; set; }

    public XElement Serialize()
    {
      return new XElement(UblNames.Cac + nameof(ContractingParty),
        BuyerProfileUri.Serialize(nameof(BuyerProfileUri)),
        Party?.Serialize()
      );
    }

  }
} 