using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Xml.Linq;
using Hilma.Espd.EDM.CriterionModels;
using Hilma.UBL.CommonAggregateComponents;
using Hilma.UBL.UnqualifiedDataTypes;
using UBL.Enums;

namespace Hilma.Espd.EDM.Importer
{
  public static class CommonAggregateComponentExtensions
  {
    public static QualificationApplicationResponse ParseQualificationApplicationResponse(this XElement root)
    {
      var response = new QualificationApplicationResponse()
      {
        UBLVersionID = root.Cbc("UBLVersionID").ParseIdentifier(),
        CustomizationID = root.Cbc("CustomizationID").ParseIdentifier(),
        ProfileID = root.Cbc("ProfileID").ParseIdentifier(),
        ID = root.Cbc("ID").ParseIdentifier(),
        CopyIndicator = root.Cbc("CopyIndicator").ParseBool(),
        UUID = root.Cbc("UUID").ParseIdentifier(),
        ContractFolderID = root.Cbc("ContractFolderID").ParseIdentifier(),
        IssueDate = root.Cbc("IssueDate").ParseDate(),
        IssueTime = root.Cbc("IssueTime").ParseTime(),
        ProcedureCode = root.Cbc("ProcedureCode").ParseCode(),
        QualificationApplicationTypeCode = root.Cbc("QualificationApplicationTypeCode").ParseCode(),
        EconomicOperatorGroupName = root.Cbc("EconomicOperatorGroupName").ParseCode(),
        VersionID = root.Cbc("VersionID").ParseIdentifier(),
        ContractingParty = root.Cac("ContractingParty").ParseContractingParty(),
        EconomicOperatorParty = root.Cac("EconomicOperatorParty").ParseEconomicOperatorParty(),
        ProcurementProject = root.Cac("ProcurementProject").ParseProcurementProject(),
        ProcurementProjectLots = root.Cacs("ProcurementProjectLot").Select(ParseProcurementProjectLot).ToArray(),
        TenderingCriteria = root.Cacs("TenderingCriterion").Select(ParseTenderingCriterion).ToArray(),
        TenderingCriterionResponses = root.Cacs("TenderingCriterionResponse").Select(ParseTenderingCriterionResponse).ToArray(),
        Evidences = root.Cacs("Evidence").Select( ParseEvidence).ToArray()

      };
      return response;
    }

    private static TenderingCriterionResponse ParseTenderingCriterionResponse(XElement element)
    {
      if (element == null)
      {
        return null;

      }

      var response =  new TenderingCriterionResponse()
        {
          ID = element.Cbc("ID").ParseIdentifier(),
          ValidatedCriterionPropertyID = element.Cbc("ValidatedCriterionPropertyID").ParseIdentifier(),
          ConfidentialityLevelCode = element.Cbc("ConfidentialityLevelCode").ParseCode()
        };

      var responseValues = element.Cacs("ResponseValue").ToList();

      if (responseValues.Any())
      {
        response.ResponseValue = responseValues.Select( ParseResponseValue ).ToArray();
      }

      var applicablePeriod = element.Cac("ApplicablePeriod");
      if (applicablePeriod != null)
      {
        response.ApplicablePeriod = applicablePeriod.ParsePeriod();
      }

      var evidenceSupplied = element.Cac("EvidenceSupplied");
      if (evidenceSupplied != null)
      {
        response.EvidenceSupplied = new EvidenceSupplied() {ID = evidenceSupplied.Cbc("ID").ParseIdentifier()};
      }

      return response;
    }

    private static ResponseValue ParseResponseValue(XElement element)
    {
      return element != null ? new ResponseValue()
      {
         ID = element.Cbc("ID").ParseIdentifier(),
         Description = element.Cbcs("Description").ParseDescription(),
         ResponseIndicator = element.Cbc("ResponseIndicator").ParseBool().GetValueOrDefault(),
         ResponseDate = element.Cbc("ResponseDate").ParseDate(),
         ResponseQuantity = element.Cbc("ResponseQuantity").ParseQuantity(),
         ResponseMeasure = element.Cbc("ResponseQuantity").ParseMeasure(),
         ResponseCode = element.Cbc("ResponseCode").ParseCode(),
         ResponseAmount = element.Cbc("ResponseAmount").ParseAmount(),
         ResponseID = element.Cbc("ResponseAmount").ParseIdentifier(),
         ResponseNumeric = element.Cbc("ResponseNumeric").ParseDecimal(),
         ResponseTime = element.Cbc("ResponseTime").ParseTime(),
         ResponseURI = element.Cbc("ResponseURI").ParseIdentifier()
         

      } : null;
    }

