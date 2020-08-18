using System;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Xml.Linq;
using Hilma.UBL.UnqualifiedDataTypes;

namespace Hilma.UBL.Serializers
{
  public static class StringExtensions
  {
    public static string FirstToLower(this string str)
    {
      var first = str.Substring(0, 1).ToLower();
      return $"{first}{str.Substring(1)}";
    }
  } 

  public static class CommonBasicComponentsXmlSerializerExtensions
  {
   
    public static XElement Serialize(this IdentifierType id, string name )
    {
      if (id?.Value == null)
        return null;

      return Element(name, id.Value, 
        new []
        {
          Attribute( nameof(id.SchemeAgencyID), id.SchemeAgencyID ),
          Attribute( nameof(id.SchemeAgencyName), id.SchemeAgencyName ),
          Attribute( nameof(id.SchemeDataURI), id.SchemeDataURI ),
          Attribute( nameof(id.SchemeID), id.SchemeID ),
          Attribute( nameof(id.SchemeName), id.SchemeName ),
          Attribute( nameof(id.SchemeURI), id.SchemeURI ),
          Attribute( nameof(id.SchemeVersionID), id.SchemeVersionID ),
        }
        );
    }

    public static XElement Serialize(this CodeType code, string name)
    {
      if (code?.Value == null)
        return null;

      return Element(name, code.Value,
        new[]
        {
          Attribute(nameof(code.LanguageID), code.LanguageID),
          Attribute(nameof(code.ListID), code.ListID),
          Attribute(nameof(code.ListAgencyID), code.ListAgencyID),
          Attribute(nameof(code.ListVersionID), code.ListVersionID),
          Attribute(nameof(code.ListAgencyName), code.ListAgencyName),
          Attribute(nameof(code.ListSchemeURI), code.ListSchemeURI),
        }
      );
    }

    public static XElement Serialize(this MeasureType measure, string name)
    {
      if (measure?.Value == null)
        return null;

      return Element(name, measure.Value,
        new[]
        {
          Attribute(nameof(measure.UnitCode), measure.UnitCode),
          Attribute(nameof(measure.UnitCodeListAgencyName), measure.UnitCodeListAgencyName),
          Attribute(nameof(measure.UnitCodeListID), measure.UnitCodeListID)
        }
      );
    }

    public static XElement Serialize(this AmountType measure, string name)
    {
      if (measure?.Value == null)
        return null;

      return Element(name, measure.Value.ToString("F"),
        new[]
        {
          Attribute(nameof(measure.CurrencyCodeListVersionID), measure.CurrencyCodeListVersionID),
          Attribute(nameof(measure.CurrencyID), measure.CurrencyID),
        }
      );
    }

    public static XElement Serialize(this decimal? number, string name)
    {
      return number.HasValue ? Element(name, number.Value.ToString(CultureInfo.InvariantCulture)) : null;
    }

    public static XElement Serialize(this bool? value, string name)
    {
      if (!value.HasValue)
        return null;

      return new XElement(UblNames.Cbc + name,value.ToString().ToLower());
    }

    public static XElement Serialize(this bool value, string name)
    {
      return new XElement(UblNames.Cbc + name, value.ToString().ToLower());
    }

    public static XElement Serialize(this DateType value, string name)
    {
      return value != null ? new XElement(UblNames.Cbc + name, value.ToString()) : null;
    }

    public static XElement SerializeAsDate(this DateTime value, string name)
    {
      return value != null ? new XElement(UblNames.Cbc + name, value.ToString("yyyy-MM-dd")) : null;
    }

    public static XElement Serialize(this TimeType value, string name)
    {
      return value != null ? new XElement(UblNames.Cbc + name, value.ToString()) : null;
    }

    public static XElement Serialize(this object value, string name)
    {
      return value != null ? new XElement(UblNames.Cbc + name, value.ToString()) : null;
    }

    public static object Serialize(this string[] text, string name)
    {
      return text?.Select( t => new XElement(UblNames.Cbc + name, t));
    }

    public static XElement Element(string name, object value, XAttribute[] attributes)
    {
      return value != null ? new XElement(UblNames.Cbc + name, value, attributes) : null;
    }

    public static XAttribute Attribute(string name, object value)
    {
      return value == null ? null : new XAttribute(name.FirstToLower(), value);
    }


    public static XElement Element(string name, object value)
    {
      return new XElement(UblNames.Cbc + name, value);
    }
  }
}