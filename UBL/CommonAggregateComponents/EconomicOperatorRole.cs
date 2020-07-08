using Hilma.UBL.Attributes;
using Hilma.UBL.UnqualifiedDataTypes;

namespace Hilma.UBL.CommonAggregateComponents
{
    [Contract]
    public class EconomicOperatorRole
    {
        /// <summary>
        /// Identifies the role of the economic operator in the bid.
        /// </summary>
        public CodeType RoleCode { get; set; }

        /// <summary>
        /// The text describing the role of the economic operator in the bid.
        /// </summary>
        public string[] RoleDescription { get; set; }
    }
}