    public static TenderingCriterion ParseTenderingCriterion(this XElement criterion)
    {
      if (criterion == null) return null;

      return new TenderingCriterion()
      {
        ID = criterion.Cbc("ID")?.ParseIdentifier(),
        CriterionTypeCode = criterion.Cbc("CriterionTypeCode").ParseCode(),
        SubTenderingCriteria = criterion.Cacs("SubTenderingCriterion").Select( sc => sc.ParseTenderingCriterion()).ToArray(),
        Legislations = criterion.Cacs("Legislation").Select( l => l.ParseLegislation() ).ToArray(),
        TenderingCriterionPropertyGroups = criterion.Cacs("TenderingCriterionPropertyGroup").Select( tg => tg.ParseTenderingCriterionGroup()).ToArray(),
        Name = criterion.Cbc("Name")?.Value,
        Description = criterion.Cbcs("Description")?.ParseDescription(),
        FulfilmentIndicatorTypeCode = criterion.Cbc("FulfilmentIndicatorTypeCode")?.Value,
        ApplicableContractType = ContractType.Any,
       
      };
    }

    public static TenderingCriterionPropertyGroup ParseTenderingCriterionGroup(this XElement group)
    {
      if (group == null) return null;

      return new TenderingCriterionPropertyGroup()
      {
        ID = group.Cbc("ID").ParseIdentifier(),
        Description = group.Cbcs("Description")?.ParseDescription(),
        FulfilmentIndicatorTypeCode = group.Cbc("FulfilmentIndicatorTypeCode").ParseCode(),
        PropertyGroupTypeCode = group.Cbc("PropertyGroupTypeCode").ParseCode(),
        SubsidiaryTenderingCriterionPropertyGroups = group.Cacs("SubsidiaryTenderingCriterionPropertyGroup").Select( g => g.ParseTenderingCriterionGroup()).ToArray(),
        TenderingCriterionProperties = group.Cacs("TenderingCriterionProperty").Select( p => p.ParseProperty()).ToArray(),
        
      };

    }

    public static TenderingCriterionProperty ParseProperty(this XElement property)
    {
      if (property == null) return null;

      return new TenderingCriterionProperty()
      {
        ID = property.Cbc("ID").ParseIdentifier(),
        Description = property.Cbc("Description")?.Value,
        Name = property.Cbc("Name")?.Value,
        TypeCode = property.Cbc("TypeCode")?.ParseCode(),
        ValueDataTypeCode = property.Cbc("ValueDataTypeCode")?.ParseCode(),
        CodeListId = property.Cbc("CodeListId")?.Value,
        ExpectedID = property.Cbc("ExpectedID").ParseIdentifier(),
        ExpectedDescription = property.Cbc("ExpectedDescription")?.Value,
        ExpectedAmount = property.Cbc("ExpectedAmount")?.ParseAmount(),
        ExpectedCode = property.Cbc("ExpectedCode")?.ParseCode(),
        ApplicablePeriod = property.Cbc("ApplicablePeriod")?.ParsePeriod(),
        CertificationLevelDescription = property.Cbcs("CertificationLevelDescription")?.ParseDescription(),
        TemplateEvidence = property.Cacs("TemplateEvidence").Select(te => te.ParseEvidence()).ToArray(),
        CopyQualityTypeCode = property.Cbc("CopyQualityTypeCode")?.ParseCode(),
        ExpectedValueNumeric = property.Cbc("ExpectedValueNumeric")?.ParseDecimal(),
        MaximumAmount = property.Cbc("MaximumAmount")?.ParseAmount(),
        MinimumAmount = property.Cbc("MinimumAmount")?.ParseAmount(),
        MaximumValueNumeric = property.Cbc("MaximumValueNumeric")?.ParseDecimal(),
        MinimumValueNumeric = property.Cbc("MinimumValueNumeric")?.ParseDecimal(),
        TranslationTypeCode = property.Cbc("TranslationTypeCode")?.Value,
        ValueCurrencyCode = property.Cbc("ValueCurrencyCode")?.ParseCode(),
        ValueUnitCode = property.Cbc("ValueUnitCode")?.ParseCode(),


      };
    }

