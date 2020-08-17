using System.Xml.Linq;
using Hilma.UBL.Attributes;
using Hilma.UBL.Serializers;
using Hilma.UBL.UnqualifiedDataTypes;

namespace Hilma.UBL.CommonAggregateComponents
{
  /// <summary>
  /// 
  /// </summary>
  [Contract]
  public class CommodityClassification
  {
    /// <summary>
    /// The code of the classification
    /// </summary>
    public CodeType ItemClassificationCode { get; set; }

    public XElement Serialize(string name)
    {
      return new XElement(UblNames.Cac + name,
        ItemClassificationCode?.Serialize(nameof(ItemClassificationCode)));
    }
  }
}