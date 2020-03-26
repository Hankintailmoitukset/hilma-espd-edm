using Hilma.UBL.PrimitiveTypes;

namespace Hilma.UBL.UnqualifiedDataTypes
{
  /// <summary>
  /// >A character string to identify and uniquely distinguish one instance of an object in an identification scheme from 
  /// all other objects in the same scheme, together with relevant supplementary information.
  /// </summary>
 public class IdentifierType : NormalizedString, ISchemedType
  {
   
    /// <summary>
    /// The identification of the identification scheme.
    /// </summary>
    public string SchemeID { get; set; }

    /// <summary>
    /// The name of the identification scheme.
    /// </summary>
    public string SchemeName { get; set; }

    /// <summary>
    /// The id of the agency that maintains the identification scheme.
    /// </summary>
    public string SchemeAgencyID { get; set; }

    /// <summary>
    /// The name of the agency that maintains the identification scheme.
    /// </summary>
    public string SchemeAgencyName { get; set; }

    /// <summary>
    /// The version of the identification scheme.
    /// </summary>
    public string SchemeVersionID { get; set; }

    /// <summary>
    /// The Uniform Resource Identifier that identifies where the identification scheme data is located.
    /// </summary>
    public string SchemeDataURI { get; set; }

    /// <summary>
    /// The Uniform Resource Identifier that identifies where the identification scheme is located.
    /// </summary>
    public string SchemeURI { get; set; }


    public IdentifierType()
    {
    }

    public IdentifierType(string value )
    {
      Value = value;
    }

    public static implicit operator string(IdentifierType c) => c.Value;

    public static implicit operator IdentifierType(string s) => new IdentifierType(s);
  }
 
}
