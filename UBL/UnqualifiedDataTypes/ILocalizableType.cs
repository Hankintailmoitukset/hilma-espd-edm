namespace Hilma.UBL.UnqualifiedDataTypes
{
  public interface ILocalizableType
  {
    /// <summary>
    /// The localized textual equivalent of the content component.
    /// </summary>
    string Name { get; set; }

    /// <summary>
    /// The identifier of the language used in the localized name
    /// </summary>
    string LanguageID { get; set; }
  }
}