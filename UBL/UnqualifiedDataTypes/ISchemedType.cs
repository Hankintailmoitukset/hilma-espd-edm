namespace UBL.UnqualifiedDataTypes
{
  public interface ISchemedType
  {
    /// <summary>
    /// The identification of the identification scheme.
    /// </summary>
    string? SchemeID { get; set; }

    /// <summary>
    /// The name of the identification scheme.
    /// </summary>
    string? SchemeName { get; set; }

    /// <summary>
    /// The name of the agency that maintains the identification scheme.
    /// </summary>
    string? SchemeAgencyName { get; set; }

    /// <summary>
    /// The version of the identification scheme.
    /// </summary>
    string? SchemeVersionID { get; set; }

    /// <summary>
    /// The Uniform Resource Identifier that identifies where the identification scheme data is located.
    /// </summary>
    string? SchemeDataURI { get; set; }

    /// <summary>
    /// The Uniform Resource Identifier that identifies where the identification scheme is located.
    /// </summary>
    string? SchemeURI { get; set; }
  }
}