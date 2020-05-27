using Hilma.Espd.EDM.CriterionModels.v2_1_0;
using Hilma.Espd.EDM.Localisation;
using Hilma.UBL.CommonAggregateComponents;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Xml.Linq;
using Hilma.Espd.EDM.CodeLists;
using Newtonsoft.Json.Serialization;

namespace ResourceExporter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Downloading xml");

            //TODO READ URLS FROM CONFIG
            var financialRatioTypeUrl = "https://raw.githubusercontent.com/ESPD/ESPD-EDM/2.1.0/docs/src/main/asciidoc/dist/cl/gc/FinancialRatioType-CodeList.gc";
            var lang = "name-eng";

            var webRequest = WebRequest.Create(@financialRatioTypeUrl);
            var xmlContent = string.Empty;

            using (var response = webRequest.GetResponse())
            using (var content = response.GetResponseStream())
            using (var reader = new StreamReader(content))
            {
                xmlContent = reader.ReadToEnd();
            }

            //parse xml
            var doc = XDocument.Parse(xmlContent);
            XElement formSection = doc.Root;
            CodeListContract financialRatioTypes = ParseFinancialRatioTypes(formSection, lang);
            WriteToFile(financialRatioTypes, "financialRatioTypes.json");

            //get tenderincriterion
            var criterionSpecification = new CriterionSpecification().AllCriteria.ToArray();
            WriteToFile(criterionSpecification, "criterionSpecification.json");

            //copy transaltion
            string sourceFile = Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, "..", "..", "..", "..", "Espd", "Localisation","translations.default.json"));
            string targetPath = Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, "..", "..", "..", "..", "Espd", "typings", "translations.default.json"));
            Console.WriteLine("writing file to path: " + targetPath);
            System.IO.File.Copy(sourceFile, targetPath, true);

        }

        private static void WriteToFile(CodeListContract financialRatioTypes, string filename)
        {
            string path = Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, "..", "..", "..", "..", "Espd", "typings", filename));
            Console.WriteLine("writing file to path: " + path);

            using var file = File.CreateText(path);
            var serializer = new JsonSerializer
            {
              Formatting = Formatting.Indented, 
              ContractResolver = new CamelCasePropertyNamesContractResolver(),
              NullValueHandling = NullValueHandling.Ignore
            };
            serializer.Serialize(file, financialRatioTypes);
        }

        private static void WriteToFile(IEnumerable<TenderingCriterion> criterionSpecification, string filename)
        {
            string path = Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, "..", "..", "..", "..", "Espd", "typings", filename));
            Console.WriteLine("writing file to path: " + path);

            using var file = File.CreateText(path);
            var serializer = new JsonSerializer
            {
              Formatting = Formatting.Indented,
              ContractResolver = new CamelCasePropertyNamesContractResolver(),
              NullValueHandling = NullValueHandling.Ignore

            };
            serializer.Serialize(file, criterionSpecification);
        }

        private static CodeListContract ParseFinancialRatioTypes(XElement formSection, string lang)
        {
            if (formSection == null)
            {
                throw new Exception("xml data is null");
            }
            try
            {
                var identification = formSection.Element("Identification");
                var simpleCodeList = formSection.Element("SimpleCodeList");

                CodeListContract codeListContract = new CodeListContract()
                {
                    ShortName = identification.Element("ShortName").Value,
                    LongName = identification.Element("LongName").Value,
                    Codes = ParseCodes(simpleCodeList, lang)
                };

                return codeListContract;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private static List<CodeContract> ParseCodes(XElement codelist, string lang)
        {
            var listOfCodes = new List<CodeContract>();

            foreach (var row in codelist.Elements("Row"))
            {
                var code = new CodeContract()
                {
                    Name = row.Elements("Value").Where(r => r.Attribute("ColumnRef")?.Value == lang)
                                            .FirstOrDefault().Element("SimpleValue").Value,
                    Code = row.Elements("Value").Where(r => r.Attribute("ColumnRef")?.Value == "code")
                                            .FirstOrDefault().Element("SimpleValue").Value
                };

                listOfCodes.Add(code);
            }

            return listOfCodes;
        }
    }
}
