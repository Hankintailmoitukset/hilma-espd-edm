using System;
using Hilma.Espd.EDM.CriterionModels.v2_1_1.Identifiers;
using Hilma.UBL.CommonAggregateComponents;
using Hilma.UBL.UnqualifiedDataTypes;

namespace Hilma.Espd.EDM.CriterionModels.v2_1_1.Examples
{
    public class EspdDocumentHelper
    {
        public static QualificationApplicationRequest ScAbilitiesStaffSelfContainedRequest =>
            new QualificationApplicationRequest
            {
                UBLVersionID = new IdentifierType { Value= "2.2" },
                CustomizationID = new IdentifierType { Value= "urn:www.cenbii.eu:transaction:biitrdm070:ver3.0" },
                ProfileID=new IdentifierType {Value= "4.1" },
                ProfileExecutionID = ProfileExecutionId.Espd2_1_0SelfContained,
                ID = new IdentifierType {Value= "576ae724-f8e8-4b51-ae9c-2c2f4c90f433", SchemeID = "ISO/IEC 9834-8:2008 - 4UUID", SchemeAgencyID = "EU-COM-GROW", SchemeAgencyName = "DG GROW (European Commission)" },
                CopyIndicator=false,
                UUID = new IdentifierType { Value= "7a186dda-ad3b-4c9d-9e1c-0b44c716b28e", SchemeID= "ISO/IEC 9834-8:2008 - 4UUID" },
                ContractFolderID = new IdentifierType { Value= "__ProcurementProcedureFileRefNumber",SchemeAgencyID="TeD" },
                IssueDate = new DateType { Value=DateTime.Parse("2019-01-23") },
                IssueTime= new TimeType {Hour= 00, Minute=08,Second=33 },
                VersionID = new IdentifierType { Value= "2018.01.01" },
                ProcedureCode = new CodeType { Value= "OPEN",ListID= "ProcedureType",ListAgencyID= "EU-COM-OP" },
                QualificationApplicationTypeCode = new CodeType {Value= "SELFCONTAINED" },
                WeightScoringMethodologyNote = new[] {  "__WeightingScoringMethodologyNote" },
                WeightingTypeCode = new CodeType {Value = "PERCENTAGE" },
                ContractingParty = new ContractingParty
                {
                    Party = new Party
                    {
                        WebsiteURI = new IdentifierType("www.__Procurer.com"),
                        PartyIdentification = new PartyIdentification { ID = new IdentifierType("GR153301872") { SchemeAgencyID="VIES-AEAT" }},
                        PartyName = new PartyName
                        {
                            Name = "__ProcurerName"
                        },
                        PostalAddress = new Address
                        {
                            StreetName = "__ProcurerStreet",
                            CityName =  "__ProcurerCity" ,
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
                            Name = "__ProcurerContactName" ,
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
                        ListVersionID = "listVersionID"
                    },
                    MainCommodityClassifications = new[]
                    {
                        new CommodityClassification
                        {
                            ItemClassificationCode = new CodeType { Value = "45463100-8" }
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
                        CriterionTypeCode = new CriterionTypeCode("CRITERION.SELECTION.TECHNICAL_PROFESSIONAL_ABILITY.MANAGEMENT.MANAGERIAL_STAFF"),
                        Name =  "Number of managerial staff",
                        Description = new[] { "The economic operator’s number of managerial staff for the last three years were as follows:" },
                        Legislations = new[]
                        {
                            new Legislation
                            {
                                Title = "Public Procurement Directive 2014/24/EU",
                                Description = "Directive 2014/24/EU of the European Parliament and of the Council of 26 February 2014 on public procurement and repealing Directive 2004/18/EC",
                                JurisdictionLevel = "eu",
                                Article = "Article 58(4)",
                                URI = new IdentifierType( "http://eur-lex.europa.eu/legal-content/EN/TXT/?uri=uriserv:OJ.L_.2014.094.01.0065.01.ENG")
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
                                        TypeCode = new CriterionElementType("REQUIEMENT"),
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
                                        TenderingCriterionProperties = new[] {
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
                                        TenderingCriterionProperties = new[] {
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
                                                TenderingCriterionProperties = new[] {
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
                                        TenderingCriterionProperties = new[] {
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
                                        TenderingCriterionProperties = new[] {
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
                                        TenderingCriterionProperties = new[] {
                                            new TenderingCriterionProperty
                                            {
                                                ID = new CriteriaTaxonomyIdentifier("9c2b9ccd-02a4-4eca-b006-f699a949fb9b"),
                                                Description = "Is this information available online?",
                                                TypeCode = CriterionElementType.Question,
                                                ValueDataTypeCode = ResponseDataTypeCode.Indicator
                                            }

                                        },
                                        SubsidiaryTenderingCriterionPropertyGroups = new[] {
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

        public static QualificationApplicationRequest SimpleTest =>
            new QualificationApplicationRequest
            {
                ID = new CriteriaTaxonomyIdentifier("12345"),
                TenderingCriteria = new[] 
                { 
                        new TenderingCriterion
                        {
                             ID = new CriteriaTaxonomyIdentifier("12323"),
                             CriterionTypeCode = new CriterionTypeCode("FOO"),
                             Description = new[] { "Kuvaus" },
                             Legislations = new [] { 
                             new Legislation
                             {
                                 ID = new IdentifierType("ecertis guid"),
                                 Description ="Lakijuttuja",
                                 Title = "Lakiperuste x."
                             }
                             },
                             TenderingCriterionPropertyGroups = new []
                             {
                             new TenderingCriterionPropertyGroup
                             {
                                 ID = new CriteriaTaxonomyIdentifier("123"), 
                                 Description = new [] { "Foo" },
                                 PropertyGroupTypeCode = new PropertyGroupTypeCode("C0"),
                                 TenderingCriterionProperties = new []{ 
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

        public static QualificationApplicationRequest CriteriaTaxonomyExtendedV2_1_1 =>
            new QualificationApplicationRequest
            {
                UBLVersionID = new IdentifierType { Value = "2.2", SchemeAgencyID = "OASIS-UBL-TC" },
                CustomizationID = new IdentifierType { Value = "urn:www.cenbii.eu:transaction:biitrdm070:ver3.0", SchemeVersionID = "3.0", SchemeAgencyID = "CEN-BII" },
                ProfileID = new IdentifierType { Value = "4.1", SchemeAgencyID = "CEN-BII", SchemeVersionID = "2.0" },
                ID = new IdentifierType { Value = "ESPDREQ-DGPE-f28dd0a52b", SchemeAgencyID = "DGPE" },
                CopyIndicator = false,
                UUID = new IdentifierType { Value = "9fb0fbb1-59a1-468c-95b1-046680f85ad3", SchemeAgencyID = "EU-COM-GROW", SchemeID = "ISO/IEC 9834-8:2008 - 4UUID", SchemeVersionID = "2.0" },
                ContractFolderID = new IdentifierType { Value = "PP.20170419.1024-9", SchemeAgencyID = "DGPE" },
                IssueDate = new DateType { Value = DateTime.Parse("2019-12-10") },
                IssueTime = new TimeType { Hour = 08, Minute = 32, Second = 48 },
                VersionID = new IdentifierType { Value = "1.0", SchemeAgencyID = "EU-COM-GROW", SchemeVersionID = "2.0" },
                ProcedureCode = new CodeType { Value = "AWARD_WO_PUB", ListID = "ProcedureType", ListAgencyID = "EU-COM-OP", ListVersionID = "1.0" },
                QualificationApplicationTypeCode = new CodeType { Value = "Extended", ListID = "QualificationApplicationType", ListAgencyID = "EU-COM-GROW", ListVersionID = "2.1.1" },
                ContractingParty = new ContractingParty
                {
                    Party = new Party
                    {
                        WebsiteURI = new IdentifierType("www.Procurer.com"),
                        PartyIdentification = new PartyIdentification { ID = new IdentifierType("AD123456789") { SchemeAgencyID="EU-COM-GROW" } },
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
                    new TenderingCriterion
                    {
                        ID = new CriteriaTaxonomyIdentifier("005eb9ed-1347-4ca3-bb29-9bc0db64e1ab"),
                        CriterionTypeCode = new CriterionTypeCode("CRITERION.EXCLUSION.CONVICTIONS.PARTICIPATION_IN_CRIMINAL_ORGANISATION"),
                        Name =  "Participation in a criminal organisation",
                        Description = new[] { "Has the economic operator itself or any person who is a member of its administrative, management or supervisory body or has powers of representation, decision or control therein been the subject of a conviction by final judgment for participation in a criminal organisation, by a conviction rendered at the most five years ago or in which an exclusion period set out directly in the conviction continues to be applicable? As defined in Article 2 of Council Framework Decision 2008/841/JHA of 24 October 2008 on the fight against organised crime (OJ L 300, 11.11.2008, p. 42)." },
                        Legislations = new[]
                        {
                            new Legislation
                            {
                                Title = "[Legislation title]",
                                Description = "[Legislation description]",
                                JurisdictionLevel = "EU",
                                Article = "[Article, e.g. Article 2.I.a]",
                                URI = new IdentifierType( "http://eur-lex.europa.eu/"),
                                Languages = new Language[]
                                {
                                    new Language(){
                                        LocaleCode= new CodeType(){
                                            Value ="EN",
                                            ListID="LanguageCodeEU",
                                            ListAgencyName="EU-COM-GROW",
                                            ListVersionID="2.1.1" }
                                    }
                                }

                             }
                        },
                        TenderingCriterionPropertyGroups = new[]
                        {
                            new TenderingCriterionPropertyGroup
                            {
                                ID = new CriteriaTaxonomyIdentifier("7c637c0c-7703-4389-ba52-02997a055bd7"){SchemeID="CriteriaTaxonomy", SchemeAgencyID="EU-COM-GROW", SchemeVersionID="2.1.1"},
                                PropertyGroupTypeCode = new PropertyGroupTypeCode("ON*"){ListID="PropertyGroupType", ListAgencyID="EU-COM-GROW", ListVersionID="2.1.1"},
                                TenderingCriterionProperties = new[]
                                {
                                    new TenderingCriterionProperty
                                    {
                                        ID = new CriteriaTaxonomyIdentifier("c249d5bb-f2fd-4fb2-b7ce-580b24dbb3a6"){SchemeID="CriteriaTaxonomy", SchemeAgencyID="EU-COM-GROW", SchemeVersionID="2.1.1"},
                                        Description = "Your answer",
                                        TypeCode = CriterionElementType.Question,
                                        ValueDataTypeCode = new ResponseDataTypeCode("INDICATOR"){ListID="ResponseDataType", ListAgencyID="EU-COM-GROW", ListVersionID="2.1.1" },
                                    }
                                },
                                SubsidiaryTenderingCriterionPropertyGroups = new[]
                                {
                                    new TenderingCriterionPropertyGroup
                                    {
                                        ID = new CriteriaTaxonomyIdentifier("f5276600-a2b6-4ff6-a90e-b31fe19dae41"){SchemeID="EU-COM-GROW", SchemeAgencyID="EU-COM-GROW", SchemeVersionID="2.1.1"},
                                        PropertyGroupTypeCode = new PropertyGroupTypeCode("ONTRUE"){ListID="PropertyGroupType", ListAgencyID="EU-COM-GROW", ListVersionID="2.1.1"},
                                        TenderingCriterionProperties = new[] {
                                            new TenderingCriterionProperty
                                            {
                                                ID = new CriteriaTaxonomyIdentifier("cedcff3e-779e-4b65-9686-4b1125bd4e34"),
                                                Description = "Date of conviction",
                                                TypeCode = CriterionElementType.Question,
                                                ValueDataTypeCode = new ResponseDataTypeCode("DATE"){ListID="ResponseDataType", ListAgencyID="EU-COM-GROW", ListVersionID="2.1.1"}
                                            },
                                            new TenderingCriterionProperty
                                            {
                                                ID = new CriteriaTaxonomyIdentifier("55197300-b699-4fdd-99a6-995d2efa8851"){ SchemeID="CriteriaTaxonomy", SchemeAgencyID="EU-COM-GROW", SchemeVersionID="2.1.1"},
                                                Description = "Reason",
                                                TypeCode = CriterionElementType.Question,
                                                ValueDataTypeCode = new ResponseDataTypeCode("DESCRIPTION"){ListID="ResponseDataType", ListAgencyID="EU-COM-GROW", ListVersionID="2.1.1"}
                                            },
                                            new TenderingCriterionProperty
                                            {
                                                ID = new CriteriaTaxonomyIdentifier("674dd860-48a8-4a06-a75b-eee03c0292c4"){ SchemeID="CriteriaTaxonomy", SchemeAgencyID="EU-COM-GROW", SchemeVersionID="2.1.1"},
                                                Description = "Who has been convicted",
                                                TypeCode = CriterionElementType.Question,
                                                ValueDataTypeCode = new ResponseDataTypeCode("DESCRIPTION"){ListID="ResponseDataType", ListAgencyID="EU-COM-GROW", ListVersionID="2.1.1"}
                                            },
                                            new TenderingCriterionProperty
                                            {
                                                ID = new CriteriaTaxonomyIdentifier("c4bba136-df2b-47d3-afd0-461b13d0fb06"){ SchemeID="CriteriaTaxonomy", SchemeAgencyID="EU-COM-GROW", SchemeVersionID="2.1.1"},
                                                Description = "Length of the period of exclusion",
                                                TypeCode = CriterionElementType.Question,
                                                ValueDataTypeCode = new ResponseDataTypeCode("PERIOD"){ListID="ResponseDataType", ListAgencyID="EU-COM-GROW", ListVersionID="2.1.1"}
                                            }
                                        },
                                        SubsidiaryTenderingCriterionPropertyGroups = new TenderingCriterionPropertyGroup[]
                                        {
                                            new TenderingCriterionPropertyGroup
                                            {
                                                ID = new CriteriaTaxonomyIdentifier("5f9f09f7-f701-432c-9fdc-c22c124a74c9"){SchemeID="CriteriaTaxonomy", SchemeAgencyID="EU-COM-GROW", SchemeVersionID="2.1.1"},
                                                PropertyGroupTypeCode = new PropertyGroupTypeCode("ON*"){ListID="PropertyGroupType", ListAgencyID="EU-COM-GROW", ListVersionID="2.1.1"},
                                                TenderingCriterionProperties = new[] {
                                                    new TenderingCriterionProperty
                                                    {
                                                        ID = new CriteriaTaxonomyIdentifier("39257e2e-f689-4c7d-929f-d6bdd9c4f799"){ SchemeID="CriteriaTaxonomy", SchemeAgencyID="EU-COM-GROW", SchemeVersionID="2.1.1"},
                                                        Description = "Have you taken measures to demonstrate your reliability (Self-Cleaning)?",
                                                        TypeCode = CriterionElementType.Question,
                                                        ValueDataTypeCode = new ResponseDataTypeCode("INDICATOR"){ListID="ResponseDataType", ListAgencyID="EU-COM-GROW", ListVersionID="2.1.1"}
                                                    }
                                                },
                                                SubsidiaryTenderingCriterionPropertyGroups = new TenderingCriterionPropertyGroup[]
                                                {
                                                    new TenderingCriterionPropertyGroup
                                                    {
                                                        ID = new CriteriaTaxonomyIdentifier("74e6c7b4-757b-4b40-ada6-fad6a997c310"){SchemeID="CriteriaTaxonomy", SchemeAgencyID="EU-COM-GROW", SchemeVersionID="2.1.1"},
                                                        PropertyGroupTypeCode = new PropertyGroupTypeCode("ONTRUE"){ListID="PropertyGroupType", ListAgencyID="EU-COM-GROW", ListVersionID="2.1.1"},
                                                        TenderingCriterionProperties = new[] {
                                                            new TenderingCriterionProperty
                                                            {
                                                                ID = new CriteriaTaxonomyIdentifier("acf283ed-86c0-4227-a9f5-deb27a45d3b1"){ SchemeID="CriteriaTaxonomy", SchemeAgencyID="EU-COM-GROW", SchemeVersionID="2.1.1"},
                                                                Description = "Please describe them",
                                                                TypeCode = CriterionElementType.Question,
                                                                ValueDataTypeCode = new ResponseDataTypeCode("DESCRIPTION"){ListID="ResponseDataType", ListAgencyID="EU-COM-GROW", ListVersionID="2.1.1"}
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
                    }
                }
            };
    }
}
