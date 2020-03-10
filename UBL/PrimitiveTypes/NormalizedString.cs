using System.Text.RegularExpressions;

namespace UBL.PrimitiveTypes
{
  public abstract class NormalizedString
  {
    private string _value;

    public string Value
    {
      get => _value;
      set => _value = Regex.Replace(value, @"\s+", " ");
    }

    protected NormalizedString()
    {
    }
    protected NormalizedString(string value)
    {
      _value = value;
    }

    public override string ToString()
    {
      return _value;
    }
  }
}