using Hilma.UBL.Attributes;
using Hilma.UBL.UnqualifiedDataTypes;

namespace Hilma.UBL.CommonAggregateComponents
{
  /// <summary>
  /// 
  /// </summary>
  [Contract]
  public class CommodityClassificationType
  {
    /// <summary>
    /// The code of the classification
    /// </summary>
    public CodeType ItemClassificationCode { get; set; }
  }
}