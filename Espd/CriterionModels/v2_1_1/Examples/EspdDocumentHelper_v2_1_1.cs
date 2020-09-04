using System;
using Hilma.Espd.EDM.CriterionModels.v2_1_1.Identifiers;
using Hilma.UBL.CommonAggregateComponents;
using Hilma.UBL.UnqualifiedDataTypes;

namespace Hilma.Espd.EDM.CriterionModels.v2_1_1.Examples
{
    public class EspdDocumentHelper_v2_1_1
    {
        public static QualificationApplicationRequest ScAbilitiesStaffSelfContainedRequest =>
            new QualificationApplicationRequest
            {
                UBLVersionID = new IdentifierType { Value= "2.2", SchemeAgencyID= "OASIS-UBL-TC" },
                CustomizationID = new IdentifierType { Value= "urn:www.cenbii.eu:transaction:biitrdm070:ver3.0", SchemeVersionID="3.0", SchemeAgencyID = "CEN-BII" },
                ProfileID=new IdentifierType {Value= "4.1", SchemeAgencyID = "CEN-BII", SchemeVersionID = "2.0" },
                //ProfileExecutionID = ProfileExecutionId.Espd2_1_0SelfContained,
                ID = new IdentifierType {Value= "ESPDREQ-DGPE-f28dd0a52b", SchemeAgencyID = "DGPE" },
                CopyIndicator=false,
                UUID = new IdentifierType { Value = "9fb0fbb1-59a1-468c-95b1-046680f85ad3", SchemeAgencyID = "EU-COM-GROW", SchemeID = "ISO/IEC 9834-8:2008 - 4UUID", SchemeVersionID="2.0" },
                ContractFolderID = new IdentifierType { Value = "PP.20170419.1024-9", SchemeAgencyID = "DGPE" },
                IssueDate = new DateType { Value=DateTime.Parse("2019-12-10") },
                IssueTime= new TimeType {Hour= 08, Minute=32,Second=48 },
                VersionID = new IdentifierType { Value= "1.0", SchemeAgencyID= "EU-COM-GROW", SchemeVersionID="2.0" },
                ProcedureCode = new CodeType { Value= "AWARD_WO_PUB", ListID= "ProcedureType",ListAgencyID= "EU-COM-OP", ListVersionID="1.0" },
                QualificationApplicationTypeCode = new CodeType {Value= "Extended", ListID = "QualificationApplicationType" , ListAgencyID = "EU-COM-GROW", ListVersionID = "2.1.1" },
                //WeightScoringMethodologyNote = new[] {  "__WeightingScoringMethodologyNote" },
                //WeightingTypeCode = new CodeType {Value = "PERCENTAGE" },
                ContractingParty = new ContractingParty
                {
                    Party = new Party
                    {
                        WebsiteURI = new IdentifierType("www.Procurer.com"),
                        PartyIdentification = new[]
                        {
                            new PartyIdentification { ID = new IdentifierType("AD123456789") { SchemeAgencyID="EU-COM-GROW" } }
                        },
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
                //ProcurementProject = new ProcurementProject
                //{
                //    Name = "__ProcurementProcedureTitle",
                //    Description = "__ProcurementProcedureDescription",
                //    ProcurementTypeCode = new CodeType
                //    {
                //        Value = "COMBINED",
                //        ListAgencyID = "EU-COM-OP",
                //        ListID = "ProjectType",
                //        ListVersionID = "listVersionID"
                //    },
                //    MainCommodityClassifications = new[]
                //    {
                //        new CommodityClassification
                //        {
                //            ItemClassificationCode = new CodeType { Value = "45463100-8" }
                //        }
                //    }
                //},
                //ProcurementProjectLots = new[] 
                //{
                //    new ProcurementProjectLot
                //    {
                //        ID = new EuComGrowId("Lot1")
                //    },
                //    new ProcurementProjectLot
                //    {
                //        ID = new EuComGrowId("Lot2")
                //    },
                //    new ProcurementProjectLot
                //    {
                //        ID = new EuComGrowId("Lot3")
                //    }
                //},
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
