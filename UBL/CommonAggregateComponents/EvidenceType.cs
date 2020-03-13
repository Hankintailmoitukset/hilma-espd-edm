using UBL.UnqualifiedDataTypes;

namespace UBL.CommonAggregateComponents
{
    public class EvidenceType
  {
        public IdentifierType ID { get; set; }
        public CodeType EvidenceTypeCode { get; set; }
        public NameType Name { get; set; }
        public TextType[] Description { get; set; }
        public TextType[] CandidateStatement { get; set; }
        public CodeType ConfidentialityLevelCode { get; set; }
        public PartyType EvidenceIssuingParty { get; set; }
        public DocumentReferenceType[] DocumentReference { get; set; }
        public LanguageType Language { get; set; }

    }

}