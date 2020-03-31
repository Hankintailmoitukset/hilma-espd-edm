using Hilma.UBL.Attributes;

namespace Hilma.UBL.UnqualifiedDataTypes
{
  /// <summary>
  /// A character string that constitutes the distinctive designation of a person, place, thing or concept.
  /// </summary>
  [Contract]
  public class NameType : TextType
  {
    public NameType()
    {
    }

    public NameType(string value) : base( value ) {
    }

    public static implicit operator NameType(string t) => new NameType(t);
    
  }
}