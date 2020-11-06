using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using Hilma.Espd.EDM.CriterionModels;
using Hilma.Espd.EDM.Serializers;
using Hilma.UBL.CommonAggregateComponents;
using Hilma.UBL.Serializers;
using Hilma.UBL.UnqualifiedDataTypes;
using static System.Boolean;

namespace Hilma.Espd.EDM.Importer
{
  public static class UblParserExtrensions
  {
    public static XElement Cbc(this XElement parent, string name)
    {
      return parent?.Element(UblNames.Cbc + name);
    }

    public static XElement Cac(this XElement parent, string name)
    {
      return parent?.Element(UblNames.Cac + name);
    }

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
        ListAgencyID =  element.Attribute("listAgencyID")?.Value,
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

      return Parse(element.Value);
    }

    public static DateType ParseDate(this XElement element)
    {
      if (element == null) return null;

      if (element.Name.Namespace != UblNames.Cbc)
        throw new ArgumentOutOfRangeException(nameof(element), $"Element should be in namespace: {UblNames.Cbc}");

      if (!DateTime.TryParse(element.Value, out DateTime date))
        return null;

      return new DateType(date);
    }

    public static TimeType ParseTime(this XElement element)
    {
      if (element == null) return null;

      if (element.Name.Namespace != UblNames.Cbc)
        throw new ArgumentOutOfRangeException(nameof(element), $"Element should be in namespace: {UblNames.Cbc}");

      var timeParts = element.Value.Split(':', '.','+').Select( v => !string.IsNullOrEmpty(v) ? int.Parse(v): 0 ).ToList();
      
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
  }

  public class QualificationApplicationResponseImporter
  {
    public QualificationApplicationResponse Parse(XDocument xml)
    {
      var rootName = EspdNames.Qarp + "QualificationApplicationResponse";
      var root = xml.Element(rootName);
      if (root == null)
      {
        throw new ArgumentOutOfRangeException(nameof(xml),  $"Could not locate element: {rootName}");
      }

      return ParseQualificationApplicationResponse(root);

    }

    private static QualificationApplicationResponse ParseQualificationApplicationResponse(XElement root)
    {
      var response = new QualificationApplicationResponse()
      {
        UBLVersionID = root.Cbc("UBLVersionID").ParseIdentifier(),
        CustomizationID = root.Cbc("CustomizationID").ParseIdentifier(),
        ProfileID = root.Cbc("ProfileID").ParseIdentifier(),
        ID = root.Cbc("ID").ParseIdentifier(),
        CopyIndicator = root.Cbc("CopyIndicator").ParseBool(),
        UUID = root.Cbc("UUID").ParseIdentifier(),
        ContractFolderID = root.Cbc("ContractFolderID").ParseIdentifier(),
        IssueDate = root.Cbc("IssueDate").ParseDate(),
        IssueTime = root.Cbc("IssueTime").ParseTime(),
        ProcedureCode = root.Cbc("ProcedureCode").ParseCode(),
        QualificationApplicationTypeCode = root.Cbc("QualificationApplicationTypeCode").ParseCode(),
        EconomicOperatorGroupName = root.Cbc("EconomicOperatorGroupName").ParseCode()
        //ContractingParty = ParseContractingParty(root.Cac("ContractingParty")),
        //EconomicOperatorParty = ParseEconomicOperatorParty(root.Cac("EconomicOperatorParty")),

      };
      return response;
    }

    private static EconomicOperatorParty ParseEconomicOperatorParty(XElement party)
    {
      var eoPrty = new EconomicOperatorParty()
      {
        Party = ParseParty(party.Cac("Party")),
        EconomicOperatorRole = ParseEconomicOperatorRole(party.Cac("EconomicOperatorRole")),
        QualifyingParty = ParseQualifyingParty(party.Cac("QualifyingParty"))
      };

      return eoPrty;
    }

    private static QualifyingParty ParseQualifyingParty(XElement qualifyingParty)
    {
      throw new NotImplementedException();
    }

    private static EconomicOperatorRole ParseEconomicOperatorRole(XElement economicOperatorRole)
    {
      throw new NotImplementedException();
    }

    private static Party ParseParty(XElement party)
    {
      throw new NotImplementedException();
    }

    private static ContractingParty ParseContractingParty(XElement cac)
    {
      throw new NotImplementedException();
    }
  }
}
