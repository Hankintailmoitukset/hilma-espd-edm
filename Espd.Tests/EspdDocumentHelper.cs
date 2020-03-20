using Hilma.UBL.CommonAggregateComponents;
using Hilma.UBL.UnqualifiedDataTypes;

namespace Espd.Tests
{
    public class EspdDocumentHelper
    {
        public static QualificationApplicationRequest SCAbilitiesStaffSelfContainedRequest =>
            new QualificationApplicationRequest()
            {
                ULBVersionID = new IdentifierType() { Value= "2.2" },
                CustomizationID = new IdentifierType() { Value= "urn:www.cenbii.eu:transaction:biitrdm070:ver3.0" },
                ProfileID=new IdentifierType() {Value= "4.1" },
                ProfileExecutionID = new IdentifierType() {Value= "ESPD-EDMv2.1.0-SELFCONTAINED" },
                ID = new IdentifierType() {Value= "576ae724-f8e8-4b51-ae9c-2c2f4c90f433", SchemeID = "ISO/IEC 9834-8:2008 - 4UUID", SchemeAgencyID = "EU-COM-GROW", SchemeAgencyName = "DG GROW (European Commission)" },
                CopyIndicator=false,
                UUID = new IdentifierType() { Value= "7a186dda-ad3b-4c9d-9e1c-0b44c716b28e", SchemeID= "ISO/IEC 9834-8:2008 - 4UUID" },
                ContractFolderID = new IdentifierType() { Value= "__ProcurementProcedureFileRefNumber",SchemeAgencyID="TeD" },
                IssueDate = new DateType() { Value=System.DateTime.Parse("2019-01-23") },
                IssueTime= new TimeType() {Hour= 00, Minute=08,Second=33 },
                VersionID = new IdentifierType() { Value= "2018.01.01" },
                ProcedureCode = new CodeType() { Value= "OPEN",ListID= "ProcedureType",ListAgencyID= "EU-COM-OP" },
                QualificationApplicationTypeCode = new CodeType() {Value= "SELFCONTAINED" },
                WeightScoringMethodologyNote = new[] { new TextType() { Value = "__WeightingScoringMethodologyNote" } },
                WeightingTypeCode = new CodeType() {Value = "PERCENTAGE" },
                ContractingParty = new ContractingParty()
                {
                    PartyType = new PartyType()
                    {
                        WebsiteURI = "www.__Procurer.com",
                        PartyIdentification = new[]
                        {
                            new PartyIdentificationType() { ID = "GR153301872" }
                        },
                        PartyName = new PartyNameType()
                        {
                            Name = new NameType() { Value = "__ProcurerName" }
                        },
                        PostalAddress = new AddressType()
                        {
                            StreetName = new NameType() { Value = "__ProcurerStreet" },
                            CityName = new NameType() { Value = "__ProcurerCity" },
                            PostalZone = "12345",
                            Country = new CountryType()
                            {
                                IdentificationCode = new IdentifierType()
                                {
                                    SchemeVersionID = "1.0",
                                    SchemeAgencyID = "ISO",
                                    SchemeName = "CountryCodeIdentifier",
                                    SchemeID = "CountryCodeIdentifier",
                                    Value = "GR"
                                }
                            }
                        },
                        Contact = new ContactType()
                        {
                            Name = new NameType() { Value = "__ProcurerContactName" },
                            Telephone = "654321",
                            Telefax = "098765",
                            ElectronicMail = "__ProcurerContact@pr.com"
                        }
                    },

                },
                ProcurementProject = new ProcurementProject()
                {
                    Name = "__ProcurementProcedureTitle",
                    Description = "__ProcurementProcedureDescription",
                    ProcurementTypeCode = new CodeType()
                    {
                        Value = "COMBINED",
                        ListAgencyID = "EU-COM-OP",
                        ListID = "ProjectType",
                        ListVersionID = "listVersionID"
                    },
                    MainCommodityClassifications = new[]
                    {
                        new CommodityClassificationType()
                        {
                            ItemClassificationCode = new CodeType() { Value = "45463100-8" }
                        }
                    }
                },
                ProcurementProjectLots = new[] 
                {
                    new ProcurementProjectLot()
                    {
                        ID = "Lot1"
                    },
                    new ProcurementProjectLot()
                    {
                        ID = "Lot2"
                    },
                    new ProcurementProjectLot()
                    {
                        ID = "Lot3"
                    }
                },
                TenderingCriteria = new[]
                {
                    new TenderingCriterion()
                    {
                        Id = "6346959b-e097-4ea1-89cd-d1b4c131ea4d",
                        CriterionTypeCode = "CRITERION.SELECTION.TECHNICAL_PROFESSIONAL_ABILITY.MANAGEMENT.MANAGERIAL_STAFF",
                        Name =  "Number of managerial staff",
                        Description = new TextType[] { "The economic operator’s number of managerial staff for the last three years were as follows:" },
                        Legislations = new[]
                        {
                            new Legislation(){
                                Titles = new[] { new TextType() { Value = "Public Procurement Directive 2014/24/EU" } },
                                Descriptions = new[] { new TextType() { Value = "Directive 2014/24/EU of the European Parliament and of the Council of 26 February 2014 on public procurement and repealing Directive 2004/18/EC" } },
                                JurisdictionLevels = new[] { new TextType() { Value = "eu" } },
                                Articles = new[] { new TextType() { Value = "Article 58(4)" } },
                                URIs = new[] { new IdentifierType() { Value = "http://eur-lex.europa.eu/legal-content/EN/TXT/?uri=uriserv:OJ.L_.2014.094.01.0065.01.ENG" } }
                            }
                        },
                        TenderingCriterionPropertyGroups = new[]
                        {
                            new TenderingCriterionPropertyGroup()
                            {
                                Id = "7f7949a8-dbe6-496c-a9f6-6f05b8648bad",
                                PropertyGroupTypeCode = "ON*",
                                TenderingCriterionProperties = new[]
                                {
                                    new TenderingCriterionProperty()
                                    {
                                        Id = "2416716f-1d55-4a5a-8580-f8b5a33ca2c9",
                                        Description = "Minum number of years",
                                        TypeCode = "REQUIREMENT",
                                        ValueDataTypeCode = "QUANTITY_INTEGER",
                                        ExpectedValueNumeric = new NumericType() { Value = 3 }
                                    },
                                    new TenderingCriterionProperty()
                                    {
                                        Id = "da6558a0-0878-4662-99fd-a7040b139e02",
                                        Description = "Additional information",
                                        TypeCode = "REQUIREMENT",
                                        ValueDataTypeCode = "DESCRIPTION",
                                        ExpectedDescription = "Provide a sufficient description of the manageurial team."
                                    },
                                },
                                SubsidiaryTenderingCriterionPropertyGroups = new[]
                                {
                                    new TenderingCriterionPropertyGroup()
                                    {
                                        Id = "96defecc-7d32-4957-82e9-aad5f3c5b736",
                                        PropertyGroupTypeCode = "ON*",
                                        TenderingCriterionProperties = new[] {
                                            new TenderingCriterionProperty()
                                            {
                                                Id = "bd677a81-a394-44de-b7d2-8bf3be5991d8",
                                                Description = "Year",
                                                TypeCode = "QUESTION",
                                                ValueDataTypeCode = "QUANTITY_YEAR"
                                            },
                                            new TenderingCriterionProperty()
                                            {
                                                Id = "102375b8-881f-4bac-85d7-15f78e7a7895",
                                                Description = "Number",
                                                TypeCode = "QUESTION",
                                                ValueDataTypeCode = "QUANTITY_INTEGER"
                                            }
                                        }
                                    },
                                    new TenderingCriterionPropertyGroup()
                                    {
                                        Id = "7458d42a-e581-4640-9283-34ceb3ad4345",
                                        PropertyGroupTypeCode = "ON*",
                                        TenderingCriterionProperties = new[] {
                                            new TenderingCriterionProperty()
                                            {
                                                Id = "e4ba8c07-41c0-4caa-8f3f-ced8a264e0d8",
                                                Description = "Is this information available online?",
                                                TypeCode = "QUESTION",
                                                ValueDataTypeCode = "INDICATOR"
                                            }
                                        },
                                        SubsidiaryTenderingCriterionPropertyGroups = new[]
                                        {
                                            new TenderingCriterionPropertyGroup()
                                            {
                                                Id = "41dd2e9b-1bfd-44c7-93ee-56bd74a4334b",
                                                PropertyGroupTypeCode = "ONTRUE",
                                                TenderingCriterionProperties = new[] {
                                                    new TenderingCriterionProperty()
                                                    {
                                                        Id = "824db12c-9a09-49ad-8180-851190077ad7",
                                                        Description = "Evidence Supplied",
                                                        TypeCode = "QUESTION",
                                                        ValueDataTypeCode = "EVIDENCE_IDENTIFIER"
                                                    }
                                                },
                                            }
                                        }
                                    },
                                    new TenderingCriterionPropertyGroup()
                                    {
                                        Id = "96defecc-7d32-4957-82e9-aad5f3c5b736",
                                        PropertyGroupTypeCode = "ON*",
                                        TenderingCriterionProperties = new[] {
                                            new TenderingCriterionProperty()
                                            {
                                                Id = "0dcb85d0-9c7a-4dc3-b966-48dd8d00a4e4",
                                                Description = "Year",
                                                TypeCode = "QUESTION",
                                                ValueDataTypeCode = "QUANTITY_YEAR"
                                            },
                                            new TenderingCriterionProperty()
                                            {
                                                Id = "3995be99-c599-4049-a8e4-78d96a787fb1",
                                                Description = "Number",
                                                TypeCode = "QUESTION",
                                                ValueDataTypeCode = "QUANTITY_INTEGER"
                                            }
                                        },

                                    },
                                    new TenderingCriterionPropertyGroup()
                                    {
                                        Id = "96defecc-7d32-4957-82e9-aad5f3c5b736",
                                        PropertyGroupTypeCode = "ON*",
                                        TenderingCriterionProperties = new[] {
                                            new TenderingCriterionProperty()
                                            {
                                                Id = "783bb2c3-b354-45e4-a75e-0547393ce05a",
                                                Description = "Year",
                                                TypeCode = "QUESTION",
                                                ValueDataTypeCode = "QUANTITY_YEAR"
                                            },
                                            new TenderingCriterionProperty()
                                            {
                                                Id = "d9cd4ee1-c0f1-441a-8057-07ecba179266",
                                                Description = "Number",
                                                TypeCode = "QUESTION",
                                                ValueDataTypeCode = "QUANTITY_INTEGER"
                                            }
                                        },

                                    },
                                    new TenderingCriterionPropertyGroup()
                                    {
                                        Id = "7458d42a-e581-4640-9283-34ceb3ad4345",
                                        PropertyGroupTypeCode = "ON*",
                                        TenderingCriterionProperties = new[] {
                                            new TenderingCriterionProperty()
                                            {
                                                Id = "9c2b9ccd-02a4-4eca-b006-f699a949fb9b",
                                                Description = "Is this information available online?",
                                                TypeCode = "QUESTION",
                                                ValueDataTypeCode = "INDICATOR"
                                            }

                                        },
                                        SubsidiaryTenderingCriterionPropertyGroups = new[] {
                                            new TenderingCriterionPropertyGroup()
                                            {
                                                Id = "41dd2e9b-1bfd-44c7-93ee-56bd74a4334b",
                                                PropertyGroupTypeCode = "ONTRUE",
                                                TenderingCriterionProperties = new[]
                                                {
                                                    new TenderingCriterionProperty()
                                                    {
                                                        Id = "4fe907ea-e0ca-48a9-aae7-0afc5621be8a",
                                                        Description = "Evidence Supplied",
                                                        TypeCode = "QUESTION",
                                                        ValueDataTypeCode = "EVIDENCE_IDENTIFIER"
                                                    }
                                                }
                                            }
                                        },

                                    }

                                }
                            }
                        }

                    },

                },
            };

