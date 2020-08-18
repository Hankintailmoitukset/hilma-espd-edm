using System.Xml.Linq;

namespace Hilma.Espd.EDM.Serializers
{
  public static class EspdNames
  {
      /// <summary>
      /// Qualification application request namespace
      /// </summary>
      public static readonly XNamespace Qarq =
          "urn:oasis:names:specification:ubl:schema:xsd:QualificationApplicationRequest-2";
      
      /// <summary>
      /// Qualification application response namespace
      /// </summary>
      public static readonly XNamespace Qarp =
        "urn:oasis:names:specification:ubl:schema:xsd:QualificationApplicationResponse-2";
  }
}