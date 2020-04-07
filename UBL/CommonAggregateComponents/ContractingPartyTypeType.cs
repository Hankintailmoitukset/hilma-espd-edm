using Hilma.UBL.Attributes;
using Hilma.UBL.UnqualifiedDataTypes;

namespace Hilma.UBL.CommonAggregateComponents
{
  [Contract]
  public class ContractingPartyTypeType
  {
    /// <summary>
    /// 
    /// </summary>
    public CodeType PartyTypeCode { get; set; }

    public string PartyType { get; set; }

  }

}
