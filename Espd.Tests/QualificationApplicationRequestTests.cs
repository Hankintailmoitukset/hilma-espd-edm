using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq.Expressions;
using Hilma.Espd.EDM.CriterionModels;
using Hilma.UBL.UnqualifiedDataTypes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Hilma.Espd.Tests
{
  [TestClass]
  public class QualificationApplicationTests
  {
    [TestMethod]
    public void TestFinalize()
    { 
      var factory = new QualificationApplicationFactory();
      var uuid = Guid.NewGuid();
      var qar = factory.CreateEspd2_1_0SelfContainedRequest( new IdentifierType("TEST-123"){ SchemeAgencyID = "TEST" }, new IdentifierType("TEST-REF-111"){ SchemeAgencyID = "TEST" },uuid);

      var firstPropertyId = qar.TenderingCriteria[0].TenderingCriterionPropertyGroups[0].TenderingCriterionProperties[0].Id.Value;

      qar.FinalizeDocument();
      
      var firstPropertyIdAfter = qar.TenderingCriteria[0].TenderingCriterionPropertyGroups[0].TenderingCriterionProperties[0].Id.Value;

      Assert.AreNotEqual( firstPropertyId, firstPropertyIdAfter, "Id, should not be the same");

    }
  }
}