    public static Period ParsePeriod(this XElement period)
    {
      if (period == null)
      {
        return null;
      }

      return new Period()
      {
        StartDate = period.Cbc("StartDate").ParseDate(),
        EndDate = period.Cbc("EndDate").ParseDate()
      };
    }

    public static Evidence ParseEvidence(this XElement evidence)
    {
      if (evidence == null)
      {
        return null;
      }

      return new Evidence()
      {
        ID = evidence.Cbc("ID").ParseIdentifier(),
        Description = evidence.Cbcs("Description").ParseDescription(),
        Name = evidence.Cbc("Name")?.Value,
        Language = evidence.Cac("Language").ParseLanguage(),
        DocumentReference = evidence.Cacs("DocumentReference").Select( d => d.ParseDocumentReference()).ToArray(),
        CandidateStatement = evidence.Cbcs("CandidateStatement").ParseDescription(),
        ConfidentialityLevelCode = evidence.Cbc("ConfidentialityLevelCode").ParseCode(),
        EvidenceTypeCode = evidence.Cbc("EvidenceTypeCode").ParseCode(),
        EvidenceIssuingParty = evidence.Cac("EvidenceIssuingParty").ParseParty()
      };
    }

    public static Language ParseLanguage(this XElement language)
    {
      if (language == null)
      {
        return null;
      }

      return new Language()
      {
        ID = language.Cbc("ID").ParseIdentifier(),
        Name = language.Cbc("Name").Value,
        LocaleCode = language.Cbc("LocaleCode").ParseCode(),
      };
    }

    public static DocumentReference ParseDocumentReference(this XElement documentRef)
    {
      if (documentRef == null)
      {
        return null;
      }

      return new DocumentReference()
      {
        ID = documentRef.Cbc("ID").ParseIdentifier(),
        IssueTime = documentRef.Cbc("IssueTime").ParseTime(),
        IssueDate = documentRef.Cbc("IssueTime").ParseDate(),
        VersionID = documentRef.Cbc("VersionID").ParseIdentifier(),
        LanguageID = documentRef.Cbc("LanguageID").ParseIdentifier(),
        LocaleCode = documentRef.Cbc("LocaleCode").ParseCode(),
        IssuerParty = documentRef.Cac("IssuerParty").ParseParty(),
        Attachment = documentRef.Cac("Attachment").ParseAttachment(),
        UUID = documentRef.Cbc("UUID").ParseIdentifier(),
        CopyIndicator = documentRef.Cbc("CopyIndicator").ParseBool().GetValueOrDefault(),
        XPath = documentRef.Cacs("XPath").ParseDescription(),
        ValidityPeriod = documentRef.Cbc("ValidityPeriod").ParsePeriod(),
        DocumentDescription = documentRef.Cbcs("DocumentDescription").ParseDescription(),
        DocumentStatusCode = documentRef.Cbc("DocumentStatusCode").ParseCode(),
        DocumentType = documentRef.Cbc("DocumentType")?.Value,
        DocumentTypeCode = documentRef.Cbc("DocumentTypeCode").ParseCode(),
        ResultOfVerification = documentRef.Cac("ResultOfVerification").ParseResultOfVerification(),
        
      };
    }

    public static ResultOfVerification ParseResultOfVerification(this XElement element)
    {
      return element == null ? null : new ResultOfVerification()
      {
        SignatoryParty = element.Cac("SignatoryParty").ParseParty(),
        ValidateProcess = element.Cbc("ValidateProcess")?.Value,
        ValidateTool = element.Cbc("ValidateTool")?.Value,
        ValidateToolVersion = element.Cbc("ValidateTool")?.Value,
        ValidationDate = element.Cbc("ValidationDate")?.ParseDate(),
        ValidationResultCode = element.Cbc("ValidationResultCode").ParseCode(),
        ValidationTime = element.Cbc("ValidationTime").ParseTime(),
        ValidatorID = element.Cbc("ValidatorID").ParseIdentifier()
      };
    }
    
    public static Attachment ParseAttachment(this XElement element)
    {
      var binaryElement = element?.Cbc("EmbeddedDocumentBinaryObject");
      return element == null ? null : new Attachment()
      {
        EmbeddedDocumentBinaryObject = binaryElement != null ? Convert.FromBase64String(binaryElement.Value) : null, 
        EmbeddedDocument = element.Cbc("EmbeddedDocument")?.Value,
        ExternalReference = element.Cac("ExternalReference").ParseExternalReference( )
      };
    }

