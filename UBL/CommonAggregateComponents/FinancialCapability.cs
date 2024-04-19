using System;
using System.Xml.Linq;
using Hilma.UBL.Attributes;
using Hilma.UBL.Serializers;
using Hilma.UBL.UnqualifiedDataTypes;

namespace Hilma.UBL.CommonAggregateComponents
{
    [Contract]
    public class FinancialCapability
    {
        /// <summary>
        /// A monetary amount as a measure of this capability.
        /// </summary>
        public AmountType ValueAmount { get; set; }

        public XElement Serialize() {
          return new XElement(UblNames.Cac + nameof(FinancialCapability),
            ValueAmount.Serialize(nameof (ValueAmount))
            );
        }
  }

}
