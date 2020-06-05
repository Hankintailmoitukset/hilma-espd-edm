using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Linq.Expressions;
using Hilma.Espd.EDM.CriterionModels;
using Hilma.Espd.EDM.CriterionModels.v2_1_0;
using Hilma.Espd.EDM.CriterionModels.v2_1_0.Identifiers;
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
      var qar = factory.CreateEspd2_1_0SelfContainedRequest(new IdentifierType("TEST-123") { SchemeAgencyID = "TEST" }, new IdentifierType("TEST-REF-111") { SchemeAgencyID = "TEST" }, uuid);
      qar.ProcurementProjectLots = new[] {new ProcurementProjectLot() {ID = new IdentifierType("0")}};
      var suitabilityCriterion = new CriterionSpecification().SelectionCriteria.Suitability.First();
      qar.TenderingCriteria = qar.TenderingCriteria.Union(new[] {suitabilityCriterion}).ToArray();
      var firstPropertyId = qar.TenderingCriteria[0].TenderingCriterionPropertyGroups[0].TenderingCriterionProperties[0].Id.Value;

      qar.FinalizeDocument();

      var firstPropertyIdAfter = qar.TenderingCriteria[0].TenderingCriterionPropertyGroups[0].TenderingCriterionProperties[0].Id.Value;

      Assert.AreNotEqual(firstPropertyId, firstPropertyIdAfter, "Id, should not be the same");

      Assert.IsFalse(suitabilityCriterion.DescendantProperties().Any( p => Equals(p.ValueDataTypeCode, ResponseDataTypeCode.LotIdentifier )), "Lots should have been removed" );
    }
    
    [TestMethod]
    public void TestLotFinalize()
    {
      var factory = new QualificationApplicationFactory();
      var uuid = Guid.NewGuid();
      var qar = factory.CreateEspd2_1_0SelfContainedRequest(new IdentifierType("TEST-123") { SchemeAgencyID = "TEST" }, new IdentifierType("TEST-REF-111") { SchemeAgencyID = "TEST" }, uuid);
      qar.ProcurementProjectLots = new[]
      {
        new ProcurementProjectLot() { ID = new IdentifierType("Lot 1") },
        new ProcurementProjectLot() { ID = new IdentifierType("Lot 2") }
      };
      var suitabilityCriterion = new CriterionSpecification().SelectionCriteria.Suitability.First();
      qar.TenderingCriteria = qar.TenderingCriteria.Union(new[] { suitabilityCriterion }).ToArray();
      
      qar.FinalizeDocument();
      var lotProperties =
        suitabilityCriterion.DescendantProperties().Where(p => Equals(p.ValueDataTypeCode, ResponseDataTypeCode.LotIdentifier)).ToArray();
      Assert.AreEqual(2, lotProperties.Length, "Should have two lot properties");
      Assert.AreEqual("Lot 1", lotProperties[0].ExpectedID.Value);
      Assert.AreEqual("Lot 2", lotProperties[1].ExpectedID.Value);

    }
  }
}