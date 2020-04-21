using Hilma.UBL.Attributes;
using Hilma.UBL.UnqualifiedDataTypes;

namespace Hilma.UBL.CommonAggregateComponents
{
    [Contract]
    public class ExternalReferenceType
    {
        public IdentifierType URI { get; set; }
        public string DocumentHash { get; set; }
        public string HashAlgorithmMethod { get; set; }
        public DateType ExpiryDate { get; set; }
        public TimeType ExpiryTime { get; set; }
        public CodeType MimeCode { get; set; }
        public CodeType FormatCode { get; set; }
        public CodeType EncodingCode { get; set; }
        public CodeType CharacterSetCode { get; set; }
        public string FileName { get; set; }
        public string[] Description { get; set; }

    }

}