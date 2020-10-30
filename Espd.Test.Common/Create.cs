using System;
using System.Collections.Generic;
using System.Linq;
using Hilma.Espd.EDM.CriterionModels;
using Hilma.Espd.EDM.CriterionModels.v2_1_1.Identifiers;
using Hilma.UBL.CommonAggregateComponents;
using Hilma.UBL.UnqualifiedDataTypes;

namespace Espd.Test.Common
{
  public class Create
  {
    public static QualificationApplicationResponse QualificationApplicationResponse( IEnumerable<TenderingCriterion> additionalCriteria = null )
    {
      var request = CriteriaTaxonomyExtendedV2_1_1;
      request.AdditionalDocumentReferences = new AdditionalDocumentReference[]{
        new AdditionalDocumentReference
        {
          ID = new IdentifierType
          {
            Value = "2020/S 100-000001",
            SchemeAgencyID = "EU-COM-OP"
          },
          DocumentTypeCode = new EuComGrowCodeType
          {
            ListID = "DocRefContentType",
            ListAgencyID = "EU-COM-GROW",
            ListVersionID = "2.1.1",
            Value = "TED_CN"
          },
          Attachment = new Attachment
          {
            ExternalReference = new ExternalReference
            {
              URI = new IdentifierType
              {
                Value = "http://ted.europa.eu"
              },
              FileName = "Hankinta X",
              Description = new[]
              {
               "Hankinta X",
               "0000/S 000-000000",
             }
            }
          }
        }
      };

      if( additionalCriteria != null )
      {
        request.TenderingCriteria = request.TenderingCriteria.Union( additionalCriteria).ToArray();
      }

      var factory = new QualificationApplicationFactory();
      var espdUrl = "http://localhost/espd/";
      var response = factory.CreateEspd2_1_1ExtendedResponse(
        request, 
        EconomicOperatorParty(),
        new EuComGrowId(Guid.NewGuid()),
        Guid.NewGuid(),
        espdUrl, 
        "FI"
      );

      var evidences = new[]
      {
        new Evidence()
        {
          ID = EuComGrowId.Random(),
          Description = new[] {"Evidence stuff"},
          DocumentReference = new DocumentReference[]
          {
            new DocumentReference()
            {
              ID = EuComGrowId.Random(),
              IssuerParty = new Party()
              {
                PartyName = new PartyName()
                {
                  Name = "Issuer"
                }
              }
            }
          }
        }
      };
      response.Evidences = evidences;
      response.TenderingCriterionResponses = CreateResponses(response).ToArray();
      
      return response;
    }

    public static EconomicOperatorParty EconomicOperatorParty()
    {
      return new EconomicOperatorParty
      {
        QualifyingParty = new QualifyingParty()
        {
          BusinessClassificationScheme = new BusinessClassificationScheme()
          {
            ID = EuComGrowId.Random(),
            Description = new string[] {"My description"},
            ClassificationCategory = new ClassificationCategory()
          },
          EmployeeQuantity = new QuantityType() {Value = 10},
          FinancialCapability = new FinancialCapability()
          {
            ValueAmount = new AmountType(1000000m) {CurrencyID = "EUR", CurrencyCodeListVersionID = "1.0"}
          },
          Party = new Party()
          {
            IndustryClassificationCode = new CodeType("SMALL")
              {ListID = "EOIndustryClassificationCode", ListAgencyID = "EU-COM-GROW", ListVersionID = "2.1.1"},
            PartyIdentification = new PartyIdentification
            {
              ID = new IdentifierType("FI1234560") {SchemeID = "VAT", SchemeAgencyID = "VIES"}
            }
          }
        },
        EconomicOperatorRole = new EconomicOperatorRole()
        {
          RoleCode = new EuComGrowCodeType("SC") {ListID = "EORoleType"},
          RoleDescription = new string[0]
        },
        Party = new Party
        {
          PartyIdentification = new PartyIdentification
          {
            ID = new IdentifierType("FI1234560") {SchemeID = "VAT", SchemeAgencyID = "VIES"}
          },
          IndustryClassificationCode = new CodeType("SMALL")
            {ListID = "EOIndustryClassificationCode", ListAgencyID = "EU-COM-GROW", ListVersionID = "2.1.1"},
          WebsiteURI = new IdentifierType("http://foo.fi"),
          PartyName = new PartyName
          {
            Name = "Foo business"
          },
          PostalAddress = new Address
          {
            AddressLines = new[] {"Foo str 1"},
            CityName = "Foocity",
            PostalZone = "00100",
            Country = new Country
            {
              IdentificationCode = new EuComGrowCodeType
              {
                ListVersionID = "1.0",
                ListAgencyID = "ISO",
                ListName = "CountryCodeIdentifier",
                ListID = "CountryCodeIdentifier",
                Value = "FI"
              },
              Name = "Finland"
            }
          },
          Contact = new Contact
          {
            Name = "Mr. Foo",
            ElectronicMail = "info@foo.fi",
            Telephone = "+3580441234455"
          },
          PowerOfAttorneys = new PowerOfAttorney[]
          {
            new PowerOfAttorney()
            {
              AgentParty = new Party()
              {
                Person = new Person()
                {
                  FirstName = "Foo",
                  FamilyName = "Foobar",
                  ResidenceAddress = new Address()
                  {
                    AddressLines = new[] {"Fooavenue 1"},
                    CityName = "Foocity",
                    Country = new Country()
                    {
                      IdentificationCode = new CodeType("FI")
                        {ListID = "CountryCodeIdentifier", ListVersionID = "1.0", ListAgencyID = "ISO"},
                      Name = "Finland"
                    }
                  }
                }
              },
            }
          }
        }
      };
    }

