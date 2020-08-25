using System.Xml.Linq;
using Hilma.UBL.Attributes;
using Hilma.UBL.Serializers;

namespace Hilma.UBL.CommonAggregateComponents
{
  /// <summary>
  /// Used to provide contacting information for a party in general or a person.
  /// </summary>
  [Contract]
  public class Contact
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


    public XElement Serialize()
    {
      return new XElement(UblNames.Cac + nameof(Contact),
        Name?.Serialize(nameof(Name)),
        Telephone?.Serialize(nameof(Telephone)),
        Telefax?.Serialize(nameof(Telefax)),
        ElectronicMail?.Serialize(nameof(ElectronicMail))
      );
    }
  }
}