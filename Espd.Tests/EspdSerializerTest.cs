using System;
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
    public void TestRequest()
    {
        var request = EspdDocumentHelper_v2_1_1.ScAbilitiesStaffSelfContainedRequest;
        var result = request.Serialize();

        Assert.IsNotNull(result);
        Console.WriteLine(result);
        Console.WriteLine(JsonConvert.SerializeObject(request, Formatting.Indented, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore, DateFormatHandling = DateFormatHandling.IsoDateFormat }));

    }
    }
}