    public static IEnumerable<TenderingCriterionResponse> CreateResponses(QualificationApplicationResponse response)
    {
      foreach (var property in response.TenderingCriteria.SelectMany(c =>
        c.DescendantProperties().Where(p => p.TypeCode.Equals(CriterionElementType.Question))))
      {
        var isPeriod = property.ValueDataTypeCode.Equals(ResponseDataTypeCode.Period);
        var isEvidence = property.ValueDataTypeCode.Equals(ResponseDataTypeCode.EvidenceIdentifier);
        var isResponseValue = !(isPeriod || isEvidence);
        yield return new TenderingCriterionResponse()
        {
          ID = EuComGrowId.Random(),
          ValidatedCriterionPropertyID = property.ID,
          EvidenceSupplied = isEvidence
            ? new EvidenceSupplied()
            {
              ID = response.Evidences[0].ID
            }
            : null,
          ApplicablePeriod = isPeriod
            ? new Period() {StartDate = new DateTime(2020, 1, 1), EndDate = new DateTime(2020, 12, 31)}
            : null,
          ResponseValue = isResponseValue ? new[] {CreateResponseValue(property)} : new ResponseValue[0]
        };
      }
    }

    public static ResponseValue CreateResponseValue(TenderingCriterionProperty property)
    {
      var responseValue = new ResponseValue() {ID = EuComGrowId.Random()};

      switch (property.ValueDataTypeCode.Value)
      {
        case "AMOUNT":
          responseValue.ResponseAmount = new AmountType(100m){ CurrencyID = "EUR"};
          break;
        case "QUANTITY":
          responseValue.ResponseQuantity = new QuantityType(200m) {UnitCode = "pcs"};
          break;
        case "QUANTITY_YEAR":
          responseValue.ResponseQuantity = new QuantityType(200m) {UnitCode = "YEAR"};
          break;
        case "QUANTITY_INTEGER":
          responseValue.ResponseQuantity = new QuantityType(200m) { UnitCode = "PCS" };
          break;
        case "CODE":
          responseValue.ResponseCode = new CodeType("FOO");
          break;
        case "MEASURE":
          responseValue.ResponseMeasure = new MeasureType(123, "m");
          break;
        case "DATE":
          responseValue.ResponseDate = new DateType(new DateTime(2020, 1, 1));
          break;
        case "INDICATOR":
          responseValue.ResponseIndicator = true;
          break;
        default:
          responseValue.Description = new[] {"Some description"};
          break;
      }

      return responseValue;
    }

