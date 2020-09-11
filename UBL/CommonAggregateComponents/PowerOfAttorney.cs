using Hilma.UBL.Attributes;

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
    }
}