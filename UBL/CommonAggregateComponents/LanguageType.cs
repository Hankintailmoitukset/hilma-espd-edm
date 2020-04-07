using System.ComponentModel.DataAnnotations;
using Hilma.UBL.Attributes;
using Hilma.UBL.UnqualifiedDataTypes;

namespace Hilma.UBL.CommonAggregateComponents
{
  [Contract]
  public class LanguageType
  {
    [Required]
    public IdentifierType ID { get; set; }

    public string Name { get; set; }

    public CodeType LocaleCode { get; set; }

  }
}
