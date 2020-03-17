using System.Linq;
using System.Xml.Linq;
using Hilma.UBL.Serializers;

namespace Espd.Serializers
{
  public static class EspdSerializerExtensions
  {
   
    public static XElement Serialize(this QualificationApplicationRequest request)
    {
      return new XElement(EspdNames.Qar + nameof( QualificationApplicationRequest ),
        new XAttribute(XNamespace.Xmlns + "cbc", UblNames.Cbc),
        new XAttribute(XNamespace.Xmlns + "cac", UblNames.Cac),
        request.ID?.Serialize(),
        request.TenderingCriteria.Select( c => c.Serialize() )
        );
    }

  }
}