    public static QualificationApplicationRequest ScAbilitiesStaffSelfContainedRequest =>
      new QualificationApplicationRequest
      {
        UBLVersionID = new IdentifierType {Value = "2.2",},
        CustomizationID = new IdentifierType {Value = "urn:www.cenbii.eu:transaction:biitrdm092:ver3.0"},
        ProfileID = new IdentifierType {Value = "4.1"},
        ProfileExecutionID = ProfileExecutionId.Espd2_1_1Extended,
        ID = new IdentifierType
        {
          Value = "576ae724-f8e8-4b51-ae9c-2c2f4c90f433", SchemeID = "ISO/IEC 9834-8:2008 - 4UUID",
          SchemeAgencyID = "EU-COM-GROW", SchemeAgencyName = "DG GROW (European Commission)"
        },
        CopyIndicator = false,
        UUID = new IdentifierType
          {Value = "7a186dda-ad3b-4c9d-9e1c-0b44c716b28e", SchemeID = "ISO/IEC 9834-8:2008 - 4UUID"},
        ContractFolderID = new IdentifierType {Value = "__ProcurementProcedureFileRefNumber", SchemeAgencyID = "TeD"},
        IssueDate = new DateType {Value = DateTime.Parse("2019-01-23")},
        IssueTime = new TimeType {Hour = 00, Minute = 08, Second = 33},
        VersionID = new IdentifierType {Value = "2018.01.01"},
        ProcedureCode = new CodeType
          {Value = "OPEN", ListID = "ProcedureType", ListAgencyID = "EU-COM-OP", ListVersionID = "1.0"},
        QualificationApplicationTypeCode = new CodeType {Value = "SELFCONTAINED"},
        WeightScoringMethodologyNote = new[] {"__WeightingScoringMethodologyNote"},
        WeightingTypeCode = new CodeType {Value = "PERCENTAGE"},
        ContractingParty = new ContractingParty
        {
          Party = new Party
          {
            WebsiteURI = new IdentifierType("www.__Procurer.com"),
            PartyIdentification = new PartyIdentification
              {ID = new IdentifierType("GR153301872") {SchemeAgencyID = "VIES-AEAT"}},
            PartyName = new PartyName
            {
              Name = "__ProcurerName"
            },
            PostalAddress = new Address
            {
              StreetName = "__ProcurerStreet",
              CityName = "__ProcurerCity",
              PostalZone = "12345",
              Country = new Country
              {
                IdentificationCode = new CodeType()
                {
                  ListVersionID = "1.0",
                  ListAgencyID = "ISO",
                  ListName = "CountryCodeIdentifier",
                  ListID = "CountryCodeIdentifier",
                  Value = "GR"
                }
              }
            },
            Contact = new Contact
            {
              Name = "__ProcurerContactName",
              Telephone = "654321",
              Telefax = "098765",
              ElectronicMail = "__ProcurerContact@pr.com"
            }
          }
        },
        ProcurementProject = new ProcurementProject
        {
          Name = "__ProcurementProcedureTitle",
          Description = "__ProcurementProcedureDescription",
          ProcurementTypeCode = new CodeType
          {
            Value = "COMBINED",
            ListAgencyID = "EU-COM-OP",
            ListID = "ProjectType",
            ListVersionID = "1.0",
          },
          MainCommodityClassifications = new[]
          {
            new CommodityClassification
            {
              ItemClassificationCode = new CodeType {Value = "45463100-8"}
            }
          }
        },
        ProcurementProjectLots = new[]
        {
          new ProcurementProjectLot
          {
            ID = new EuComGrowId("Lot1")
          },
          new ProcurementProjectLot
          {
            ID = new EuComGrowId("Lot2")
          },
          new ProcurementProjectLot
          {
            ID = new EuComGrowId("Lot3")
          }
        },
        TenderingCriteria = new[]
        {
          new TenderingCriterion
          {
            ID = new CriteriaTaxonomyIdentifier("6346959b-e097-4ea1-89cd-d1b4c131ea4d"),
            CriterionTypeCode =
              new CriterionTypeCode("CRITERION.SELECTION.TECHNICAL_PROFESSIONAL_ABILITY.MANAGEMENT.MANAGERIAL_STAFF"),
            Name = "Number of managerial staff",
            Description = new[]
              {"The economic operator’s number of managerial staff for the last three years were as follows:"},
            Legislations = new[]
            {
              new Legislation
              {
                Title = "Public Procurement Directive 2014/24/EU",
                Description =
                  "Directive 2014/24/EU of the European Parliament and of the Council of 26 February 2014 on public procurement and repealing Directive 2004/18/EC",
                JurisdictionLevel = "eu",
                Article = "Article 58(4)",
                URI = new IdentifierType(
                  "http://eur-lex.europa.eu/legal-content/EN/TXT/?uri=uriserv:OJ.L_.2014.094.01.0065.01.ENG")
              }
            },
            TenderingCriterionPropertyGroups = new[]
            {
              new TenderingCriterionPropertyGroup
              {
                ID = new CriteriaTaxonomyIdentifier("7f7949a8-dbe6-496c-a9f6-6f05b8648bad"),
                PropertyGroupTypeCode = new PropertyGroupTypeCode("ON*"),
                TenderingCriterionProperties = new[]
                {
                  new TenderingCriterionProperty
                  {
                    ID = new CriteriaTaxonomyIdentifier("2416716f-1d55-4a5a-8580-f8b5a33ca2c9"),
                    Description = "Minum number of years",
                    TypeCode = CriterionElementType.Requirement,
                    ValueDataTypeCode = new ResponseDataTypeCode("QUANTITY_INTEGER"),
                    ExpectedValueNumeric = 3
                  },
                  new TenderingCriterionProperty
                  {
                    ID = new CriteriaTaxonomyIdentifier("da6558a0-0878-4662-99fd-a7040b139e02"),
                    Description = "Additional information",
                    TypeCode = new CriterionElementType("REQUIREMENT"),
                    ValueDataTypeCode = new ResponseDataTypeCode("DESCRIPTION"),
                    ExpectedDescription = "Provide a sufficient description of the manageurial team."
                  }
                },
                SubsidiaryTenderingCriterionPropertyGroups = new[]
                {
                  new TenderingCriterionPropertyGroup
                  {
                    ID = new CriteriaTaxonomyIdentifier("96defecc-7d32-4957-82e9-aad5f3c5b736"),
                    PropertyGroupTypeCode = new PropertyGroupTypeCode("ON*"),
                    TenderingCriterionProperties = new[]
                    {
                      new TenderingCriterionProperty
                      {
                        ID = new CriteriaTaxonomyIdentifier("bd677a81-a394-44de-b7d2-8bf3be5991d8"),
                        Description = "Year",
                        TypeCode = CriterionElementType.Question,
                        ValueDataTypeCode = new ResponseDataTypeCode("QUANTITY_YEAR")
                      },
                      new TenderingCriterionProperty
                      {
                        ID = new CriteriaTaxonomyIdentifier("102375b8-881f-4bac-85d7-15f78e7a7895"),
                        Description = "Number",
                        TypeCode = CriterionElementType.Question,
                        ValueDataTypeCode = new ResponseDataTypeCode("QUANTITY_INTEGER")
                      }
                    }
                  },
                  new TenderingCriterionPropertyGroup
                  {
                    ID = new CriteriaTaxonomyIdentifier("7458d42a-e581-4640-9283-34ceb3ad4345"),
                    PropertyGroupTypeCode = new PropertyGroupTypeCode("ON*"),
                    TenderingCriterionProperties = new[]
                    {
                      new TenderingCriterionProperty
                      {
                        ID = new CriteriaTaxonomyIdentifier("e4ba8c07-41c0-4caa-8f3f-ced8a264e0d8"),
                        Description = "Is this information available online?",
                        TypeCode = CriterionElementType.Question,
                        ValueDataTypeCode = ResponseDataTypeCode.Indicator
                      }
                    },
                    SubsidiaryTenderingCriterionPropertyGroups = new[]
                    {
                      new TenderingCriterionPropertyGroup
                      {
                        ID = new CriteriaTaxonomyIdentifier("41dd2e9b-1bfd-44c7-93ee-56bd74a4334b"),
                        PropertyGroupTypeCode = new PropertyGroupTypeCode("ONTRUE"),
                        TenderingCriterionProperties = new[]
                        {
                          new TenderingCriterionProperty
                          {
                            ID = new CriteriaTaxonomyIdentifier("824db12c-9a09-49ad-8180-851190077ad7"),
                            Description = "Evidence Supplied",
                            TypeCode = CriterionElementType.Question,
                            ValueDataTypeCode = new ResponseDataTypeCode("EVIDENCE_IDENTIFIER")
                          }
                        }
                      }
                    }
                  },
                  new TenderingCriterionPropertyGroup
                  {
                    ID = new CriteriaTaxonomyIdentifier("96defecc-7d32-4957-82e9-aad5f3c5b736"),
                    PropertyGroupTypeCode = new PropertyGroupTypeCode("ON*"),
                    TenderingCriterionProperties = new[]
                    {
                      new TenderingCriterionProperty
                      {
                        ID = new CriteriaTaxonomyIdentifier("0dcb85d0-9c7a-4dc3-b966-48dd8d00a4e4"),
                        Description = "Year",
                        TypeCode = CriterionElementType.Question,
                        ValueDataTypeCode = new ResponseDataTypeCode("QUANTITY_YEAR")
                      },
                      new TenderingCriterionProperty
                      {
                        ID = new CriteriaTaxonomyIdentifier("3995be99-c599-4049-a8e4-78d96a787fb1"),
                        Description = "Number",
                        TypeCode = CriterionElementType.Question,
                        ValueDataTypeCode = new ResponseDataTypeCode("QUANTITY_INTEGER")
                      }
                    }
                  },
                  new TenderingCriterionPropertyGroup
                  {
                    ID = new CriteriaTaxonomyIdentifier("96defecc-7d32-4957-82e9-aad5f3c5b736"),
                    PropertyGroupTypeCode = new PropertyGroupTypeCode("ON*"),
                    TenderingCriterionProperties = new[]
                    {
                      new TenderingCriterionProperty
                      {
                        ID = new CriteriaTaxonomyIdentifier("783bb2c3-b354-45e4-a75e-0547393ce05a"),
                        Description = "Year",
                        TypeCode = CriterionElementType.Question,
                        ValueDataTypeCode = new ResponseDataTypeCode("QUANTITY_YEAR")
                      },
                      new TenderingCriterionProperty
                      {
                        ID = new CriteriaTaxonomyIdentifier("d9cd4ee1-c0f1-441a-8057-07ecba179266"),
                        Description = "Number",
                        TypeCode = CriterionElementType.Question,
                        ValueDataTypeCode = new ResponseDataTypeCode("QUANTITY_INTEGER")
                      }
                    }
                  },
                  new TenderingCriterionPropertyGroup
                  {
                    ID = new CriteriaTaxonomyIdentifier("7458d42a-e581-4640-9283-34ceb3ad4345"),
                    PropertyGroupTypeCode = new PropertyGroupTypeCode("ON*"),
                    TenderingCriterionProperties = new[]
                    {
                      new TenderingCriterionProperty
                      {
                        ID = new CriteriaTaxonomyIdentifier("9c2b9ccd-02a4-4eca-b006-f699a949fb9b"),
                        Description = "Is this information available online?",
                        TypeCode = CriterionElementType.Question,
                        ValueDataTypeCode = ResponseDataTypeCode.Indicator
                      }
                    },
                    SubsidiaryTenderingCriterionPropertyGroups = new[]
                    {
                      new TenderingCriterionPropertyGroup
                      {
                        ID = new CriteriaTaxonomyIdentifier("41dd2e9b-1bfd-44c7-93ee-56bd74a4334b"),
                        PropertyGroupTypeCode = new PropertyGroupTypeCode("ONTRUE"),
                        TenderingCriterionProperties = new[]
                        {
                          new TenderingCriterionProperty
                          {
                            ID = new CriteriaTaxonomyIdentifier("4fe907ea-e0ca-48a9-aae7-0afc5621be8a"),
                            Description = "Evidence Supplied",
                            TypeCode = CriterionElementType.Question,
                            ValueDataTypeCode = new ResponseDataTypeCode("EVIDENCE_IDENTIFIER")
                          }
                        }
                      }
                    }
                  }
                }
              }
            }
          }
        }
      };

