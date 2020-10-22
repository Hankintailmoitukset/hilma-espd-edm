using System;
using System.Xml.Linq;
using Hilma.UBL.Attributes;
using Hilma.UBL.Serializers;
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

        public XElement Serialize() {
          return new XElement(UblNames.Cac + nameof(EconomicOperatorRole),
            RoleCode.Serialize(nameof (RoleCode)),
            RoleDescription.Serialize(nameof (RoleDescription))
            );
        }
  }
}