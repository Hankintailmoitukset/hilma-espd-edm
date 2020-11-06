using System;
using System.Collections.Generic;
using System.IO;
using System.Linq.Expressions;
using System.Text;
using System.Xml.Linq;
using Hilma.Espd.EDM.Importer;
using Hilma.UBL.UnqualifiedDataTypes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;

namespace Hilma.Espd.Tests
{
  [TestClass]
  public class ImporterTests
  {
    [TestMethod]
    public void Import2xXml_ResponseIsInitialized()
    {
      using var fileStream = File.OpenText( Path.Combine("Resources", "EXTENDED-ESPDResponse-2.1.1.xml"));
      var xml = XDocument.Load(fileStream);

      var importer = new QualificationApplicationResponseImporter();
      var result = importer.Parse(xml);
      Console.WriteLine(JsonConvert.SerializeObject(result,Formatting.Indented, new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore}));

      Assert.IsNotNull(result, "Response");
      AssertIdentifier(result.UBLVersionID, "2.2", "OASIS-UBL-TC");
      AssertIdentifier(result.CustomizationID, "urn:www.cenbii.eu:transaction:biitrdm092:ver3.0", "CEN-BII", "3.0");
      AssertIdentifier(result.ProfileID, "4.1", "CEN-BII", "2.0");
      AssertCode(result.ProcedureCode, "AWARD_WO_PUB", "ProcedureType", "1.0", "EU-COM-OP" );
      AssertCode(result.QualificationApplicationTypeCode, "Extended", "QualificationApplicationType", "2.1.1", "EU-COM-GROW");
      
    }

    private static void AssertIdentifier(IdentifierType identifier, string value, string schemeAgencyId = null, string schemeVersionID = null, string schemeAgencyName = null, string schemeID = null, string schemeName = null, string schemeURI = null, string schemeDataURI = null)
    {
      Assert.AreEqual(value, identifier.Value);
      Assert.AreEqual(schemeAgencyId, identifier.SchemeAgencyID, nameof(identifier.SchemeAgencyID));
      Assert.AreEqual(schemeAgencyName, identifier.SchemeAgencyName, nameof(identifier.SchemeAgencyName));
      Assert.AreEqual(schemeID, identifier.SchemeID, nameof(identifier.SchemeID));
      Assert.AreEqual(schemeURI, identifier.SchemeURI, nameof(identifier.SchemeURI));
      Assert.AreEqual(schemeDataURI, identifier.SchemeDataURI, nameof(identifier.SchemeDataURI));
      Assert.AreEqual(schemeVersionID, identifier.SchemeVersionID, nameof(identifier.SchemeVersionID));
      Assert.AreEqual(schemeName, identifier.SchemeName, nameof(identifier.SchemeName));

    }

    private static void AssertCode(CodeType code, string value, string listID = null, string listVersionID = null, string listAgencyID = null, string name = null, string listSchemeName = null, string listSchemeURI = null, string languageID = null, string listURI = null, string listAgencyName = null)
    {
      Assert.AreEqual(value, code.Value);
      Assert.AreEqual(name, code.Name, nameof(code.Name));
      Assert.AreEqual(listID, code.ListID, nameof(code.ListID));
      Assert.AreEqual(listVersionID, code.ListVersionID, nameof(code.ListVersionID));
      Assert.AreEqual(listAgencyID, code.ListAgencyID, nameof(code.ListAgencyID));
      Assert.AreEqual(listURI, code.ListURI, nameof(code.ListURI));
      Assert.AreEqual(listSchemeURI, code.ListSchemeURI, nameof(code.ListSchemeURI));
      Assert.AreEqual(languageID, code.LanguageID, nameof(code.LanguageID));
      Assert.AreEqual(listAgencyName, code.ListAgencyName, nameof(code.ListAgencyName));
    }

    [TestMethod]
    public void ImportResponse_InvalidXml_ExceptionIsThrown()
    {
      using var fileStream = File.OpenText(Path.Combine("Resources", "Document.xml"));
      var xml = XDocument.Load(fileStream);
      var importer = new QualificationApplicationResponseImporter();
      Assert.ThrowsException<ArgumentOutOfRangeException>(() => importer.Parse(xml), "Should fail if invalid xml");
    }
  }
}
