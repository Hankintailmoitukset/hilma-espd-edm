using System.Xml.Linq;
using Hilma.UBL.Serializers;
using Hilma.UBL.UnqualifiedDataTypes;

namespace Hilma.UBL.CommonAggregateComponents
{
  public class ContractingActivity
  {
    public CodeType ActivityTypeCode { get; set; }

    public string ActivityType { get; set; }

    public XElement Serialize()
    {
      return new XElement(UblNames.Cac + nameof(ContractingActivity),
        ActivityTypeCode.Serialize(nameof(ActivityTypeCode)),
        ActivityType.Serialize(nameof(ActivityType))
        );
    }
  }
}