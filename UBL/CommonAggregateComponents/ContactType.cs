using Hilma.UBL.Attributes;

namespace Hilma.UBL.CommonAggregateComponents
{
  /// <summary>
  /// Used to provide contacting information for a party in general or a person.
  /// </summary>
  [Contract]
  public class ContactType
  {
    /// <summary>
    /// The name of the contact point.
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// A phone number for the contact point.
    /// </summary>
    public string Telephone { get; set; }

    /// <summary>
    /// A fax number for the contact point.
    /// </summary>
    public string Telefax { get; set; }

    /// <summary>
    /// An e-mail address for the contact point.
    /// </summary>
    public string ElectronicMail { get; set; }
  }
}