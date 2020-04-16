using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace Hilma.Espd.EDM.Localisation
{
    public class LocalisationHelper
    {

        public static Dictionary<string, string> ParseDefaultLocalisation()
        {
            string filePath = @"Localisation/translations.default.json";
            try
            {
                var jsonString = File.ReadAllText(filePath);
                var localisationDictionary = JsonConvert.DeserializeObject<Dictionary<string, string>>(jsonString);
                return localisationDictionary;
            }
            catch (Exception e)
            {
                throw;
            }
            
        }

        public static Dictionary<string, string> ParseLocalisation(string jsonData)
        {
            try
            {
                var localisationDictionary = JsonConvert.DeserializeObject<Dictionary<string, string>>(jsonData);
                return localisationDictionary;
            }
            catch (Exception e)
            {
                throw;
            }
        }

    }
}
