using System.ComponentModel.DataAnnotations;
using Hilma.UBL.Attributes;

namespace Hilma.UBL.PrimitiveTypes
{
  [Contract]
  public  class StringType
  {
    public StringType()
    {
    }


    /// <summary>
    /// The string content
    /// </summary>
    [Required]
    public string Value { get; set; } = string.Empty;

    public static implicit operator string(StringType s) => s.Value;

    public override string ToString()
    {
      return Value;
    }
  }
}