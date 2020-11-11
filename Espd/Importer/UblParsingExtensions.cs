using System.Collections.Generic;
using System.Xml.Linq;
using Hilma.UBL.Serializers;

namespace Hilma.Espd.EDM.Importer
{
  public static class UblParsingExtensions
  {
    public static XElement Cbc(this XElement parent, string name)
    {
      return parent?.Element(UblNames.Cbc + name);
    }

    public static IEnumerable<XElement> Cbcs(this XElement parent, string name)
    {
      return parent?.Elements(UblNames.Cbc + name);
    }

    public static IEnumerable<XElement> Cacs(this XElement parent, string name)
    {
      return parent?.Elements(UblNames.Cac + name);
    }

    public static XElement Cac(this XElement parent, string name)
    {
      return parent?.Element(UblNames.Cac + name);
    }

    
  }
}