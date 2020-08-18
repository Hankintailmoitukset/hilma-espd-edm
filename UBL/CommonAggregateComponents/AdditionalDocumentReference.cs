using System.Xml.Linq;
using Hilma.UBL.Attributes;
using Hilma.UBL.Serializers;
using Hilma.UBL.UnqualifiedDataTypes;

namespace Hilma.UBL.CommonAggregateComponents
{
  [Contract]
  public class AdditionalDocumentReference
  {
    /// <summary>
    /// The identifier for the referenced document, generally issued by the entity responsible for the document.
    /// </summary>
    /// <remarks>If the document referenced is a Contract Notice
    /// published on TED the ID must follow the scheme defined by the Publications Office:
    /// [][][][]/S [][][]-[][][][][][] (e.g. 2015/S 252-461137).
    /// If at the time of drafting the ESPD document the Publication Office has not published yet the Contract Notice the value 0000/S 000-000000 value must be used to indicate that a temporary identifier is being used.</remarks>
    public IdentifierType ID { get; set; }

    /// <summary>
    /// A universally unique identifier that can be used to reference this ESPD document instance.
    /// </summary>
    public IdentifierType UUID { get; set; }

    /// <summary>
    /// The type of document being referenced, expressed as a code.
    /// </summary>
    /// <remarks>For the ESDP-EDM it is compulsory use of the Code List DocRefContentType. See example below on how to specify the OJS Contract Notice. If, for other documents, the type of document is not available in this list, provide the code “Other” and describe the content in the element DocumentType.</remarks>
    public CodeType DocumentTypeCode { get; set; }

    /// <summary>
    /// The type of document being referenced, expressed as text.
    /// </summary>
    /// <remarks>Optionally use the attribute languageID to indicate the language of the text. Use the Code List LanguageCodeEU for the value of the languageID attribute.</remarks>
    public CodeType DocumentType { get; set; }

    /// <summary>
    /// Date when the document was issued by the contracting authority.
    /// </summary>
    /// <remarks>Format "YYYY-MM-DD". If available in the referenced document place here the data of publication by the contracting authority.</remarks>
    public DateType IssueDate { get; set; }


    /// <summary>
    /// Time when the document was issued by the contracting authority.
    /// </summary>
    /// <remarks>If available in the referenced document place here the time of publication by the contracting authority.</remarks>
    public TimeType IssueTime { get; set; }

    /// <summary>
    /// The class cac:AdditionalDocumentReference aggregates a subclass cac:Attachment that is used by ESPD to place the URI, name of the document and descriptions.
    /// </summary>
    public Attachment Attachment { get; set; }

    public XElement Serialize()
    {
      return new XElement(UblNames.Cac + nameof(AdditionalDocumentReference),
        ID.Serialize(nameof(ID)),
        UUID.Serialize(nameof(UUID)),
        IssueDate.Serialize(nameof(IssueDate)),
        IssueTime.Serialize(nameof(IssueTime)),
        DocumentTypeCode.Serialize(nameof(DocumentTypeCode)),
        DocumentType.Serialize(nameof(DocumentType)),
        Attachment?.Serialize());
    }
  }
}