    public static QualificationApplicationRequest SimpleQualificationApplicationRequest =>
      new QualificationApplicationRequest
      {
        ID = new CriteriaTaxonomyIdentifier("12345"),
        TenderingCriteria = new[]
        {
          new TenderingCriterion
          {
            ID = new CriteriaTaxonomyIdentifier("12323"),
            CriterionTypeCode = new CriterionTypeCode("FOO"),
            Description = new[] {"Kuvaus"},
            Legislations = new[]
            {
              new Legislation
              {
                ID = new IdentifierType("ecertis guid"),
                Description = "Lakijuttuja",
                Title = "Lakiperuste x."
              }
            },
            TenderingCriterionPropertyGroups = new[]
            {
              new TenderingCriterionPropertyGroup
              {
                ID = new CriteriaTaxonomyIdentifier("123"),
                Description = new[] {"Foo"},
                PropertyGroupTypeCode = new PropertyGroupTypeCode("C0"),
                TenderingCriterionProperties = new[]
                {
                  new TenderingCriterionProperty
                  {
                    ID = new CriteriaTaxonomyIdentifier("221"),
                    Name = "Kysymys x",
                    Description = "Kuvaus",
                    TypeCode = new CriterionElementType("F")
                  }
                }
              }
            }
          }
        }
      };

