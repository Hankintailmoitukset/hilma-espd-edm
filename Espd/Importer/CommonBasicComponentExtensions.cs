using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using Hilma.UBL.Serializers;
using Hilma.UBL.UnqualifiedDataTypes;

namespace Hilma.Espd.EDM.Importer
{
  public static class CommonBasicComponentExtensions
  {
    public static IdentifierType ParseIdentifier(this XElement element)
    {
      if (element == null) return null;

      if (element.Name.Namespace != UblNames.Cbc)
        throw new ArgumentOutOfRangeException(nameof(element), $"Element should be in namespace: {UblNames.Cbc}");

      return new IdentifierType(element.Value)
      {
        SchemeURI = element.Attribute("schemeURI")?.Value,
        SchemeAgencyID = element.Attribute("schemeAgencyID")?.Value,
        SchemeID = element.Attribute("schemeID")?.Value,
        SchemeAgencyName = element.Attribute("schemeAgencyName")?.Value,
        SchemeDataURI = element.Attribute("schemeDataURI")?.Value,
        SchemeName = element.Attribute("schemeName")?.Value,
        SchemeVersionID = element.Attribute("schemeVersionID")?.Value,
      };
    }

    public static CodeType ParseCode(this XElement element)
    {
      if (element == null) return null;

      if (element.Name.Namespace != UblNames.Cbc)
        throw new ArgumentOutOfRangeException(nameof(element), $"Element should be in namespace: {UblNames.Cbc}");

      return new CodeType(element.Value)
      {
        Name = element.Attribute("name")?.Value,
        ListVersionID = element.Attribute("listVersionID")?.Value,
        ListID = element.Attribute("listID")?.Value,
        ListAgencyID = element.Attribute("listAgencyID")?.Value,
        LanguageID = element.Attribute("languageID")?.Value,
        ListSchemeURI = element.Attribute("listSchemeURI")?.Value,
        ListAgencyName = element.Attribute("listAgencyName")?.Value,
        ListURI = element.Attribute("listURI")?.Value,
        ListName = element.Attribute("listName")?.Value
      };
    }

    public static bool? ParseBool(this XElement element)
    {
      if (element == null) return null;

      if (element.Name.Namespace != UblNames.Cbc)
        throw new ArgumentOutOfRangeException(nameof(element), $"Element should be in namespace: {UblNames.Cbc}");

      return Boolean.Parse(element.Value);
    }

    public static DateType ParseDate(this XElement element)
    {
      if (element == null) return null;

      if (element.Name.Namespace != UblNames.Cbc)
        throw new ArgumentOutOfRangeException(nameof(element), $"Element should be in namespace: {UblNames.Cbc}");

      var dateValue = element.Value != null && element.Value.Length >= 10 ? element.Value.Substring(0,10): string.Empty;
      
      return DateTime.TryParse(dateValue, out var date) ? new DateType(date) : null;
    }

    public static TimeType ParseTime(this XElement element)
    {
      if (element == null) return null;

      if (element.Name.Namespace != UblNames.Cbc)
        throw new ArgumentOutOfRangeException(nameof(element), $"Element should be in namespace: {UblNames.Cbc}");

      var timeParts = element.Value.Split(':', '.', '+').Select(v => !string.IsNullOrEmpty(v) ? int.Parse(v) : 0).ToList();

      if (timeParts.Count < 2)
      {
        throw new ArgumentOutOfRangeException("element", $"Value: {element.Value} is not valid time value");
      }

      return new TimeType()
      {
        Hour = timeParts[0],
        Minute = timeParts[1],
        Second = timeParts.Count > 2 ? timeParts[2] : 0
      };
    }

    public static string[] ParseDescription(this IEnumerable<XElement> elements)
    {
      return elements?.Select(l => l.Value).ToArray();
    }

    public static MeasureType ParseMeasure(this XElement measure)
    {
      if (measure == null)
      {
        return null;
      }

      return !decimal.TryParse(measure.Value, out decimal value) ? null : new MeasureType(value, measure.Attribute("unitCode")?.Value);
    }

    public static AmountType ParseAmount(this XElement amount)
    {
      if (amount == null)
      {
        return null;
      }

      return decimal.TryParse(amount.Value, out var value) ? new AmountType(value)
      {
        CurrencyID = amount.Attribute("currencyId")?.Value,
        CurrencyCodeListVersionID = amount.Attribute("currentyCodeListVersionID")?.Value
      } : null;
    }

    public static QuantityType ParseQuantity(this XElement element)
    {
      if (element == null)
      {
        return null;
      }

      return decimal.TryParse(element.Value, out var value) ? new QuantityType(value)
      {
        UnitCode = element.Attribute("unitCode")?.Value,
        UnitCodeListAgencyName = element.Attribute("unitCodeListAgencyName")?.Value,
        UnitCodeListID = element.Attribute("unitCodeListID")?.Value
      } : null;
    }

    public static decimal? ParseDecimal(this XElement element)
    {
      if (element == null)
      {
        return null;
      }

      return decimal.TryParse(element.Value, out var value) ? value : (decimal?) null;
    }
  }
}