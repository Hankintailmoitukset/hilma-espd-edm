using Hilma.Espd.EDM.CriterionModels.v2_1_0;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Xml.Linq;
using Hilma.Espd.EDM.CodeLists;
using Newtonsoft.Json.Serialization;
using static System.String;

namespace ResourceExporter
{
  class Program
  {
    const string RootUrl = "https://raw.githubusercontent.com/ESPD/ESPD-EDM/2.1.1/docs/src/main/asciidoc/dist/cl/gc/{0}.gc";
   
    static void Main(string[] args)
    {
      Console.WriteLine("Generating resources");
      
      const string lang = "name-eng";

      // get code lists
      foreach (var codeListId in CodeListIds.All)
      {
        CreateTypeCodeList(codeListId, lang);
      }

      // get tendering criteria
      var criterionSpecification = new CriterionSpecification().AllCriteria.ToArray();
      WriteToFile(criterionSpecification, $"{ToLowerFirstChar(nameof(CriterionSpecification))}.json");

      // copy translation
      var espdPath = Path.Combine(AppContext.BaseDirectory, "..", "..", "..", "..", "Espd");
      var sourceFile = Path.GetFullPath(Path.Combine(espdPath, "Localisation", "translations.default.json"));
      var targetPath = Path.GetFullPath(Path.Combine(espdPath, "typings", "translations.default.json"));
      Console.WriteLine("writing file to path: " + targetPath);
      File.Copy(sourceFile, targetPath, true);

    }

    private static void CreateTypeCodeList(string codeListId, string lang)
    {
      try
      {
        Console.WriteLine($"Downloading code list {codeListId}");
        var url = Format(RootUrl, codeListId);
        var webRequest = WebRequest.Create(url);

        using var response = webRequest.GetResponse();
        using var content = response.GetResponseStream();
        using var reader = new StreamReader(content ?? throw new InvalidOperationException());
        var xmlContent = reader.ReadToEnd();

        //parse xml
        var doc = XDocument.Parse(xmlContent);
        var formSection = doc.Root;
        var codeListContract = ParseXmlCodeList(formSection, lang);
        var filename = $"{ToLowerFirstChar(codeListId)}.json";

        WriteToFile(codeListContract, filename);
      }
      catch (Exception e)
      {
        Console.WriteLine($"Error while loading {codeListId}: {e.Message}");
      }

    }

    private static void WriteToFile<T>(T contract, string filename)
    {
       var path = Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, "..", "..", "..", "..", "Espd", "typings",
        filename));
      Console.WriteLine("writing file to path: " + path);

      using var file = File.CreateText(path);
      var serializer = new JsonSerializer
      {
        Formatting = Formatting.Indented,
        ContractResolver = new CamelCasePropertyNamesContractResolver(),
        NullValueHandling = NullValueHandling.Ignore
      };
      serializer.Serialize(file, contract);
    }
    
    private static string ToLowerFirstChar(string input)
    {
      var newString = input;
      if (!IsNullOrEmpty(newString) && char.IsUpper(newString[0]))
        newString = $"{char.ToLower(newString[0])}{newString.Substring(1)}";
      return newString;
    }

    private static CodeListContract ParseXmlCodeList(XElement formSection, string lang)
    {
      if (formSection == null)
      {
        throw new Exception("xml data is null");
      }

      var identification = formSection.Element("Identification");
      var simpleCodeList = formSection.Element("SimpleCodeList");

      if (identification == null)
      {
        throw new NullReferenceException("code list identification was null");
      }

      var agency = identification.Element("Agency");
      var codeListContract = new CodeListContract()
      {
        ShortName = identification.Element("ShortName")?.Value,
        LongName = identification.Element("LongName")?.Value,
        AgencyId = agency.Element("Identifier")?.Value,
        Version = identification.Element("Version")?.Value,
        Codes = ParseCodes(simpleCodeList, lang)
      };

      return codeListContract;
    }

    private static List<CodeContract> ParseCodes(XElement codeList, string lang)
    {
      var listOfCodes = new List<CodeContract>();

      foreach (var row in codeList.Elements("Row"))
      {
        var code = new CodeContract()
        {
          Name = row.Elements("Value")
            .FirstOrDefault(r => r.Attribute("ColumnRef")?.Value == lang)?.Element("SimpleValue")?.Value,
          Code = row.Elements("Value")
            .FirstOrDefault(r => r.Attribute("ColumnRef")?.Value == "code")?.Element("SimpleValue")?.Value
        };

        listOfCodes.Add(code);
      }

      return listOfCodes;
    }
  }
}