    public static QualificationApplicationRequest CriteriaTaxonomyExtendedV2_1_1
    {
      get
      {
        var criterionSpecification = new CriterionFactory().V2_1_1;
        return new QualificationApplicationRequest
        {
          UBLVersionID = new IdentifierType {Value = "2.2", SchemeAgencyID = "OASIS-UBL-TC"},
          CustomizationID = new IdentifierType
          {
            Value = "urn:www.cenbii.eu:transaction:biitrdm070:ver3.0", SchemeVersionID = "3.0",
            SchemeAgencyID = "CEN-BII"
          },
          ProfileID = new IdentifierType {Value = "4.1", SchemeAgencyID = "CEN-BII", SchemeVersionID = "2.0"},
          ID = new IdentifierType {Value = "ESPDREQ-DGPE-f28dd0a52b", SchemeAgencyID = "DGPE"},
          CopyIndicator = false,
          UUID = new IdentifierType
          {
            Value = "9fb0fbb1-59a1-468c-95b1-046680f85ad3", SchemeAgencyID = "EU-COM-GROW",
            SchemeID = "ISO/IEC 9834-8:2008 - 4UUID", SchemeVersionID = "2.0"
          },
          ContractFolderID = new IdentifierType {Value = "PP.20170419.1024-9", SchemeAgencyID = "DGPE"},
          IssueDate = new DateType {Value = DateTime.Parse("2019-12-10")},
          IssueTime = new TimeType {Hour = 08, Minute = 32, Second = 48},
          VersionID = new IdentifierType {Value = "1.0", SchemeAgencyID = "EU-COM-GROW", SchemeVersionID = "2.0"},
          ProcedureCode = new CodeType
            {Value = "AWARD_WO_PUB", ListID = "ProcedureType", ListAgencyID = "EU-COM-OP", ListVersionID = "1.0"},
          QualificationApplicationTypeCode = new CodeType
          {
            Value = "Extended", ListID = "QualificationApplicationType", ListAgencyID = "EU-COM-GROW",
            ListVersionID = "2.1.1"
          },
          ProcurementProject = new ProcurementProject() {
            Name = "Procurement",
            Description = "Foo"
          },
          ProcurementProjectLots = new ProcurementProjectLot[]{ 
            new ProcurementProjectLot() {
              ID = new IdentifierType("0")
            }
          },
          ContractingParty = new ContractingParty
          {
            Party = new Party
            {
              WebsiteURI = new IdentifierType("www.Procurer.com"),
              PartyIdentification = new PartyIdentification
                {ID = new IdentifierType("AD123456789") {SchemeAgencyID = "EU-COM-GROW"}},
              PartyName = new PartyName
              {
                Name = "__ProcurerName"
              },
              PostalAddress = new Address
              {
                StreetName = "__ProcurerStreet",
                CityName = "__ProcurerCity",
                PostalZone = "12345",
                Country = new Country
                {
                  IdentificationCode = new CodeType()
                  {
                    ListVersionID = "1.0",
                    ListAgencyID = "ISO",
                    ListName = "CountryCodeIdentifier",
                    ListID = "CountryCodeIdentifier",
                    Value = "GR"
                  }
                }
              },
              Contact = new Contact
              {
                Name = "__ProcurerContactName",
                Telephone = "654321",
                Telefax = "098765",
                ElectronicMail = "__ProcurerContact@pr.com"
              }
            }
          },
          TenderingCriteria = new[]
          {
            criterionSpecification.ExclusionGrounds.Convictions[0],
            criterionSpecification.SelectionCriteria.Abilities[0],
            criterionSpecification.SelectionCriteria.SpecificAverageTurnover[0],
            criterionSpecification.SelectionCriteria.References[0],
          },
          AdditionalDocumentReferences = new [] { 
            new AdditionalDocumentReference
            {
              ID = new IdentifierType
              {
                Value = "0000/S 000-000000",
                SchemeAgencyID = "EU-COM-OP"
              },
              DocumentTypeCode = new EuComGrowCodeType
              {
                ListID = "DocRefContentType",
                ListAgencyID = "EU-COM-GROW",
                ListVersionID = "2.1.1",
                Value = "TED_CN"
              },
              Attachment = new Attachment
              {
                ExternalReference = new ExternalReference
                {
                  URI = new IdentifierType
                  {
                    Value = "http://ted.europa.eu"
                  },
                  FileName = "Procurement",
                  Description = new[]
                  {
                    "Procurement",
                    "0000/S 000-000000",
                  }
                }
              }
            }
          }
        };
      }
    }
  }
}