using Hilma.UBL.UnqualifiedDataTypes;

namespace Hilma.UBL.CommonAggregateComponents
{
    public class ResultOfVerificationType
    {
        public IdentifierType ValidatorID { get; set; }
        public CodeType ValidationResultCode { get; set; }
        public DateType ValidationDate { get; set; }
        public TimeType ValidationTime { get; set; }
        public TextType ValidateProcess { get; set; }
        public TextType ValidateTool { get; set; }
        public TextType ValidateToolVersion { get; set; }
        public PartyType SignatoryParty { get; set; }

    }

}