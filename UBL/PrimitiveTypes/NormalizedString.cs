using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;
using Hilma.UBL.Attributes;

namespace Hilma.UBL.PrimitiveTypes
{
  /// <summary>
  /// Normalized one line string value that does not contain other whitespace characters than spaces.
  /// Whitespaces are automatically converted to spaces.
  /// </summary>
  [Contract]
  public class NormalizedString
  {
    protected bool Equals(NormalizedString other)
    {
      return _value == other._value;
    }

    public override bool Equals(object obj)
    {
      if (ReferenceEquals(null, obj)) return false;
      if (ReferenceEquals(this, obj)) return true;
      if (obj.GetType() != this.GetType()) return false;
      return Equals((NormalizedString) obj);
    }

    public override int GetHashCode()
    {
      return (_value != null ? _value.GetHashCode() : 0);
    }

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

    public static implicit operator string(NormalizedString s) => s.Value;

    public static implicit operator NormalizedString(string s) => new NormalizedString(s);

  }
}