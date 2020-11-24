using System;
using System.IO;
using System.Linq;
using System.Xml.Linq;
using Hilma.Espd.EDM.Importer;
using Hilma.UBL.CommonAggregateComponents;
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
      AssertIdentifier(result.UBLVersionID, "2.2", schemeAgencyId: "OASIS-UBL-TC");
      AssertIdentifier(result.CustomizationID, "urn:www.cenbii.eu:transaction:biitrdm092:ver3.0", schemeAgencyId: "CEN-BII", schemeVersionID: "3.0");
      AssertIdentifier(result.ProfileID, "4.1", schemeAgencyId: "CEN-BII", schemeVersionID: "2.0");
      AssertIdentifier(result.ID, "ESPDREQ-DGPE-70c26f6269", schemeAgencyId: "DGPE");
      Assert.IsNotNull(result.CopyIndicator, "CopyIndicator");
      Assert.IsFalse(result.CopyIndicator.Value,"CopyIndicator");
      AssertIdentifier(result.UUID, "05564993-a96b-49d1-81c6-6c83711b07f6", schemeAgencyId: "EU-COM-GROW", schemeID: "ISO/IEC 9834-8:2008 - 4UUID", schemeVersionID: "2.0");
      AssertIdentifier(result.ContractFolderID, "PP.20170419.1024-9", schemeAgencyId: "DGPE");
      AssertDateType(result.IssueDate, "2019-12-10", "IssueDate");
      AssertTimeType(result.IssueTime, "08:34:44", "IssueTime");
      AssertIdentifier(result.VersionID, "1.0", schemeAgencyId: "EU-COM-GROW", schemeVersionID: "2.0");
      AssertCode(result.ProcedureCode, "AWARD_WO_PUB", "ProcedureType", "1.0", "EU-COM-OP" );
      AssertCode(result.QualificationApplicationTypeCode, "Extended", "QualificationApplicationType", "2.1.1", "EU-COM-GROW");
      Assert.IsNull(result.EconomicOperatorGroupName, nameof(result.EconomicOperatorGroupName));

      var cp = result.ContractingParty;
      Assert.IsNotNull(cp, nameof(ContractingParty));
      var cpParty = cp.Party;
      Assert.IsNotNull(cpParty, nameof(ContractingParty) + nameof(cpParty));
      Assert.AreEqual("www.Procurer.com", cpParty.WebsiteURI?.Value, "CA website");
      AssertIdentifier(cpParty.PartyIdentification?.ID, "AD123456789", schemeAgencyId: "EU-COM-GROW");
      Assert.AreEqual("__ProcurerName", cpParty.PartyName?.Name, "CA name");
      var partyPostalAddress = cpParty.PostalAddress;
      Assert.IsNotNull(partyPostalAddress);
      Assert.AreEqual("__ProcurerStreet", partyPostalAddress?.StreetName);
      Assert.AreEqual("__ProcurerCity", partyPostalAddress?.CityName);
      Assert.AreEqual("12345", partyPostalAddress.PostalZone);
      AssertCode(partyPostalAddress.Country?.IdentificationCode, "AD", "CountryCodeIdentifier", "1.0", "ISO" );
      Assert.AreEqual("__ProcurerContactName", cpParty.Contact?.Name);
      Assert.AreEqual("654321", cpParty.Contact?.Telephone);
      Assert.AreEqual("098765", cpParty.Contact?.Telefax);
      Assert.AreEqual("__ProcurerContact@pr.com", cpParty.Contact?.ElectronicMail);

      var eop = result.EconomicOperatorParty;
      Assert.IsNotNull(eop, nameof(result.EconomicOperatorParty));
      AssertCode( eop.EconomicOperatorRole?.RoleCode, "GM", "EORoleType", "2.1.1", "EU-COM-GROW", listAgencyName: "DG GROW (European Commission)");
      var eoparty = eop.Party;

      Assert.IsNotNull(eoparty, nameof(ContractingParty) + nameof(eoparty));
      Assert.AreEqual("www.Procurer.com", eoparty.WebsiteURI?.Value, "CA website");
      AssertCode(eoparty.IndustryClassificationCode, "SME", "EOIndustryClassificationCode", "2.1.1", "EU-COM-GROW" );
      AssertIdentifier(eoparty.PartyIdentification?.ID, "AD123456789", schemeAgencyId: "EU-COM-GROW");
      Assert.AreEqual("__ProcurerName", cpParty.PartyName?.Name, "CA name");
      var eoPartyPostalAddress = eoparty.PostalAddress;
      Assert.IsNotNull(eoPartyPostalAddress);
      Assert.AreEqual("__ProcurerStreet", eoPartyPostalAddress?.StreetName);
      Assert.AreEqual("__ProcurerCity", eoPartyPostalAddress?.CityName);
      Assert.AreEqual("12345", eoPartyPostalAddress.PostalZone);
      AssertCode(eoPartyPostalAddress.Country?.IdentificationCode, "AD", "CountryCodeIdentifier", "1.0", "ISO");
      Assert.AreEqual("__ProcurerContactName", eoparty.Contact?.Name);
      Assert.AreEqual("654321", eoparty.Contact?.Telephone);
      Assert.AreEqual("098765", eoparty.Contact?.Telefax);
      Assert.AreEqual("__ProcurerContact@pr.com", eoparty.Contact?.ElectronicMail);

      var project = result.ProcurementProject;
      Assert.AreEqual("__ProcurementProcedureTitle", project.Name);
      Assert.AreEqual("__ProcurementProcedureDescription", project.Description);
      Assert.AreEqual("__ProcurementProcedureTitle", project.Name);
      AssertCode( project.ProcurementTypeCode, "COMBINED", "ProjectType", "1.0", "EU-COM-OP");
      Assert.AreEqual("45463100-8", project.MainCommodityClassifications?[0].ItemClassificationCode?.Value, "CPV");

      var lots = result.ProcurementProjectLots;
      Assert.IsNotNull(lots);
      Assert.AreEqual(2,lots.Length);
      AssertIdentifier(lots[0].ID, "Lot1", schemeAgencyId: "EU-COM-GROW", message: "Lot");
      AssertIdentifier(lots[1].ID, "Lot2", schemeAgencyId: "EU-COM-GROW", message: "Lot");


      // Test first criterion
      Assert.IsNotNull(result.TenderingCriteria, "Tendering criteria");
      Assert.AreEqual(67,result.TenderingCriteria.Length, "Tendering criteria count");

      var criterion = result.TenderingCriteria[0];
      AssertEuComGrowId(criterion.ID, "005eb9ed-1347-4ca3-bb29-9bc0db64e1ab");
      AssertCode(criterion.CriterionTypeCode, "CRITERION.EXCLUSION.CONVICTIONS.PARTICIPATION_IN_CRIMINAL_ORGANISATION", "CriteriaTypeCode", "2.1.1", "EU-COM-GROW");
      Assert.AreEqual("Participation in a criminal organisation", criterion.Name);
      Assert.AreEqual("Has the economic operator itself or any person who is a member of its administrative, management or supervisory body or has powers of representation, decision or control therein been the subject of a conviction by final judgment for participation in a criminal organisation, by a conviction rendered at the most five years ago or in which an exclusion period set out directly in the conviction continues to be applicable? As defined in Article 2 of Council Framework Decision 2008/841/JHA of 24 October 2008 on the fight against organised crime (OJ L 300, 11.11.2008, p. 42).", criterion.Description?[0]);

      Assert.IsNotNull( criterion.SubTenderingCriteria, "Sub criteria");
      Assert.AreEqual(1, criterion.SubTenderingCriteria.Length, "sub criteria");

      var subCriterion = criterion.SubTenderingCriteria[0];
      AssertEuComGrowId(subCriterion.ID, "e6b21867-95b5-4549-8180-f4673219b179");
      Assert.AreEqual("[Name of the National Criterion]", subCriterion.Name);
      Assert.AreEqual("[Description of the National Criterion ]", subCriterion.Description?[0]);
      Assert.IsNotNull(subCriterion.TenderingCriterionPropertyGroups);
      Assert.AreEqual(1, subCriterion.TenderingCriterionPropertyGroups.Length);
      var subCriterionGroup = subCriterion.TenderingCriterionPropertyGroups[0];
      AssertPropertyGroup(subCriterionGroup, "8c39b505-8abe-44fa-a3e0-f2d78b9d8224","ON*");

      Assert.IsNotNull(subCriterionGroup.TenderingCriterionProperties);
      Assert.AreEqual(2, subCriterionGroup.TenderingCriterionProperties.Length);
      
      AssertProperty(subCriterionGroup.TenderingCriterionProperties[0],  
        "1d47c84f-f4c7-4e76-bdc6-b7e7ebd4d1a6", 
        "[Additional information; e.g. no evidences online]",
        "CAPTION",
        "NONE");
      AssertProperty(subCriterionGroup.TenderingCriterionProperties[1],
        "7bd04f3f-7be3-483a-9052-0fdb7934790c",
        "Your Answer",
        "QUESTION",
        "INDICATOR");

      Assert.IsNotNull(criterion.Legislations, "Legislations");
      Assert.AreEqual(1, criterion.Legislations.Length, "Legislations");

      var legislation = criterion.Legislations[0];
      AssertEuComGrowId(legislation.ID, "36c9d351-c908-4e81-9022-f2d52db7ffb4");
      Assert.AreEqual("[Legislation title]", legislation.Title);
      Assert.AreEqual("[Legislation description]",legislation.Description);
      Assert.AreEqual("[Article, e.g. Article 2.I.a]", legislation.Article);
      AssertCode(legislation.Languages?[0].LocaleCode, "EN", "LanguageCodeEU", listAgencyName: "EU-COM-GROW", listVersionID: "2.1.1" );
      
      Assert.IsNotNull(criterion.TenderingCriterionPropertyGroups, "Groups");
      Assert.AreEqual(2, criterion.TenderingCriterionPropertyGroups.Length);

      var group = criterion.TenderingCriterionPropertyGroups[0];
      AssertPropertyGroup(group, "7c637c0c-7703-4389-ba52-02997a055bd7", "ON*");
     
      Assert.IsNotNull(group.TenderingCriterionProperties);
      Assert.AreEqual(1, group.TenderingCriterionProperties.Length);

      AssertProperty(group.TenderingCriterionProperties[0],
        "c249d5bb-f2fd-4fb2-b7ce-580b24dbb3a6",
        "Your answer",
        "QUESTION",
        "INDICATOR"
        );

      Assert.IsNotNull(group.SubsidiaryTenderingCriterionPropertyGroups);
      Assert.AreEqual(1, group.SubsidiaryTenderingCriterionPropertyGroups.Length);

      var groupSubGroup = group.SubsidiaryTenderingCriterionPropertyGroups[0];
      AssertPropertyGroup(groupSubGroup, "f5276600-a2b6-4ff6-a90e-b31fe19dae41", "ONTRUE");

      Assert.IsNotNull(groupSubGroup.TenderingCriterionProperties);
      Assert.AreEqual(4, groupSubGroup.TenderingCriterionProperties.Length);

      AssertProperty(groupSubGroup.TenderingCriterionProperties[0],
        "cedcff3e-779e-4b65-9686-4b1125bd4e34",
        "Date of conviction",
        "QUESTION",
        "DATE"
      );
      AssertProperty(groupSubGroup.TenderingCriterionProperties[1],
        "55197300-b699-4fdd-99a6-995d2efa8851",
        "Reason",
        "QUESTION",
        "DESCRIPTION"
      );
      AssertProperty(groupSubGroup.TenderingCriterionProperties[2],
        "674dd860-48a8-4a06-a75b-eee03c0292c4",
        "Who has been convicted",
        "QUESTION",
        "DESCRIPTION"
      );
      AssertProperty(groupSubGroup.TenderingCriterionProperties[3],
        "c4bba136-df2b-47d3-afd0-461b13d0fb06",
        "Length of the period of exclusion",
        "QUESTION",
        "PERIOD"
      );

      Assert.IsNotNull(groupSubGroup.SubsidiaryTenderingCriterionPropertyGroups);
      Assert.AreEqual(1, groupSubGroup.SubsidiaryTenderingCriterionPropertyGroups.Length);
      
      var groupSubSubGroup = groupSubGroup.SubsidiaryTenderingCriterionPropertyGroups[0];
      AssertPropertyGroup(groupSubSubGroup, "5f9f09f7-f701-432c-9fdc-c22c124a74c9","ON*");

      AssertProperty(groupSubSubGroup.TenderingCriterionProperties[0],
        "39257e2e-f689-4c7d-929f-d6bdd9c4f799",
        "Have you taken measures to demonstrate your reliability (Self-Cleaning)?",
        "QUESTION",
        "INDICATOR"
      );

      Assert.IsNotNull(groupSubSubGroup.SubsidiaryTenderingCriterionPropertyGroups);
      Assert.AreEqual(1, groupSubSubGroup.SubsidiaryTenderingCriterionPropertyGroups.Length);

      var groupSubSubSubGroup = groupSubSubGroup.SubsidiaryTenderingCriterionPropertyGroups[0];
      AssertPropertyGroup(groupSubSubSubGroup, "74e6c7b4-757b-4b40-ada6-fad6a997c310", "ONTRUE" );

      AssertProperty(groupSubSubSubGroup.TenderingCriterionProperties[0],
        "acf283ed-86c0-4227-a9f5-deb27a45d3b1",
        "Please describe them",
        "QUESTION",
        "DESCRIPTION"
      );

   

      // Responses

      var responses = result.TenderingCriterionResponses;
      Assert.IsNotNull(responses, "Responses");
      Assert.AreEqual(423, responses.Length );

      var firstResponse = responses[0];

      AssertEuComGrowId(firstResponse.ID, "a5671277-e014-4adb-917b-f9ec7a1f3899", "ISO/IEC 9834-8:2008 - 4UUID" );
      AssertEuComGrowId(firstResponse.ValidatedCriterionPropertyID, "7bd04f3f-7be3-483a-9052-0fdb7934790c");
      Assert.IsNotNull(firstResponse.ResponseValue);
      Assert.IsNull(firstResponse.ApplicablePeriod);
      Assert.IsNull(firstResponse.EvidenceSupplied);
      var responseValue1 = firstResponse.ResponseValue[0]; 
      AssertEuComGrowId(responseValue1.ID, "99f01630-4507-4c19-aff0-15c9152733af", "ISO/IEC 9834-8:2008 - 4UUID");
      Assert.AreEqual(true, responseValue1.ResponseIndicator);

      var anotherResponse = responses[2];

      AssertEuComGrowId(anotherResponse.ID, "76c8bf43-4147-4f57-9695-7b2eab528ad2", "ISO/IEC 9834-8:2008 - 4UUID");
      AssertEuComGrowId(anotherResponse.ValidatedCriterionPropertyID, "cedcff3e-779e-4b65-9686-4b1125bd4e34");
      Assert.IsNotNull(anotherResponse.ResponseValue);
      Assert.IsNull(anotherResponse.ApplicablePeriod);
      Assert.IsNull(anotherResponse.EvidenceSupplied);
      var responseValue2 = anotherResponse.ResponseValue[0];
      AssertEuComGrowId(responseValue2.ID, "c44e8dc8-dd43-4abe-af08-2c75a538b26c", "ISO/IEC 9834-8:2008 - 4UUID");
      Assert.AreEqual("2014-01-01", responseValue2.ResponseDate.ToString());

      // Length of the period of execution
      var lengthResponse = responses.FirstOrDefault(r => r.ID.Value == "c83d87d6-5155-4394-815f-7b94ece90ca8");
      Assert.IsNotNull(lengthResponse);

      AssertEuComGrowId(lengthResponse.ID, "c83d87d6-5155-4394-815f-7b94ece90ca8", "ISO/IEC 9834-8:2008 - 4UUID");
      AssertEuComGrowId(lengthResponse.ValidatedCriterionPropertyID, "b71c4c43-adbb-415e-9312-8bc5dec2749c");
      Assert.IsNotNull(lengthResponse.ApplicablePeriod);
      Assert.IsNull(lengthResponse.ResponseValue);
      Assert.IsNull(lengthResponse.EvidenceSupplied);
      var periodValue = lengthResponse.ApplicablePeriod;
      Assert.AreEqual("2017-01-01", periodValue?.StartDate.ToString("yyyy-MM-dd"));
      Assert.AreEqual("2017-12-12", periodValue?.EndDate.ToString("yyyy-MM-dd"));


      var fraudResponse = responses.FirstOrDefault(r => r.ID.Value == "aae786f7-d3a7-4cd3-a66a-ef39aa49f355");
      Assert.IsNotNull(fraudResponse);

      AssertEuComGrowId(fraudResponse.ID, "aae786f7-d3a7-4cd3-a66a-ef39aa49f355", "ISO/IEC 9834-8:2008 - 4UUID");
      AssertEuComGrowId(fraudResponse.ValidatedCriterionPropertyID, "1c0ba191-7f0d-4ffc-860a-c8ca1d95f1a4");
      Assert.IsNull(fraudResponse.ApplicablePeriod);
      Assert.IsNull(fraudResponse.ResponseValue);
      Assert.IsNotNull(fraudResponse.EvidenceSupplied);
      var evidenceSupplied = fraudResponse.EvidenceSupplied;
      AssertIdentifier(evidenceSupplied.ID, "EVIDENCE-00001", schemeAgencyId:"EU-COM-GROW");


      Assert.IsNotNull(result.Evidences, "Evidence");
      Assert.AreEqual(1,result.Evidences.Length);
      var evidence = result.Evidences[0];

      AssertIdentifier(evidence.ID, "EVIDENCE-00001", "EU-COM-GROW");
      AssertEuComGrowCode(evidence.ConfidentialityLevelCode, "CONFIDENTIAL", "ConfidentialityLevel");

      Assert.IsNotNull(evidence.DocumentReference);
      Assert.AreEqual(1, evidence.DocumentReference.Length);

      var documentReference = evidence.DocumentReference[0];
      Assert.IsNotNull(documentReference);
      AssertIdentifier(documentReference.ID, "SAT-11121233", "EU-COM-GROW");
      AssertIdentifier(documentReference.Attachment?.ExternalReference?.URI, "http:dod.gov.usa/sat/it/soft/prk?id=11121233");
      Assert.AreEqual(documentReference.IssuerParty?.PartyName?.Name, "USA DoD");

    }

    private static void AssertPropertyGroup(TenderingCriterionPropertyGroup groupSubSubSubGroup, string expectedId, string expectedPropertyGroupTypeCode )
    {
      AssertEuComGrowId(groupSubSubSubGroup.ID, expectedId);
      AssertEuComGrowCode(groupSubSubSubGroup.PropertyGroupTypeCode, expectedPropertyGroupTypeCode, "PropertyGroupType");
    }

    private void AssertProperty(TenderingCriterionProperty property, string expectedId, string expectedDescription,
      string expectedTypeCode, string expectedValueTypeCode)
    {
      AssertEuComGrowId(property.ID, expectedId);
      Assert.AreEqual(expectedDescription, property.Description);
      AssertEuComGrowCode(property.TypeCode, expectedTypeCode, "CriterionElementType");
      AssertEuComGrowCode(property.ValueDataTypeCode, expectedValueTypeCode, "ResponseDataType");
    }

    private static void AssertEuComGrowCode(CodeType code, string expectedCode, string expectedListId )
    {
      AssertCode(code, expectedCode, expectedListId, listAgencyID: "EU-COM-GROW", listVersionID: "2.1.1");
    }

    private static void AssertEuComGrowId(IdentifierType id, string expectedId, string expectedSchemeID = "CriteriaTaxonomy")
    {
      AssertIdentifier(id, expectedId, schemeAgencyId: "EU-COM-GROW", expectedSchemeID, "2.1.1");
    }

    private void AssertTimeType(TimeType time, string expectedValue, string message)
    {
      Assert.IsNotNull(time, message);
      Assert.AreEqual(expectedValue, time.ToString(), message);
    }

    private void AssertDateType(DateType date, string expectedValue, string message)
    {
      Assert.IsNotNull(date, message);
      Assert.AreEqual(expectedValue, date.ToString(), message);

    }

    private static void AssertIdentifier(IdentifierType identifier, string value, string schemeAgencyId = null,
      string schemeID = null, string schemeVersionID = null, string schemeAgencyName = null, string schemeName = null,
      string schemeURI = null, string schemeDataURI = null, string message = "identifier")
    {
      Assert.IsNotNull(identifier, message );
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
      Assert.IsNotNull(code, "Code was null");
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
      Assert.ThrowsException<EspdImportException>(() => importer.Parse(xml), "Should fail if invalid xml");
    }

    [TestMethod]
    public void ParseAmountProperty_AllFieldsInitialized()
    {
      var propertyXML = @"<cac:TenderingCriterionProperty xmlns:cac='urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2'
                                                          xmlns:cbc='urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2'>
                                <cbc:ID schemeID='CriteriaTaxonomy' schemeAgencyID='EU-COM-GROW' schemeVersionID='2.1.1'>f39e3914-f740-47ee-8632-60486db20c35</cbc:ID>
                                <cbc:Description>Threshold</cbc:Description>
                                <cbc:TypeCode listID='CriterionElementType' listAgencyID='EU-COM-GROW' listVersionID='2.1.1'>REQUIREMENT</cbc:TypeCode>
                                <cbc:ValueDataTypeCode listID='ResponseDataType' listAgencyID='EU-COM-GROW' listVersionID='2.1.1'>AMOUNT</cbc:ValueDataTypeCode>
                                <cbc:ExpectedAmount currencyID='EUR'>500000</cbc:ExpectedAmount>
                        </cac:TenderingCriterionProperty>";
      var element = XElement.Parse(propertyXML);
      var property = element.ParseProperty();

      AssertProperty(property, "f39e3914-f740-47ee-8632-60486db20c35", "Threshold", "REQUIREMENT", "AMOUNT");
    
      Assert.IsNotNull(property.ExpectedAmount);
      Assert.AreEqual("EUR", property.ExpectedAmount.CurrencyID);
      Assert.AreEqual(500000, property.ExpectedAmount.Value);

    }

    [TestMethod]
    public void ParseCodeProperty_AllFieldsInitialized()
    {
      var propertyXML = @" <cac:TenderingCriterionProperty xmlns:cac='urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2'
                                                          xmlns:cbc='urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2'>
                                        <cbc:ID schemeID='CriteriaTaxonomy' schemeAgencyID='EU-COM-GROW' schemeVersionID='2.1.1'>80ce8733-1080-4a67-9540-736eafb2f04c</cbc:ID>
                                        <cbc:Description>Please indicate the role of the economic operator in the group (leader, responsible for specific tasks...)</cbc:Description>
                                        <cbc:TypeCode listID='CriterionElementType' listAgencyID='EU-COM-GROW' listVersionID='2.1.1'>QUESTION</cbc:TypeCode>
                                        <cbc:ValueDataTypeCode listID='ResponseDataType' listAgencyID='EU-COM-GROW' listVersionID='2.1.1'>CODE</cbc:ValueDataTypeCode>
                          </cac:TenderingCriterionProperty>";
      var element = XElement.Parse(propertyXML);
      var property = element.ParseProperty();

      AssertProperty(
        property, 
        "80ce8733-1080-4a67-9540-736eafb2f04c", 
        "Please indicate the role of the economic operator in the group (leader, responsible for specific tasks...)",
        "QUESTION",
        "CODE"
      );
    }
  }
}
