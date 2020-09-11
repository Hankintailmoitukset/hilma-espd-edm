using System;
using System.Xml.Linq;
using Hilma.Espd.EDM.CriterionModels.v2_1_1.Examples;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Espd.Validator.Tests
{
  [TestClass]
  public class EspdValidatorTests
  {
    [TestMethod]
    public void ValidateCriteriaTaxonomyExtended_Pass()
    {
      var qar = EspdDocumentHelper.CriteriaTaxonomyExtendedV2_1_1;
      var document = qar.Serialize();
      var validator = new EspdXmlValidator();
      var result = validator.ValidateQualificationApplicationRequest(document);

      foreach (var error in result.Errors)
      {
        Console.WriteLine("Error:" + error);
      }

      Assert.IsTrue( result.IsSuccess, "Validation should succeed" );
      
    }

    [TestMethod]
    public void ValidateInvalidIncompleteRequest_Fail()
    {
      var qar = EspdDocumentHelper.SimpleTest;
      var document = qar.Serialize();
      var validator = new EspdXmlValidator();
      var result = validator.ValidateQualificationApplicationRequest(document);

      foreach (var error in result.Errors)
      {
        Console.WriteLine("Error:" + error);
      }

      Assert.IsFalse(result.IsSuccess, "Validation should fail");

    }

    [TestMethod]
    public void ValidateRandomDocument_Fails()
    {
      var validator = new EspdXmlValidator();
      var document = new XDocument( new XElement("QualificationApplicationRequest", new XElement("id", "jeejee")));
      var result = validator.ValidateQualificationApplicationRequest(document);

      foreach (var error in result.Errors)
      {
        Console.WriteLine("Error:" + error);
      }

      Assert.IsFalse(result.IsSuccess, "Validation should fail");

    }
  }
}
