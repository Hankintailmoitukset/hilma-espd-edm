using System;
using Espd.Serializers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using UBL.CommonAggregateComponents;
using UBL.UnqualifiedDataTypes;

namespace Espd.Tests
{


  [TestClass]
  public class EspdSerializerTest
  {
    [TestMethod]
    public void TestSimpleRequest()
    {
      var request = EspdDocumentHelpper.SimpleTest;
      var result = request.Serialize();

      Assert.IsNotNull(result);
      Console.WriteLine(result);
      Console.WriteLine( JsonConvert.SerializeObject(request, Formatting.Indented, new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, DateFormatHandling = DateFormatHandling.IsoDateFormat }));

    }

    [TestMethod]
    public void TestSCAbilitiesStaffSelfContainedRequest()
    {
      var request = EspdDocumentHelpper.SCAbilitiesStaffSelfContainedRequest;
      var result = request.Serialize();

      Assert.IsNotNull(result);
      Console.WriteLine(result);
      Console.WriteLine( JsonConvert.SerializeObject(request, Formatting.Indented, new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, DateFormatHandling = DateFormatHandling.IsoDateFormat }));

    }
  }
}
