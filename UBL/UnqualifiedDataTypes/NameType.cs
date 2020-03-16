namespace UBL.UnqualifiedDataTypes
{
  /// <summary>
  /// A character string that constitutes the distinctive designation of a person, place, thing or concept.
  /// </summary>
  public class NameType : TextType
  {
    public NameType() : base() {
    }

    public NameType(string value) : base( value ) {
    }

    public static implicit operator NameType(string t) => new NameType(t);
    
  }
}