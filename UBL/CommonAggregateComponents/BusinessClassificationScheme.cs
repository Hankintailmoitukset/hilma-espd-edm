using System;
using System.Xml.Linq;
using Hilma.UBL.Attributes;
using Hilma.UBL.Serializers;

namespace Hilma.UBL.CommonAggregateComponents
{
    [Contract]
    public class BusinessClassificationScheme
    {
        /// <summary>
        /// The text describing one official classification assigned by an official list or (pre)qualification system to the economic operator.
        /// </summary>
        public string[] Description { get; set; }

        public XElement Serialize() {
          return new XElement(UblNames.Cac + nameof(BusinessClassificationScheme),
            Description.Serialize(nameof (Description))
            );
        }
  }
}