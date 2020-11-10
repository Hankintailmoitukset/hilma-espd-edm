using System;
using System.Runtime.CompilerServices;
using System.Text;
using System.Xml.Linq;
using System.Xml.XPath;
using Hilma.Espd.EDM.CriterionModels;
using Hilma.Espd.EDM.Serializers;

namespace Hilma.Espd.EDM.Importer
{
  public class QualificationApplicationResponseImporter
  {
    public QualificationApplicationResponse Parse(XDocument xml)
    {
      var rootName = EspdNames.Qarp + "QualificationApplicationResponse";
      var root = xml.Element(rootName);
      if (root == null)
      {
        throw new ArgumentOutOfRangeException(nameof(xml), $"Could not locate element: {rootName}");
      }

      return root.ParseQualificationApplicationResponse();

    }
  }
}
