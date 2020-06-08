using System;
using System.Linq;
using Hilma.Espd.EDM.CriterionModels;
using Hilma.Espd.EDM.CriterionModels.v2_1_0;
using Hilma.Espd.EDM.CriterionModels.v2_1_0.Identifiers;
using Hilma.Espd.Tests.Extensions;
using Hilma.UBL.CommonAggregateComponents;
using Hilma.UBL.UnqualifiedDataTypes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Hilma.Espd.Tests
{
  [TestClass]
  public class QualificationApplicationOperationsTests
  {
    [TestMethod]
    public void TestFinalize()
    {
      var factory = new QualificationApplicationFactory();
      var uuid = Guid.NewGuid();
      var qar = factory.CreateEspd2_1_0SelfContainedRequest(new IdentifierType("TEST-123") {SchemeAgencyID = "TEST"},
        new IdentifierType("TEST-REF-111") {SchemeAgencyID = "TEST"}, uuid, new string[0] );
      var suitabilityCriterion = new CriterionSpecification().SelectionCriteria.Suitability.First();
      qar.TenderingCriteria = qar.TenderingCriteria.Union(new[] {suitabilityCriterion}).ToArray();
      var firstPropertyId = qar.TenderingCriteria[0].TenderingCriterionPropertyGroups[0].TenderingCriterionProperties[0]
        .Id.Value;

      qar.FinalizeDocument();

      var firstPropertyIdAfter = qar.TenderingCriteria[0].TenderingCriterionPropertyGroups[0]
        .TenderingCriterionProperties[0].Id.Value;

      Assert.AreNotEqual(firstPropertyId, firstPropertyIdAfter, "Id, should not be the same");

      Assert.IsFalse(
        suitabilityCriterion.DescendantProperties()
          .Any(p => Equals(p.ValueDataTypeCode, ResponseDataTypeCode.LotIdentifier)), "Lots should have been removed");
    }

    [TestMethod]
    public void TestLotFinalize()
    {
      var factory = new QualificationApplicationFactory();
      var uuid = Guid.NewGuid();
      var lotIds = new []{ "Lot 1", "Lot 2"};
      var qar = factory.CreateEspd2_1_0SelfContainedRequest(
        new IdentifierType("TEST-123") {SchemeAgencyID = "TEST"},
        new IdentifierType("TEST-REF-111") {SchemeAgencyID = "TEST"},
        uuid,
        lotIds);
 
      var suitabilityCriterion = new CriterionSpecification().SelectionCriteria.Suitability.First();
      qar.TenderingCriteria = qar.TenderingCriteria.Union(new[] {suitabilityCriterion}).ToArray();

      qar.FinalizeDocument(lotIds);

      var lotProperties =
        suitabilityCriterion.DescendantProperties()
          .Where(p => Equals(p.ValueDataTypeCode, ResponseDataTypeCode.LotIdentifier)).ToArray();
      Assert.AreEqual(2, lotProperties.Length, "Should have two lot properties");
      Assert.AreEqual("Lot 1", lotProperties[0].ExpectedID.Value);
      Assert.AreEqual("Lot 2", lotProperties[1].ExpectedID.Value);
    }

    [TestMethod]
    public void TestLotFinalize_SingleLotSelected()
    {
      var factory = new QualificationApplicationFactory();
      var uuid = Guid.NewGuid();
      var qar = factory.CreateEspd2_1_0SelfContainedRequest(
        new IdentifierType("TEST-123") { SchemeAgencyID = "TEST" },
        new IdentifierType("TEST-REF-111") { SchemeAgencyID = "TEST" },
        uuid,
        new[] { "Lot 1", "Lot 2" });

      var suitabilityCriterion = new CriterionSpecification().SelectionCriteria.Suitability.First();
      qar.TenderingCriteria = qar.TenderingCriteria.Union(new[] { suitabilityCriterion }).ToArray();

      qar.FinalizeDocument( new []{ "Lot 1"});

      var lotProperties =
        suitabilityCriterion.DescendantProperties()
          .Where(p => Equals(p.ValueDataTypeCode, ResponseDataTypeCode.LotIdentifier)).ToArray();
      Assert.AreEqual(1, lotProperties.Length, "Should have one lot property");
      Assert.AreEqual("Lot 1", lotProperties[0].ExpectedID.Value);
    }
  }
}