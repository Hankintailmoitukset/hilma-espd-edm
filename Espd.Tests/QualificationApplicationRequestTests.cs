using System;
using System.Linq;
using Hilma.Espd.EDM.CriterionModels;
using Hilma.Espd.EDM.CriterionModels.v2_1_1;
using Hilma.Espd.EDM.CriterionModels.v2_1_1.Identifiers;
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
      var qar = factory.CreateEspd2_1_1ExtendedRequest(new IdentifierType("TEST-123") {SchemeAgencyID = "TEST"},
        new IdentifierType("TEST-REF-111") {SchemeAgencyID = "TEST"}, uuid, new string[0], false );
      var suitabilityCriterion = new CriterionSpecification().SelectionCriteria.Suitability.First();
      qar.TenderingCriteria = qar.TenderingCriteria.Union(new[] {suitabilityCriterion}).ToArray();
      var firstPropertyId = qar.TenderingCriteria[0].TenderingCriterionPropertyGroups[0].TenderingCriterionProperties[0]
        .ID.Value;

      qar.FinalizeDocument();

      var firstPropertyIdAfter = qar.TenderingCriteria[0].TenderingCriterionPropertyGroups[0]
        .TenderingCriterionProperties[0].ID.Value;
      var assertedCriteria = qar.TenderingCriteria.Last();
      Assert.AreEqual(suitabilityCriterion.Name, assertedCriteria.Name);
      Assert.AreNotEqual(firstPropertyId, firstPropertyIdAfter, "Id, should not be the same");

      var lotIds = assertedCriteria.DescendantProperties()
          .Where(p => p.TypeCode.Equals(CriterionElementType.Requirement) && Equals(p.ValueDataTypeCode, ResponseDataTypeCode.LotIdentifier));

      Assert.IsTrue( lotIds.All( id => id.ExpectedID == "0"), "Lot id:s should have been set to \"0\"");
    }

    [TestMethod]
    public void TestLotFinalize()
    {
      var factory = new QualificationApplicationFactory();
      var uuid = Guid.NewGuid();
      var lotIds = new []{ "Lot 1", "Lot 2"};
      var qar = factory.CreateEspd2_1_1ExtendedRequest(
        new IdentifierType("TEST-123") {SchemeAgencyID = "TEST"},
        new IdentifierType("TEST-REF-111") {SchemeAgencyID = "TEST"},
        uuid,
        lotIds, false);
 
      var suitabilityCriterion = new CriterionSpecification().SelectionCriteria.Suitability.First();
      qar.TenderingCriteria = qar.TenderingCriteria = new[] {suitabilityCriterion};

      qar.FinalizeDocument(lotIds);
      
      var assertedCriteria = qar.TenderingCriteria.Last();
      Assert.AreEqual(suitabilityCriterion.Name, assertedCriteria.Name);

      var lotProperties =
        assertedCriteria.DescendantProperties()
          .Where(p => p.TypeCode.Equals(CriterionElementType.Requirement) && Equals(p.ValueDataTypeCode, ResponseDataTypeCode.LotIdentifier)).ToArray();
      Assert.AreEqual(2, lotProperties.Length, "Should have two lot properties");
      Assert.AreEqual("Lot 1", lotProperties[0].ExpectedID.Value);
      Assert.AreEqual("Lot 2", lotProperties[1].ExpectedID.Value);
    }


    [TestMethod]
    public void TestLotFinalize_QuestionLots_NoValuesSet()
    {
      var factory = new QualificationApplicationFactory();
      var uuid = Guid.NewGuid();
      var lotIds = new[] {"Lot 1", "Lot 2"};
      var qar = factory.CreateEspd2_1_1ExtendedRequest(
        new IdentifierType("TEST-123") {SchemeAgencyID = "TEST"},
        new IdentifierType("TEST-REF-111") {SchemeAgencyID = "TEST"},
        uuid,
        lotIds, false);

      var referenceCriterion = new CriterionSpecification().SelectionCriteria.References.First();
      qar.TenderingCriteria = qar.TenderingCriteria = new[] {referenceCriterion};

      qar.FinalizeDocument(lotIds);

      var assertedCriteria = qar.TenderingCriteria.Last();
      Assert.AreEqual(referenceCriterion.Name, assertedCriteria.Name);

      var lotQuestionProperties =
        assertedCriteria.DescendantProperties()
          .Where(p => p.TypeCode.Equals(CriterionElementType.Question) &&
                      Equals(p.ValueDataTypeCode, ResponseDataTypeCode.LotIdentifier)).ToArray();
      Assert.AreEqual(1, lotQuestionProperties.Length, "Should have one question lot property");
      Assert.IsNull(lotQuestionProperties[0].ExpectedID, "lotQuestionProperties[0].ExpectedID == null");
    }

    [TestMethod]
    public void TestLotFinalize_SingleLotSelected()
    {
      var factory = new QualificationApplicationFactory();
      var uuid = Guid.NewGuid();
      var qar = factory.CreateEspd2_1_1ExtendedRequest(
        new IdentifierType("TEST-123") { SchemeAgencyID = "TEST" },
        new IdentifierType("TEST-REF-111") { SchemeAgencyID = "TEST" },
        uuid,
        new[] { "Lot 1", "Lot 2" }, false);

      var suitabilityCriterion = new CriterionSpecification().SelectionCriteria.Suitability.First();
      qar.TenderingCriteria = qar.TenderingCriteria.Union(new[] { suitabilityCriterion }).ToArray();

      qar.FinalizeDocument( new []{ "Lot 1"});

      var assertedCriteria = qar.TenderingCriteria.Last();
      Assert.AreEqual(suitabilityCriterion.Name, assertedCriteria.Name);

      var lotProperties =
        assertedCriteria.DescendantProperties()
          .Where(p => p.TypeCode.Equals(CriterionElementType.Requirement) && Equals(p.ValueDataTypeCode, ResponseDataTypeCode.LotIdentifier)).ToArray();
      Assert.AreEqual(1, lotProperties.Length, "Should have one lot property");
      Assert.AreEqual("Lot 1", lotProperties[0].ExpectedID.Value);
    }

    [TestMethod]
    public void TestThresholdFinalize()
    {
      var factory = new QualificationApplicationFactory();
      var uuid = Guid.NewGuid();
      var qar = factory.CreateEspd2_1_1ExtendedRequest(
        new IdentifierType("TEST-123") { SchemeAgencyID = "TEST" },
        new IdentifierType("TEST-REF-111") { SchemeAgencyID = "TEST" },
        uuid,
        new[] { "0" }, false);

      var contributionsCriterion = new CriterionSpecification().ExclusionGrounds.Contributions.First();
      qar.TenderingCriteria = qar.TenderingCriteria.Union(new[] { contributionsCriterion }).ToArray();

      qar.FinalizeDocument( new []{ "0"});

      var assertedCriteria = qar.TenderingCriteria.Last();
      Assert.AreEqual(contributionsCriterion.Name, assertedCriteria.Name);
      var thresholdGroup = assertedCriteria.DescendantGroups()
          .Where( g => g.ID.Value == QualificationApplicationOperations.ContributionThresholdGroupId.ToString()).First();
      var thresholdProperty = thresholdGroup.TenderingCriterionProperties[0];
      var thresholdDescription = thresholdGroup.TenderingCriterionProperties[1];
      Assert.IsNotNull(thresholdProperty, "thresholdProperty != null");
      Assert.IsNotNull(thresholdProperty.ExpectedAmount, "thresholdProperty.ExpectedAmount != null");
      Assert.AreEqual(0, thresholdProperty.ExpectedAmount.Value, "Expected 0 amount");
      Assert.AreEqual(0, thresholdProperty.ExpectedAmount.Value, "Expected 0 amount");
      Assert.IsNotNull(thresholdDescription, "thresholdDescription != null");
      Assert.IsNotNull(thresholdDescription.ExpectedDescription, "thresholdDescription.ExpectedDescription != null");
      Assert.AreEqual(string.Empty, thresholdDescription.ExpectedDescription, "Description");
    }
  }
}