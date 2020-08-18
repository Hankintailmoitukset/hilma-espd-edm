using System.Xml.Linq;
using Hilma.UBL.Attributes;
using Hilma.UBL.Serializers;
using Hilma.UBL.UnqualifiedDataTypes;

namespace Hilma.UBL.CommonAggregateComponents
{
    [Contract]
    public class DocumentReference
    {
        /// <summary>
        /// An identifier for the referenced document.
        /// </summary>
        public IdentifierType ID { get; set; }
        /// <summary>
        /// An indicator that the referenced document is a copy (true) or the original (false).
        /// </summary>
        public bool CopyIndicator { get; set; }
        /// <summary>
        /// A universally unique identifier for this document reference.
        /// </summary>
        public IdentifierType UUID { get; set; }
        /// <summary>
        /// The date, assigned by the sender of the referenced document, on which the document was issued.
        /// </summary>
        public DateType IssueDate { get; set; }
        /// <summary>
        /// The time, assigned by the sender of the referenced document, at which the document was issued.
        /// </summary>
        public TimeType IssueTime { get; set; }
        /// <summary>
        /// The type of document being referenced, expressed as a code.
        /// </summary>
        public CodeType DocumentTypeCode { get; set; }
        /// <summary>
        /// The type of document being referenced, expressed as text.
        /// </summary>
        public string DocumentType { get; set; }
        /// <summary>
        /// A reference to another place in the same XML document instance in which DocumentReference appears.
        /// </summary>
        public string[] XPath { get; set; }
        /// <summary>
        /// An identifier for the language used in the referenced document.
        /// </summary>
        public IdentifierType LanguageID { get; set; }
        /// <summary>
        /// A code signifying the locale in which the language in the referenced document is used.
        /// </summary>
        public CodeType LocaleCode { get; set; }
        /// <summary>
        /// An identifier for the current version of the referenced document.
        /// </summary>
        public IdentifierType VersionID { get; set; }
        /// <summary>
        /// A code signifying the status of the reference document with respect to its original state.
        /// </summary>
        public CodeType DocumentStatusCode { get; set; }
        /// <summary>
        /// Text describing the referenced document.
        /// </summary>
        public string[] DocumentDescription { get; set; }
        /// <summary>
        /// A class to describe an attached document. An attachment can refer to an external document or be included with the document being exchanged.
        /// </summary>
        public Attachment Attachment { get; set; }
        /// <summary>
        /// The period for which this document reference is valid.
        /// </summary>
        public Period ValidityPeriod { get; set; }
        /// <summary>
        /// The party who issued the referenced document.
        /// </summary>
        public Party IssuerParty { get; set; }
        /// <summary>
        /// The result of an attempt to verify a signature associated with the referenced document.
        /// </summary>
        public ResultOfVerification ResultOfVerification { get; set; }

    public XElement Serialize()
    {
      return new XElement(UblNames.Cac + nameof(DocumentReference),
        ID.Serialize(nameof(ID)),
        CopyIndicator.Serialize(nameof(CopyIndicator)),
        UUID.Serialize(nameof(UUID)),
        IssueDate.Serialize(nameof(IssueDate)),
        IssueTime.Serialize(nameof(IssueTime)),
        DocumentTypeCode.Serialize(nameof(DocumentTypeCode)),
        DocumentType.Serialize(nameof(DocumentType)),
        XPath.Serialize(nameof(XPath)),
        LanguageID.Serialize(nameof(LanguageID)),
        LocaleCode.Serialize(nameof(LocaleCode)),
        VersionID.Serialize(nameof(VersionID)),
        DocumentStatusCode.Serialize(nameof(DocumentStatusCode)),
        DocumentDescription.Serialize(nameof(DocumentDescription)),
        Attachment?.Serialize(),
        ValidityPeriod?.Serialize(nameof(ValidityPeriod)),
        IssuerParty.Serialize(nameof(IssuerParty))
        );
    }
  }

}
