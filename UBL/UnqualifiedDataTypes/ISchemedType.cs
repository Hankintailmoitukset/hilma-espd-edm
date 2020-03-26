namespace Hilma.UBL.UnqualifiedDataTypes
{
  public interface ISchemedType
  {
    /// <summary>
    /// The identification of the scheme.
    /// </summary>
    string SchemeID { get; set; }

    /// <summary>
    /// The name of the scheme.
    /// </summary>
    string SchemeName { get; set; }

    /// <summary>
    /// The name of the agency that maintains the scheme.
    /// </summary>
    string SchemeAgencyName { get; set; }

    /// <summary>
    /// The version of the identification scheme.
    /// </summary>
    string SchemeVersionID { get; set; }

    /// <summary>
    /// The Uniform Resource Identifier that identifies where the identification scheme data is located.
    /// </summary>
    string SchemeDataURI { get; set; }

    /// <summary>
    /// The Uniform Resource Identifier that identifies where the identification scheme is located.
    /// </summary>
    string SchemeURI { get; set; }
  }
}