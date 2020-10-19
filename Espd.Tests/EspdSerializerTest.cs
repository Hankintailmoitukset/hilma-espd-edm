using System;
using Hilma.Espd.EDM.CriterionModels;
using Hilma.Espd.EDM.Serializers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using Hilma.Espd.EDM.CriterionModels.v2_1_1.Examples;

namespace Hilma.Espd.Tests
{
  
  [TestClass]
  public class EspdSerializerTest
  {
    [TestMethod]
    public void TestSimpleRequest()
    {
      var request = EspdDocumentHelper.SimpleTest;
      var result = request.Serialize();

      Assert.IsNotNull(result);
      Console.WriteLine(result);
      Console.WriteLine( JsonConvert.SerializeObject(request, Formatting.Indented, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore, DateFormatHandling = DateFormatHandling.IsoDateFormat }));

    }

    [TestMethod]
    public void TestScAbilitiesStaffSelfContainedRequest()
    {
      var request = EspdDocumentHelper.ScAbilitiesStaffSelfContainedRequest;
      var result = request.Serialize();

      Assert.IsNotNull(result);
      Console.WriteLine(result);
      Console.WriteLine( JsonConvert.SerializeObject(request, Formatting.Indented, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore, DateFormatHandling = DateFormatHandling.IsoDateFormat }));

    }

    [TestMethod]
    public void TesSimpleResponseScAbilitiesStaffSelfContainedRequest()
    {
      var request = EspdDocumentHelper.ScAbilitiesStaffSelfContainedRequest;
      var response = new QualificationApplicationResponse()
      {
        UBLVersionID = request.UBLVersionID,
        
      };

      var result = response.Serialize();

      Assert.IsNotNull(result);
      Console.WriteLine(result);
      //Console.WriteLine(JsonConvert.SerializeObject(request, Formatting.Indented, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore, DateFormatHandling = DateFormatHandling.IsoDateFormat }));

    }

    [TestMethod]
    public void TestRequest()
    {
        var request = EspdDocumentHelper.CriteriaTaxonomyExtendedV2_1_1;
        var result = request.Serialize();

        Assert.IsNotNull(result);
        Console.WriteLine(result);
        Console.WriteLine(JsonConvert.SerializeObject(request, Formatting.Indented, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore, DateFormatHandling = DateFormatHandling.IsoDateFormat }));

    }
    }
}
