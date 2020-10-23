using System;
using System.IO;
using System.Xml.Linq;
using Espd.Test.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Espd.Validator.Tests
{
  [TestClass]
  public class EspdValidatorTests
  {
    [TestMethod]
    public void ValidateCriteriaTaxonomyExtended_Pass()
    {
      var qar = Create.CriteriaTaxonomyExtendedV2_1_1;
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
    public void ValidateCompleteResponse_Pass()
    {
      // Arrange
      var response = Create.QualificationApplicationResponse();

      // Act
      var document = response.Serialize();
      var validator = new EspdXmlValidator();
      var result = validator.ValidateQualificationApplicationResponse(document);

     
      // Assert
      foreach (var error in result.Errors)
      {
        Console.WriteLine("Error:" + error);
      }
      Console.WriteLine(document);
      Assert.IsTrue(result.IsSuccess, "Validation should fail");
    }

    [TestMethod]
    public void ExportCompleteResponse_Pass()
    {
      // Arrange
      var response = Create.QualificationApplicationResponse();

      // Act
      var document = response.Serialize();
      var validator = new EspdXmlValidator();
      var result = validator.ValidateQualificationApplicationResponse(document);
      var filePath = Path.Combine(Path.GetTempPath(), $"EspdResponse{DateTime.Now:yyyy-MM-dd}.xml");
      Console.WriteLine("Write file to: " + filePath);
      document.Save(filePath);

      // Assert
      foreach (var error in result.Errors)
      {
        Console.WriteLine("Error:" + error);
      }
      Assert.IsTrue(result.IsSuccess, "Validation should fail");

    }


    [TestMethod]
    public void ValidateInvalidIncompleteRequest_Fail()
    {
      var qar = Create.SimpleQualificationApplicationRequest;
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
