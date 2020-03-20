using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace Hilma.UBL.PrimitiveTypes
{
  /// <summary>
  /// Normalized one line string value that does not contain other whitespace characters than spaces.
  /// Whitespaces are automatically converted to spaces.
  /// </summary>
  public class NormalizedString
  {
    private string _value = string.Empty;

    [Required]
    public string Value
    {
      get => _value;
      set => _value = Regex.Replace(value, @"\s+", " ");
    }

    public NormalizedString()
    {
    }
    public NormalizedString(string value)
    {
      _value = value;
    }

    public override string ToString()
    {
      return _value;
    }
  }
}