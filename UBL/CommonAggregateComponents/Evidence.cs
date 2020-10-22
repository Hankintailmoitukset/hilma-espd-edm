using System;
using System.Linq;
using System.Xml.Linq;
using Hilma.UBL.Attributes;
using Hilma.UBL.Serializers;
using Hilma.UBL.UnqualifiedDataTypes;

namespace Hilma.UBL.CommonAggregateComponents
{
  [Contract]
    public class Evidence
    {
        public IdentifierType ID { get; set; }
        public CodeType EvidenceTypeCode { get; set; }
        public string Name { get; set; }
        public string[] Description { get; set; }
        public string[] CandidateStatement { get; set; }
        public CodeType ConfidentialityLevelCode { get; set; }
        public Party EvidenceIssuingParty { get; set; }
        public DocumentReference[] DocumentReference { get; set; }
        public Language Language { get; set; }

        public XElement Serialize(string name = null)
        {
          return new XElement(UblNames.Cac + ( name ?? nameof(Evidence)),
            ID.Serialize(nameof(ID)),
            EvidenceTypeCode.Serialize(nameof(EvidenceTypeCode)),
            Name.Serialize(nameof(Name)),
            Description.Serialize(nameof(Description)),
            CandidateStatement.Serialize(nameof(CandidateStatement)),
            ConfidentialityLevelCode.Serialize(nameof(ConfidentialityLevelCode)),
            EvidenceIssuingParty?.Serialize(nameof(EvidenceIssuingParty)),
            DocumentReference?.Select( dr => dr.Serialize())
            );
        }
    }

}