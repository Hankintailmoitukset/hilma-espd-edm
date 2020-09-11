using System.Xml.Linq;
using Hilma.UBL.Attributes;
using Hilma.UBL.Serializers;

namespace Hilma.UBL.CommonAggregateComponents
{   
    /// <summary>
    /// A class to describe a power of attorney.
    /// </summary>
    [Contract]
    public class PowerOfAttorney
    { 
        /// <summary>
        /// The party who acts as an agent or fiduciary for the principal and who holds this power of attorney on behalf of the principal.
        /// </summary>
        public Party AgentParty { get; set; }

        public XElement Serialize() {
            return new XElement( UblNames.Cac + nameof(PowerOfAttorney),
                AgentParty?.Serialize(nameof(AgentParty))
            );
        }
    }
}