using System;
using Hilma.Espd.EDM.Localisation;
using Hilma.Espd.EDM.Serializers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;

namespace Hilma.Espd.Tests
{


  [TestClass]
  public class TranslationTest
    {
    [TestMethod]
    public void TestTranslationHelper()
    {
            //returns defult translations
            var translationDictionary = LocalisationHelper.ParseLocalisation();
            Assert.IsNotNull(translationDictionary);

    }
    [TestMethod]
    public void TestTranslationHelperWithValue()
    {
            var json = "{\"key1\":\"value1\",\"key2\":\"value2\",\"key3\":\"value3\",}";

            //returns given translation
            var translationDictionary = LocalisationHelper.ParseLocalisation(json);

            Assert.IsNotNull(translationDictionary);

    }
  }
}
