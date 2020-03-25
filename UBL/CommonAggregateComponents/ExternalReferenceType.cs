using Hilma.UBL.UnqualifiedDataTypes;

namespace Hilma.UBL.CommonAggregateComponents
{
    public class ExternalReferenceType
    {
        public IdentifierType URI { get; set; }
        public TextType DocumentHash { get; set; }
        public TextType HashAlgorithmMethod { get; set; }
        public DateType ExpiryDate { get; set; }
        public TimeType ExpiryTime { get; set; }
        public CodeType MimeCode { get; set; }
        public CodeType FormatCode { get; set; }
        public CodeType EncodingCode { get; set; }
        public CodeType CharacterSetCode { get; set; }
        public TextType FileName { get; set; }
        public TextType[] Description { get; set; }

    }

}