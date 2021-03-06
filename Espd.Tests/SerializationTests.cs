using System;
using Espd.Test.Common;
using Hilma.Espd.EDM.Serializers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;

namespace Hilma.Espd.Tests
{
  
  [TestClass]
  public class SerializationTests
  {

    [TestInitialize]
    public void Initialize()
    {
    }
    
    [TestMethod]
    public void TestSimpleRequest()
    {
      var request = Create.SimpleQualificationApplicationRequest;
      var result = request.Serialize();

      Assert.IsNotNull(result);
      Console.WriteLine(result);
      Console.WriteLine( JsonConvert.SerializeObject(request, Formatting.Indented, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore, DateFormatHandling = DateFormatHandling.IsoDateFormat }));

    }

    [TestMethod]
    public void TestScAbilitiesStaffSelfContainedRequest()
    {
      var request = Create.ScAbilitiesStaffSelfContainedRequest;
      var result = request.Serialize();

      Assert.IsNotNull(result);
      Console.WriteLine(result);
      Console.WriteLine( JsonConvert.SerializeObject(request, Formatting.Indented, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore, DateFormatHandling = DateFormatHandling.IsoDateFormat }));

    }

    [TestMethod]
    public void TestResponse()
    {
      // Arrange
      var response = Create.QualificationApplicationResponse();

      // Act
      var result = response.Serialize();

      // Assert
      Assert.IsNotNull(result, "Document was null");
      Assert.IsNotNull(result.Root, "Document root was null");
      Console.WriteLine(result);
      Assert.AreEqual(EspdNames.Qarp+"QualificationApplicationResponse", result.Root.Name, "Root element name incorrect");
    }
    

    [TestMethod]
    public void TestRequest()
    {
        var request = Create.CriteriaTaxonomyExtendedV2_1_1;
        var result = request.Serialize();

        Assert.IsNotNull(result);
        Console.WriteLine(result);
        Console.WriteLine(JsonConvert.SerializeObject(request, Formatting.Indented, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore, DateFormatHandling = DateFormatHandling.IsoDateFormat }));

    }
    }
}
