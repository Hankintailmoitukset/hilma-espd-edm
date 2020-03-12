﻿using UBL.UnqualifiedDataTypes;


namespace UBL.CommonAggregateComponents
{
    public class AttachmentType
    {
        /// <summary>
        /// A binary large object containing an attached document.
        /// </summary>
        // TODO convert to base64Binary
        public byte[] EmbeddedDocumentBinaryObject { get; set; }

        /// <summary>
        /// A clear text object containing an attached document.
        /// </summary>
        public TextType EmbeddedDocument { get; set; }
        /// <summary>
        /// A reference to an attached document that is external to the document(s) being exchanged.
        /// </summary>
        public ExternalReferenceType ExternalReference { get; set; }
        
    }

}