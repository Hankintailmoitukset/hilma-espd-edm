using Hilma.UBL.Attributes;
using Hilma.UBL.UnqualifiedDataTypes;

namespace Hilma.UBL.CommonAggregateComponents
{
  [Contract]
  public class ResultOfVerificationType
  {
    public IdentifierType ValidatorID { get; set; }
    public CodeType ValidationResultCode { get; set; }
    public DateType ValidationDate { get; set; }
    public TimeType ValidationTime { get; set; }
    public string ValidateProcess { get; set; }
    public string ValidateTool { get; set; }
    public string ValidateToolVersion { get; set; }
    public PartyType SignatoryParty { get; set; }

  }

}