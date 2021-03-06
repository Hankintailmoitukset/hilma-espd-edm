﻿using System.Xml.Linq;
using Hilma.UBL.Attributes;
using Hilma.UBL.Serializers;

namespace Hilma.UBL.CommonAggregateComponents
{
    [Contract]
    public class Attachment
    {
        /// <summary>
        /// A binary large object containing an attached document.
        /// </summary>
        public byte[] EmbeddedDocumentBinaryObject { get; set; }

        /// <summary>
        /// A clear text object containing an attached document.
        /// </summary>
        public string EmbeddedDocument { get; set; }
        /// <summary>
        /// A reference to an attached document that is external to the document(s) being exchanged.
        /// </summary>
        public ExternalReference ExternalReference { get; set; }

        public XElement Serialize()
        {
          return new XElement(UblNames.Cac + nameof(Attachment),
              EmbeddedDocumentBinaryObject.Serialize(nameof(EmbeddedDocumentBinaryObject)),
              EmbeddedDocument.Serialize(nameof(EmbeddedDocument)), 
              ExternalReference.Serialize()
           );
        }
    }
}