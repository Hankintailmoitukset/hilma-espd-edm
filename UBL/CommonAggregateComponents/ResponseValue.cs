using System;
using System.Xml.Linq;
using Hilma.UBL.Attributes;
using Hilma.UBL.Serializers;
using Hilma.UBL.UnqualifiedDataTypes;

namespace Hilma.UBL.CommonAggregateComponents
{
    [Contract]
    public class ResponseValue
    {
        /// <summary>
        /// An identifier to refer to this criterion response value.
        /// </summary>
        public IdentifierType ID { get; set; }
        /// <summary>
        /// A description used as a reply to the criterion property.
        /// </summary>
        public string[] Description { get; set; }
        /// <summary>
        /// An amount used as a reply to the criterion property.
        /// </summary>
        public AmountType ResponseAmount { get; set; }
        /// <summary>
        /// A code used as a reply to the criterion property.
        /// </summary>
        public CodeType ResponseCode { get; set; }
        /// <summary>
        /// A date used as a reply to the criterion property.
        /// </summary>
        public DateType ResponseDate { get; set; }
        /// <summary>
        /// A time used as a reply to the criterion property.
        /// </summary>
        public TimeType ResponseTime { get; set; }
        /// <summary>
        /// An identifier used as a reply to the criterion property.
        /// </summary>
        public IdentifierType ResponseID { get; set; }
        /// <summary>
        /// An indicator used as a reply to the criterion property.
        /// </summary>
        public bool ResponseIndicator { get; set; }
        /// <summary>
        /// A measure used as a reply to the criterion property.
        /// </summary>
        public MeasureType ResponseMeasure { get; set; }
        /// <summary>
        /// A number used as a reply to the criterion property.
        /// </summary>
        public decimal? ResponseNumeric { get; set; }
        /// <summary>
        /// A quantity used as a reply to the criterion property.
        /// </summary>
        public QuantityType ResponseQuantity { get; set; }
        /// <summary>
        /// A URI used as a reply to the criterion property.
        /// </summary>
        public IdentifierType ResponseURI {get; set; }

        public XElement Serialize() {
          return new XElement(UblNames.Cac + nameof(ResponseValue),
            ID.Serialize(nameof(ID)),
            Description.Serialize(nameof (Description)),
            ResponseAmount.Serialize(nameof (ResponseAmount)),
            ResponseCode.Serialize(nameof (ResponseCode)),
            ResponseDate.Serialize(nameof (ResponseDate)),
            ResponseTime.Serialize(nameof (ResponseTime)),
            ResponseID.Serialize(nameof (ResponseID)),
            ResponseIndicator.Serialize(nameof (ResponseIndicator)),
            ResponseMeasure.Serialize(nameof (ResponseMeasure)),
            ResponseNumeric.Serialize(nameof (ResponseNumeric)),
            ResponseQuantity.Serialize(nameof (ResponseQuantity)),
            ResponseURI.Serialize(nameof (ResponseURI))
            );
        }
  }
}