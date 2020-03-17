using System.ComponentModel.DataAnnotations;
using Hilma.UBL.UnqualifiedDataTypes;

namespace Hilma.UBL.CommonAggregateComponents
{
  public class LanguageType
  {
    [Required]
    public IdentifierType ID { get; set; }

    public NameType Name { get; set; }

    public CodeType LocaleCode { get; set; }

  }
}
