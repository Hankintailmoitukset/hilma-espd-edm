using Hilma.UBL.Attributes;
using Hilma.UBL.UnqualifiedDataTypes;

namespace Hilma.UBL.CommonAggregateComponents
{
    [Contract]
    public class EvidenceType
    {
        public IdentifierType ID { get; set; }
        public CodeType EvidenceTypeCode { get; set; }
        public string Name { get; set; }
        public string[] Description { get; set; }
        public string[] CandidateStatement { get; set; }
        public CodeType ConfidentialityLevelCode { get; set; }
        public Party EvidenceIssuingParty { get; set; }
        public DocumentReferenceType[] DocumentReference { get; set; }
        public Language Language { get; set; }

    }

}