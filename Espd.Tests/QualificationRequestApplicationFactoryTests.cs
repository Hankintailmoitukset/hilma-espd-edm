using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq.Expressions;
using Hilma.Espd.EDM.CriterionModels;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Hilma.Espd.Tests
{
  [TestClass]
  public class QualificationRequestApplicationFactoryTests
  {
    [TestMethod]
    public void TestSelfContained()
    { 
      var factory = new QualificationApplicationFactory();
      var uuid = Guid.NewGuid();
      var qar = factory.CreateEspd2_1_0SelfContainedRequest("TEST-123", uuid);
      var validationResults = new List<ValidationResult>();
      var isValid = Validator.TryValidateObject(qar, new ValidationContext(qar), validationResults);
      foreach (var validationResult in validationResults)
      {
        Console.WriteLine(validationResult);
      }
      Assert.IsTrue( isValid, "Given notice does not pass validation");

    }
  }
}