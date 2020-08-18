using System.Xml.Linq;
using Hilma.UBL.Attributes;
using Hilma.UBL.Serializers;
using Hilma.UBL.UnqualifiedDataTypes;

namespace Hilma.UBL.CommonAggregateComponents
{
  [Contract]
  public class ContractingPartyType
  {
    /// <summary>
    /// 
    /// </summary>
    public CodeType PartyTypeCode { get; set; }

    public string PartyType { get; set; }

    public XElement Serialize()
    {
      return new XElement(UblNames.Cac + nameof(ContractingPartyType),
        PartyTypeCode.Serialize(nameof(PartyType)),
        PartyType.Serialize(nameof(PartyType))
        );
    }

  }

}
