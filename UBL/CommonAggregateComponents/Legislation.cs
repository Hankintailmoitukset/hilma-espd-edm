using System.ComponentModel.DataAnnotations;
using UBL.UnqualifiedDataTypes;

namespace UBL.CommonAggregateComponents
{
  public class Legislation
  {
    [Required]
    public IdentifierType ID { get; set; }
    public TextType[] Titles { get; set; }
    public TextType[] Descriptions { get; set; }
    public TextType[] JurisdictionLevels { get; set; }
    public TextType[] Articles { get; set; }
    public string[] URIs { get; set; } 
    public LanguageType[] Languages { get; set; }
    public AddressType[] JurisdictionRegionAddresses { get; set; }

  }
}