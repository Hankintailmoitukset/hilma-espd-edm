using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Xml.Linq;

namespace CodelistParser
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Downloading exml");

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
            Codelist financialRatioTypes = ParseFinancialRatioTypes(formSection, lang);

            string path = Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, "..","..","..","..","Espd","typings", "financialRatioTypes.json"));

            // Write to file
            using (var file = File.CreateText(path))
            {
                var serializer = new JsonSerializer
                {
                    Formatting = Formatting.Indented
                };
                serializer.Serialize(file, financialRatioTypes);
            }


        }

        private static Codelist ParseFinancialRatioTypes(XElement formSection, string lang)
        {
            if (formSection == null)
            {
                return new Codelist();
            }
            try
            {
                var identification = formSection.Element("Identification");
                var simpleCodeList = formSection.Element("SimpleCodeList");

                Codelist codelist = new Codelist()
                {
                    ShortName = identification.Element("ShortName").Value,
                    LongName = identification.Element("LongName").Value,
                    Codes = ParseCodes(simpleCodeList, lang)
                };

                return codelist;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private static List<Codes> ParseCodes(XElement codelist, string lang)
        {
            var listOfCodes = new List<Codes>();

            foreach (var row in codelist.Elements("Row"))
            {
                var code = new Codes()
                {
                    Name = row.Elements("Value").Where(r => r.Attribute("ColumnRef")?.Value == "name-fin")
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
