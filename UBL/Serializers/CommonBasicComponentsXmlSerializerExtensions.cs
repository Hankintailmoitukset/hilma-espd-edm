using System.Xml.Linq;
using UBL.UnqualifiedDataTypes;

namespace UBL.Serializers
{
  public static class CommonBasicComponentsXmlSerializerExtensions
  {
   
    public static XElement Serialize(this IdentifierType id)
    {
      return Element("ID", id.Value );
    }

    public static XElement Serialize(this TextType text, string name )
    {
      return Element(name, text.Value);
    }

    public static XElement Element(string name, object value)
    {
      return new XElement(UblNames.Cbc + name, value);
    }
  }
}