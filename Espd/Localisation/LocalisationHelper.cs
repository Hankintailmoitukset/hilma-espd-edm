using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace Hilma.Espd.EDM.Localisation
{
    public class LocalisationHelper
    {

        public static Dictionary<string, string> ParseDefaultLocalisation()
        {
            string filePath = @"Localisation/translations.default.json";
            var jsonString = File.ReadAllText(filePath);
            var localisationDictionary = JsonConvert.DeserializeObject<Dictionary<string, string>>(jsonString);
            return localisationDictionary;
        }

        public static Dictionary<string, string> ParseLocalisation(string jsonData)
        {
          var localisationDictionary = JsonConvert.DeserializeObject<Dictionary<string, string>>(jsonData);
          return localisationDictionary;
        }

    }
}