    public static ExternalReference ParseExternalReference(this XElement element)
    {
      return element == null ? null : new ExternalReference()
      {
        Description = element.Cbcs("Description")?.ParseDescription(),
        URI = element.Cbc("URI").ParseIdentifier(),
        ExpiryTime = element.Cbc("ExpiryTime").ParseTime(),
        ExpiryDate = element.Cbc("ExpiryDate").ParseDate(),
        MimeCode = element.Cbc("MimeCode").ParseCode(),
        FileName = element.Cbc("FileName")?.Value,
        CharacterSetCode = element.Cbc("CharacterSetCode").ParseCode(),
        DocumentHash = element.Cbc("DocumentHash")?.Value,
        EncodingCode = element.Cbc("EncodingCode").ParseCode(),
        FormatCode = element.Cbc("FormatCode").ParseCode(),
        HashAlgorithmMethod = element.Cbc("HashAlgorithmMethod")?.Value
      };
    }

    public static ProcurementProject ParseProcurementProject(this XElement element)
    {
      if (element == null) return null;

      return new ProcurementProject()
      {
        Name = element.Cbc("Name")?.Value,
        MainCommodityClassifications = element.Cacs("MainCommodityClassification")
          .Select(c => new CommodityClassification()
          {
            ItemClassificationCode = new CodeType(c.Cbc("ItemClassificationCode")?.Value)
          }).ToArray(),
        ProcurementTypeCode = element.Cbc("ProcurementTypeCode").ParseCode(),
        Description = element.Cbc("Description")?.Value
      };

    }

    public static Legislation ParseLegislation(this XElement legislation)
    {
      if (legislation == null) return null;

      return new Legislation()
      {
        ID = legislation.Cbc("ID").ParseIdentifier(),
        Title = legislation.Cbc("Title")?.Value,
        Description = legislation.Cbc("Description")?.Value,
        JurisdictionLevel = legislation.Cbc("JurisdictionLevel")?.Value,
        Article = legislation.Cbc("Article")?.Value,
        URI = legislation.Cbc("URI").ParseIdentifier(),
        Languages = legislation.Cacs("Language")
          .Select(l => new Language() { LocaleCode = l.Cbc("LocaleCode").ParseCode()}).ToArray(),
        JurisdictionRegionAddress = legislation.Cac("JurisdictionRegionAddress").ParseAddress()
      };
    }

    public static ProcurementProjectLot ParseProcurementProjectLot(this XElement projectLot)
    {
      if (projectLot == null) return null;

      return new ProcurementProjectLot()
      {
        ID = projectLot.Cbc("ID").ParseIdentifier()
      };
    }

    public static Address ParseAddress(this XElement address)
    {
      if (address == null) return null;

      return new Address()
      {
        ID = address.Cbc("ID").ParseIdentifier(),
        BuildingName = address.Cbc("BuildingName")?.Value,
        CityName = address.Cbc("CityName")?.Value,
        LocationCoordinates = address.Cacs("LocationCoordinate").ParseLocationCoordinates(),
        PostalZone = address.Cbc("PostalZone")?.Value,
        Country = address.Cac("Country").ParseCountry(),
        StreetName = address.Cbc("StreetName")?.Value,
        AddressLines = address.Cbcs("AddressLine").SelectMany( a => a.Cbcs("Line"), ((addressLine, line) => line.Value )).ToArray(),
        AdditionalStreetName = address.Cbc("AdditionalStreetName")?.Value,
        AddressFormatCode = address.Cbc("AddressFormatCode").ParseCode(),
        AddressTypeCode = address.Cbc("AddressTypeCode").ParseCode(),
        BlockName = address.Cbc("BlockName")?.Value,
        BuildingNumber = address.Cbc("BuildingNumber")?.Value,
        CitySubdivisionName = address.Cbc("CitySubdivisionName")?.Value,
        CountrySubentity = address.Cbc("CountrySubentity")?.Value,
        CountrySubentityCode = address.Cbc("CountrySubentityCode").ParseCode(),
        Department = address.Cbc("Department")?.Value,
        District = address.Cbc("District")?.Value,
        Floor = address.Cbc("Floor")?.Value,
        InhouseMail = address.Cbc("InhouseMail")?.Value,
        MarkAttention = address.Cbc("MarkAttention")?.Value,
        MarkCare = address.Cbc("MarkCare")?.Value,
        PlotIdentification = address.Cbc("PlotIdentification")?.Value,
        Postbox = address.Cbc("Postbox")?.Value,
        Region = address.Cbc("Region")?.Value,
        Room = address.Cbc("Room")?.Value,
        TimezoneOffset = address.Cbc("TimezoneOffset")?.Value
      };

    }

