namespace Hilma.UBL.Serializers
{
  public static class StringExtensions
  {
    public static string FirstToLower(this string str)
    {
      var first = str.Substring(0, 1).ToLower();
      return $"{first}{str.Substring(1)}";
    }
  }
}