using UBL.UnqualifiedDataTypes;

namespace UBL.CommonAggregateComponents
{
  /// <summary>
  /// Used to provide contacting information for a party in general or a person.
  /// </summary>
  public class ContactType
  {
    /// <summary>
    /// The name of the contact point.
    /// </summary>
    public NameType Name { get; set; }

    /// <summary>
    /// A phone number for the contact point.
    /// </summary>
    public TextType Telephone { get; set; }

    /// <summary>
    /// A fax number for the contact point.
    /// </summary>
    public TextType Telefax { get; set; }

    /// <summary>
    /// An e-mail address for the contact point.
    /// </summary>
    public TextType ElectronicMail { get; set; }
  }
}