    public static Country ParseCountry(this XElement countryElement)
    {
      return new Country()
      {
        IdentificationCode = countryElement.Cbc("IdentificationCode").ParseCode(),
        Name = countryElement.Cbc("Name")?.Value
      };
    }

    public static LocationCoordinate[] ParseLocationCoordinates(this IEnumerable<XElement> coordinates)
    {
      return coordinates?.Select(c => new LocationCoordinate()
      {
        AltitudeMeasure = c.Cbc("AltitudeMeasure").ParseMeasure(),
        CoordinateSystemCode = c.Cbc("CoordinateSystemCode").ParseCode(),
        LatitudeDegreesMeasure = c.Cbc("LatitudeDegreesMeasure").ParseMeasure(),
        LatitudeDirectionCode = c.Cbc("LatitudeDirectionCode").ParseCode(),
        LatitudeMinutesMeasure = c.Cbc("LatitudeMinutesMeasure").ParseMeasure(),
        LongitudeDegreesMeasure = c.Cbc("LongitudeDegreesMeasure").ParseMeasure(),
        LongitudeDirectionCode = c.Cbc("LongitudeDirectionCode").ParseCode(),
        LongitudeMinutesMeasure = c.Cbc("LongitudeMinutesMeasure").ParseMeasure()
      }).ToArray();
    }

    public static Contact ParseContact(this XElement contact)
    {
      if (contact == null) return null;

      return new Contact()
      {
        Name = contact.Cbc("Name")?.Value,
        Telephone = contact.Cbc("Telephone")?.Value,
        ElectronicMail = contact.Cbc("ElectronicMail")?.Value,
        Telefax = contact.Cbc("Telefax")?.Value
      };
    }
    public static EconomicOperatorParty ParseEconomicOperatorParty(this XElement party)
    {
      if (party == null)
      {
        return null;
      }

      var eoParty = new EconomicOperatorParty()
      {
        Party = party.Cac("Party").ParseParty(),
        EconomicOperatorRole = party.Cac("EconomicOperatorRole").ParseEconomicOperatorRole(),
        QualifyingParty = party.Cac("QualifyingParty").ParseQualifyingParty()
      };

      return eoParty;
    }

    public static ServiceProviderParty ParseServiceProviderParty(this XElement serviceProviderParty)
    {
      if (serviceProviderParty == null) return null;

      return new ServiceProviderParty()
      {
        Party = serviceProviderParty.Cac("Party").ParseParty(),
        ServiceProviderTypeCode = serviceProviderParty.Cbc("ServiceProviderTypeCode").ParseCode(),
        ServiceType = serviceProviderParty.Cbcs("ServiceType").ParseDescription(),
        ID = serviceProviderParty.Cbc("ID").ParseIdentifier()
      };
    }

    public static Party ParseParty(this XElement party)
    {
      if (party == null)
      {
        return null;
      }

      var partyName = party.Cac("PartyName");

      return new Party()
      {
        WebsiteURI = party.Cbc("WebsiteURI").ParseIdentifier(),
        PartyIdentification = ParsePartyIdentification(party.Cac("PartyIdentification")),
        PartyName = partyName != null ? new PartyName() { Name = partyName.Cbc("Name").Value } : null,
        PostalAddress = party.Cac("PostalAddress").ParseAddress(),
        Contact = party.Cac("Contact").ParseContact(),
        ServiceProviderParty = party.Cac("ServiceProviderParty").ParseServiceProviderParty(), 
        IndustryClassificationCode = party.Cbc("IndustryClassificationCode").ParseCode(),
        EndpointID = party.Cbc("EndpointID").ParseIdentifier(),
        AgentParty = party.Cac("AgentParty").ParseParty(),
        Person = party.Cac("Person").ParsePerson(),
        PowerOfAttorneys = party.Cacs("PowerOfAttorney").Select( pa => pa.ParsePowerOfAttorney()).ToArray()
      };
    }

