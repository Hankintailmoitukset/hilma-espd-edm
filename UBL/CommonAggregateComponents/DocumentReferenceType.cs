using UBL.UnqualifiedDataTypes;

namespace UBL.CommonAggregateComponents
{
    public class DocumentReferenceType
    {
        public IdentifierType ID { get; set; }
     // public  IndicatorType { get; set; } //boolean TODO
        public IdentifierType UUID { get; set; }
        public DateType IssueDate { get; set; }
        public TimeType IssueTime { get; set; }
        public CodeType DocumentTypeCode { get; set; }
        public TextType DocumentType { get; set; }
        public TextType[] XPath { get; set; }
        public IdentifierType LanguageID { get; set; }
        public CodeType LocaleCode { get; set; }
        public IdentifierType VersionID { get; set; }
        public CodeType DocumentStatusCode { get; set; }
        public TextType[] DocumentDescription { get; set; }
        //TODO
        public AttachmentType Attachment { get; set; }
        public PeriodType ValidityPeriod { get; set; }

        //TODO
        public PartyType IssuerParty { get; set; }
        //TODO
        public ResultOfVerificationType ResultOfVerification { get; set; }

    }

}