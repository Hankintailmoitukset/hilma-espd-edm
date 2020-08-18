using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;
using Hilma.UBL.Attributes;
using Hilma.UBL.Serializers;
using Hilma.UBL.UnqualifiedDataTypes;

namespace Hilma.UBL.CommonAggregateComponents
{
  [Contract]
  public class Language
  {
    [Required]
    public IdentifierType ID { get; set; }

    public string Name { get; set; }

    public CodeType LocaleCode { get; set; }

    public XElement Serialize()
    {
      return new XElement(UblNames.Cac + nameof(Language),
        ID.Serialize(nameof(ID)),
        Name.Serialize(nameof(Name)),
        LocaleCode.Serialize(nameof(LocaleCode)));
    }
  }
}