    public static PowerOfAttorney ParsePowerOfAttorney(this XElement poa)
    {
      if (poa == null)
      {
        return null;
      }

      return new PowerOfAttorney()
      {
        Description = poa.Cbcs("Description").ParseDescription(),
        AgentParty = poa.Cac("AgentParty").ParseParty()
      };
    }

    public static PartyIdentification ParsePartyIdentification(this XElement partyIdentifcation)
    {
      if (partyIdentifcation == null)
      {
        return null;
      }

      return new PartyIdentification()
      {
        ID = partyIdentifcation.Cbc("ID").ParseIdentifier()
      };
    }

    public static ContractingParty ParseContractingParty(this XElement cpElement)
    {
      if (cpElement == null)
      {
        return null;
      }

      return new ContractingParty()
      {
        BuyerProfileUri = cpElement.Cac("BuyerProfileUri").ParseIdentifier(),
        Party = ParseParty(cpElement.Cac("Party"))
      };
    }

    public static Person ParsePerson(this XElement person)
    {
      if (person == null)
      {
        return null;
      }

      return new Person()
      {
        Contact = person.Cac("Contact").ParseContact(),
        ResidenceAddress = person.Cac("ResidenceAddress").ParseAddress(),
        FirstName = person.Cbc("FirstName")?.Value,
        FamilyName = person.Cbc("FamilyName")?.Value,
        BirthDate = person.Cbc("BirthDate").ParseDate(),
        BirthPlaceName = person.Cbc("BirthPlaceName")?.Value
      };
    }

    public static QualifyingParty ParseQualifyingParty(this XElement qualifyingParty)
    {
      if (qualifyingParty == null)
      {
        return null;
      }

      return new QualifyingParty()
      {
        BusinessClassificationScheme =
          qualifyingParty.Cac("BusinessClassificationScheme").ParseBusinessClassificationScheme(),
        CompletedTask = qualifyingParty.Cac("CompletedTask").ParseCompletedTask(),
        EmployeeQuantity = qualifyingParty.Cbc("EmployeeQuantity").ParseQuantity(),
        FinancialCapability = qualifyingParty.Cac("CompletedTask").ParseFinancialCapability(),
        Party = qualifyingParty.Cac("Party").ParseParty()
      };
    }

    private static CompletedTask ParseCompletedTask(this XElement element)
    {
      return element != null ? new CompletedTask()
      {
        Description = element.Cbc("Description")?.Value

      } : null;
    }

    private static FinancialCapability ParseFinancialCapability(this XElement element)
    {
      return element != null ? new FinancialCapability()
      {
        ValueAmount = element.Cbc("ValueAmount").ParseAmount()
      } : null;
    }

    public static BusinessClassificationScheme ParseBusinessClassificationScheme(this XElement bcScheme)
    {
      if (bcScheme == null)
      {
        return null;
      }

      return new BusinessClassificationScheme()
      {
        ID = bcScheme.Cbc("ID").ParseIdentifier(),
        Description = bcScheme.Cbcs("Description").Select( d => d.Value).ToArray(),
        ClassificationCategory = bcScheme.Cac("ClassificationCategory").ParseClassificationCategory()
      };
    }

    public static ClassificationCategory ParseClassificationCategory(this XElement bcScheme)
    {
      if (bcScheme == null)
      {
        return null;
      }

      return new ClassificationCategory()
      {
        Name = bcScheme.Cbc("Name").Value,
        CategorizesClassificationCategories = bcScheme.Cbcs("CategorizesClassificationCategory").Select( c => c.ParseClassificationCategory()).ToArray(),
        CodeValue = bcScheme.Cbc("CodeValue").ParseCode(),
        Description = bcScheme.Cbcs("Description").Select(d => d.Value).ToArray()
      };
    }

    public static EconomicOperatorRole ParseEconomicOperatorRole(this XElement economicOperatorRole)
    {
      if (economicOperatorRole == null) return null;

      return new EconomicOperatorRole()
      {
        RoleCode = economicOperatorRole.Cbc("RoleCode").ParseCode(),
        RoleDescription = economicOperatorRole.Cbcs("Description").Select(d => d.Value).ToArray()
      };
    }
  }
}