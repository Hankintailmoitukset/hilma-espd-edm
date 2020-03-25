using System.ComponentModel.DataAnnotations;

namespace Hilma.UBL.PrimitiveTypes
{
  public abstract class StringType
  {
    protected StringType()
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