        public static QualificationApplicationRequest SimpleTest =>
            new QualificationApplicationRequest()
            {
                ID = "12345",
                TenderingCriteria = new[] 
                { 
                        new TenderingCriterion()
                        {
                             Id = "12323",
                             CriterionTypeCode = "FOO",
                             Description = new TextType[] { "Kuvaus" },
                             Legislations = new [] { 
                             new Legislation()
                             {
                                 ID = new IdentifierType("ecertis guid"),
                                 Descriptions = new TextType[]{ "Lakijuttuja"},
                                 Titles = new TextType[] { "Lakiperuste x." },
                               
                             }
                             },
                             TenderingCriterionPropertyGroups = new []
                             {
                             new TenderingCriterionPropertyGroup()
                             {
                                 Id = "123",
                                 Name = new[] { new NameType() { Value= "Ryhmä 1." }  },
                                 Description = new TextType [] { "Foo" },
                                 PropertyGroupTypeCode = "C0",
                                 TenderingCriterionProperties = new []{ new TenderingCriterionProperty()
                                 {
                                 Id = "221",
                                 Name = new NameType(){Value = "Kysymys x" },
                                 Description = new TextType(){Value= "Kuvaus" },
                                 TypeCode = "F",
                                 }}
                             }
                             }
                        }
                }
            };
    }
}
