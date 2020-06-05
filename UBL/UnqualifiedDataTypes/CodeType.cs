using System.ComponentModel.DataAnnotations;
using Hilma.UBL.Attributes;

namespace Hilma.UBL.UnqualifiedDataTypes
{
  /// <summary>
  /// A character string (letters, figures, or symbols) that for brevity and/or language
  /// independence may be used to represent or replace a definitive value or text of an
  /// attribute together with relevant supplementary information.
  /// </summary>
  [Contract]
  public class CodeType : IListValueType, ILocalizableType
  {
    protected bool Equals(CodeType other)
    {
      return ListID == other.ListID && ListName == other.ListName && ListAgencyID == other.ListAgencyID && ListAgencyName == other.ListAgencyName && ListVersionID == other.ListVersionID && ListURI == other.ListURI && ListSchemeURI == other.ListSchemeURI && Name == other.Name && LanguageID == other.LanguageID && Value == other.Value;
    }

    public override bool Equals(object obj)
    {
      if (ReferenceEquals(null, obj)) return false;
      if (ReferenceEquals(this, obj)) return true;
      if (obj.GetType() != this.GetType()) return false;
      return Equals((CodeType) obj);
    }

    public override int GetHashCode()
    {
      unchecked
      {
        var hashCode = (ListID != null ? ListID.GetHashCode() : 0);
        hashCode = (hashCode * 397) ^ (ListName != null ? ListName.GetHashCode() : 0);
        hashCode = (hashCode * 397) ^ (ListAgencyID != null ? ListAgencyID.GetHashCode() : 0);
        hashCode = (hashCode * 397) ^ (ListAgencyName != null ? ListAgencyName.GetHashCode() : 0);
        hashCode = (hashCode * 397) ^ (ListVersionID != null ? ListVersionID.GetHashCode() : 0);
        hashCode = (hashCode * 397) ^ (ListURI != null ? ListURI.GetHashCode() : 0);
        hashCode = (hashCode * 397) ^ (ListSchemeURI != null ? ListSchemeURI.GetHashCode() : 0);
        hashCode = (hashCode * 397) ^ (Name != null ? Name.GetHashCode() : 0);
        hashCode = (hashCode * 397) ^ (LanguageID != null ? LanguageID.GetHashCode() : 0);
        hashCode = (hashCode * 397) ^ (Value != null ? Value.GetHashCode() : 0);
        return hashCode;
      }
    }

    /// <summary>
    /// The identification of a list of codes.
    /// </summary>
    public string ListID { get; set; }

    /// <summary>
    /// The name of a list of codes.
    /// </summary>
    public string ListName { get; set; }
    /// <summary>
    /// An agency that maintains one or more lists of codes.
    /// </summary>
    /// <remarks>Defaults to the UN/EDIFACT data element 3055 code list.</remarks>
    public string ListAgencyID { get; set; }

    /// <summary>
    /// The name of the agency that maintains the list of codes.
    /// </summary>
    public string ListAgencyName { get; set; }

    /// <summary>
    /// The version of the list of codes.
    /// </summary>
    public string ListVersionID { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public string ListURI { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public string ListSchemeURI { get; set; }

    /// <summary>
    /// The textual equivalent of the code content component.
    /// </summary>
    public string Name { get; set; }


    /// <summary>
    /// The identifier of the language used in the code name.
    /// </summary>
    [RegularExpression("([a-zA-Z]{2}|[iI]-[a-zA-Z]+|[xX]-[a-zA-Z]{1,8})(-[a-zA-Z]{1,8})*")]
    public string LanguageID { get; set; }

    public CodeType()
    {
    }

    public CodeType(string value)
    {
      Value = value;
    }

    /// <summary>
    /// The value of the code
    /// </summary>
    public string Value { get; set; }
    
  }
}
