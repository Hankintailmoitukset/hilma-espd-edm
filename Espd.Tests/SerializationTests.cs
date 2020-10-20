using System;
using Hilma.Espd.EDM.CriterionModels;
using Hilma.Espd.EDM.Serializers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using Hilma.Espd.EDM.CriterionModels.v2_1_1.Examples;
using Hilma.Espd.EDM.CriterionModels.v2_1_1.Identifiers;
using Hilma.UBL.CommonAggregateComponents;
using Hilma.UBL.UnqualifiedDataTypes;

namespace Hilma.Espd.Tests
{
  
  [TestClass]
  public class SerializationTests
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
    public void TestResponse()
    {
      // Arrange
      var request = EspdDocumentHelper.ScAbilitiesStaffSelfContainedRequest;
      var factory = new QualificationApplicationFactory();

      var response = factory.CreateEspd2_1_1ExtendedResponse(request, new EconomicOperatorParty(), 
        new EuComGrowId(Guid.NewGuid()),
        new IdentifierType("TEST-REF-111") {SchemeAgencyID = "TEST"}, 
        Guid.NewGuid(), 
        new string[] { }, true);

      // Act
      var result = response.Serialize();

      // Assert
      Assert.IsNotNull(result, "Document was null");
      Console.WriteLine(result);
      Assert.AreEqual(EspdNames.Qarp+"QualificationApplicationResponse", result.Root.Name, "Root element name incorrect");
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
