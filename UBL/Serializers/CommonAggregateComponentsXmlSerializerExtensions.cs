using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using UBL.CommonAggregateComponents;
using UBL.PrimitiveTypes;

namespace UBL.Serializers
{
  public static class CommonAggregateComponentsXmlSerializerExtensions

  {

    public static XElement Serialize(this TenderingCriterion criterion)
    {
      return new XElement(UblNames.Cac + nameof(TenderingCriterion),
        criterion.Id?.Serialize(),
        Element(nameof(criterion.Name), criterion?.Name),
        Elements( nameof(criterion.Description), criterion?.Description ),
        criterion.TenderingCriterionPropertyGroups.Select( g => g.Serialize( nameof( TenderingCriterionPropertyGroup )))
      );
    }

    public static IEnumerable<XElement> Serialize(this IEnumerable<TenderingCriterionPropertyGroup> groups, string name)
    {
      foreach (var group in groups)
      {
        yield return group.Serialize( name );
      }
    }
     

    public static XElement Serialize(this TenderingCriterionPropertyGroup group, string name)
    {
      return new XElement(UblNames.Cac + name, 
        group.Id?.Serialize());
    }

    public static IEnumerable<XElement> Elements(string name, params string[] values)
    {
      return values?.Select(elem => new XElement(UblNames.Cbc + name, elem ));
    }

    public static IEnumerable<XElement> Elements(string name, params StringType[] values)
    {
      return values?.Select(elem => new XElement(UblNames.Cbc + name, elem.ToString()));
    }


    public static XElement Element(string name, string value)
    {
      return new XElement(UblNames.Cbc + name, value);
    }

  }
}