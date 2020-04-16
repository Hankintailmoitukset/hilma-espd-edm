using System.Xml.Linq;
using Hilma.UBL.UnqualifiedDataTypes;

namespace Hilma.UBL.Serializers
{
  public static class CommonBasicComponentsXmlSerializerExtensions
  {
   
    public static XElement Serialize(this IdentifierType id)
    {
      return Element("ID", id.Value );
    }
    
    public static XElement Element(string name, object value)
    {
      return new XElement(UblNames.Cbc + name, value);
    }
  }
}