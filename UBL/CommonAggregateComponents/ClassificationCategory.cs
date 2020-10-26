using System.Linq;
using System.Xml.Linq;
using Hilma.UBL.Attributes;
using Hilma.UBL.Serializers;
using Hilma.UBL.UnqualifiedDataTypes;

namespace Hilma.UBL.CommonAggregateComponents
{
  [Contract]
  public class ClassificationCategory
  {
    public string Name { get; set; }

    public CodeType CodeValue  { get; set; }

    public string[] Description { get; set; }

    public ClassificationCategory[] CategorizesClassificationCategories { get; set; }

    public XElement Serialize(string name = null)
    {
      return new XElement(UblNames.Cac + (name ?? nameof(ClassificationCategory)),
        Name.Serialize(nameof(Name)),
        Description?.Serialize(nameof(Description)),
        CategorizesClassificationCategories?.Select( c => c.Serialize("CategorizesClassificationCategory"))
      );
    }
  }
}