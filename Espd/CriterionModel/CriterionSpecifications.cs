using Hilma.UBL.CommonAggregateComponents;
using Hilma.UBL.UnqualifiedDataTypes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Espd.CriterionModel
{
    public static class CriterionSpecifications
    {
        public static ExclusionGroundsSpecification Exclusion { get; set; }

        public static SelectionGroundsSpecification Selection { get; set; }

    }

    public class ExclusionGroundsSpecification
    {
        public TenderingCriterion[] Convictions { get; set; } = new[]
        {
            new TenderingCriterion()
            {
                Name="convictions.participationInCriminalOrganisation.name",
                Description = new TextType[]{ "convictions.participationInCriminalOrganisation.description" },
                Id ="e6b21867-95b5-4549-8180-f4673219b179",
                Legislations = new Legislation[]{},
                TenderingCriterionPropertyGroups = CriterionHelper.ConvictionsQuestionGroup
            },
            new TenderingCriterion()
            {
                Name="convictions.corruption.name",
                Description = new TextType[]{ "convictions.corruption.description" },
                Id ="e6b21867-95b5-4549-8180-f4673219b179",
                
                Legislations = new Legislation[]{},
                TenderingCriterionPropertyGroups = CriterionHelper.ConvictionsQuestionGroup
            },
            new TenderingCriterion()
            {
                Name="convictions.fraud.name",
                Description = new TextType[]{ "convictions.fraud.description" },
                Id ="297d2323-3ede-424e-94bc-a91561e6f320",
               
                Legislations = new Legislation[]{},
                TenderingCriterionPropertyGroups = CriterionHelper.ConvictionsQuestionGroup
            },
            new TenderingCriterion()
            {
                Name="convictions.TerroristActivities.name",
                Description = new TextType[]{ "convictions.TerroristActivities.description" },
                Id ="d486fb70-86b3-4e75-97f2-0d71b5697c7d",
                Legislations = new Legislation[]{},
                TenderingCriterionPropertyGroups = CriterionHelper.ConvictionsQuestionGroup
            },
            new TenderingCriterion()
            {
                Name="convictions.moneyLaundering.name",
                Description = new TextType[]{ "convictions.moneyLaundering.description" },
                Id ="47112079-6fec-47a3-988f-e561668c3aef",               
                Legislations = new Legislation[]{},
                TenderingCriterionPropertyGroups = CriterionHelper.ConvictionsQuestionGroup
            },
            new TenderingCriterion()
            {
                Name="convictions.childLabour.name",
                Description = new TextType[]{ "convictions.childLabour.description" },
                Id =" d789d01a-fe03-4ccd-9898-73f9cfa080d1",                
                Legislations = new Legislation[]{},
                TenderingCriterionPropertyGroups = CriterionHelper.ConvictionsQuestionGroup
            },

        };

        public TenderingCriterion[] Contributions { get; set; } = new[]
        {
           new TenderingCriterion()
           {
               Name="contributions.paymentOfTaxes.name",
               Description = new TextType[]{ "contributions.paymentOfTaxes.description" },
               Id ="e6b21867-95b5-4549-8180-f4673219b179",
               Legislations = new Legislation[]{},
               TenderingCriterionPropertyGroups = new TenderingCriterionPropertyGroup[]
               {

                   new TenderingCriterionPropertyGroup()
                   {
                       Id="53c9aad8-dc80-48f8-85d9-755c2aab8e95",
                       PropertyGroupTypeCode ="ON*",
                       TenderingCriterionProperties = new TenderingCriterionProperty[]
                       {
                           new TenderingCriterionProperty()
                           {
                             Description ="contributions.threshold.description",
                             ValueDataTypeCode ="AMOUNT"
                           },
                           new TenderingCriterionProperty()
                           {
                             Description ="contributions.additionalInformation.description",
                             ValueDataTypeCode ="DESCRIPTION"
                           },

                       },
                       SubsidiaryTenderingCriterionPropertyGroups = new TenderingCriterionPropertyGroup[]
                       {

                           new TenderingCriterionPropertyGroup()
                           {
                                Id ="098fd3cc-466e-4233-af1a-affe09471bce",
                                PropertyGroupTypeCode ="ON*",
                                TenderingCriterionProperties = new TenderingCriterionProperty[]
                                {
                                   new TenderingCriterionProperty()
                                   {
                                     Description ="common.yourAnswer.description",
                                     ValueDataTypeCode ="INDICATOR"
                                   },

                                },
                                SubsidiaryTenderingCriterionPropertyGroups = new TenderingCriterionPropertyGroup[]
                                {
                                    new TenderingCriterionPropertyGroup()
                                    {
                                        Id ="f8499787-f9f8-4355-95e2-9784426f4d7b",
                                        PropertyGroupTypeCode="ONTRUE",
                                        TenderingCriterionProperties = new TenderingCriterionProperty[]
                                        {
                                            new TenderingCriterionProperty()
                                            {
                                                 Description ="common.CountryOrMemberStateConcerned.description",
                                                 ValueDataTypeCode ="CODE_COUNTRY"
                                            },
                                            new TenderingCriterionProperty()
                                            {
                                                 Description ="common.amountConcerned.description",
                                                 ValueDataTypeCode ="AMOUNT"
                                            },

                                        },
                                        SubsidiaryTenderingCriterionPropertyGroups = new TenderingCriterionPropertyGroup[]
                                        {
                                            new TenderingCriterionPropertyGroup()
                                            {
                                                Id ="7c2aec9f-4876-4c33-89e6-2ab6d6cf5d02",
                                                PropertyGroupTypeCode="ON*",
                                                TenderingCriterionProperties = new TenderingCriterionProperty[]
                                                {
                                                    new TenderingCriterionProperty()
                                                    {
                                                         Description ="Has this breach of obligations been established by means other than a judicial or administrative decision?",
                                                         ValueDataTypeCode ="INDICATOR"
                                                    }
                                                },
                                                SubsidiaryTenderingCriterionPropertyGroups = new TenderingCriterionPropertyGroup[]
                                                {
                                                     new TenderingCriterionPropertyGroup()
                                                     {
                                                         Id =" 80633323-a7b6-4206-9728-e4534eaad8b2",
                                                         PropertyGroupTypeCode="ONTRUE",
                                                         TenderingCriterionProperties = new TenderingCriterionProperty[]
                                                            {
                                                                new TenderingCriterionProperty()
                                                                {
                                                                     Description ="contributions.pleaseDescribeWhichMeansWereUsed.description",
                                                                     ValueDataTypeCode ="DESCRIPTION"
                                                                }
                                                            },
                                                     },
                                                     new TenderingCriterionPropertyGroup()
                                                     {
                                                         Id ="a49e6e25-0059-47da-9397-72c2db5fd5b1",
                                                         PropertyGroupTypeCode="ON*",
                                                         TenderingCriterionProperties = new TenderingCriterionProperty[]
                                                            {
                                                                new TenderingCriterionProperty()
                                                                {
                                                                     Description ="contributions.hasTheEconomicOperatorFulfilled.description",
                                                                     ValueDataTypeCode ="INDICATOR"
                                                                }
                                                            },
                                                         SubsidiaryTenderingCriterionPropertyGroups = new TenderingCriterionPropertyGroup[]
                                                         {
                                                                 new TenderingCriterionPropertyGroup()
                                                                 {
                                                                     Id ="42a44eb9-b8c9-4a67-8776-e77fc5356efe",
                                                                     PropertyGroupTypeCode="ONTRUE",
                                                                     TenderingCriterionProperties = new TenderingCriterionProperty[]
                                                                        {
                                                                            new TenderingCriterionProperty()
                                                                            {
                                                                                 Description ="common.pleaseDescribeThem.description",
                                                                                 ValueDataTypeCode ="DESCRIPTION"
                                                                            }
                                                                     },
                                                                 }
                                                         }
                                                     },
                                                     new TenderingCriterionPropertyGroup()
                                                     {
                                                        Id ="536417dc-8130-4981-85c5-fceba5541c58",
                                                         PropertyGroupTypeCode="ONFALSE",
                                                         TenderingCriterionProperties = new TenderingCriterionProperty[]
                                                            {
                                                                new TenderingCriterionProperty()
                                                                {
                                                                     Description ="contributions.ifThisBreachOfObligationsWas.description",
                                                                     ValueDataTypeCode ="INDICATOR"
                                                                }
                                                            },
                                                         SubsidiaryTenderingCriterionPropertyGroups = new TenderingCriterionPropertyGroup[]
                                                         {
                                                                 new TenderingCriterionPropertyGroup()
                                                                 {
                                                                     Id =" 8aaac22d-1b59-442e-9210-a6e70ec05962",
                                                                     PropertyGroupTypeCode="ONTRUE",
                                                                     TenderingCriterionProperties = new TenderingCriterionProperty[]
                                                                     {
                                                                            new TenderingCriterionProperty()
                                                                            {
                                                                                 Description ="contributions.pleaseIindicateTheDateOfConvictionOrDecision.description",
                                                                                 ValueDataTypeCode ="DATE"
                                                                            },
                                                                             new TenderingCriterionProperty()
                                                                            {
                                                                                 Description ="contributions.inCaseOfAConviction.description",
                                                                                 ValueDataTypeCode ="PERIOD"
                                                                            }
                                                                     },
                                                                 }
                                                         }
                                                     }
                                                },

                                            },
                                            }

                                        }

                                    },
                                },

                           new TenderingCriterionPropertyGroup(){

                               Id ="9026e403-3eb6-4705-a9e9-e21a1efc867d",
                               PropertyGroupTypeCode="ON*",
                               TenderingCriterionProperties = new TenderingCriterionProperty[]
                                  {
                                      new TenderingCriterionProperty()
                                      {
                                           Description ="common.informationAvailableFromEUDb.description",
                                           ValueDataTypeCode ="INDICATOR"
                                      }
                               },
                               SubsidiaryTenderingCriterionPropertyGroups = CriterionHelper.TenderingCriterionURLGroup

                           }

                       },
                   }
               }
           },
           new TenderingCriterion()
           {
               Name="contributions.paymentOfSocialSecurityContributions.name",
               Description = new TextType[]{ "contributions.paymentOfSocialSecurityContributions.description" },
               Id ="7d85e333-bbab-49c0-be8d-c36d71a72f5e",
               Legislations = new Legislation[]{},
               TenderingCriterionPropertyGroups = new TenderingCriterionPropertyGroup[]
               {

                   new TenderingCriterionPropertyGroup()
                   {
                       Id="53c9aad8-dc80-48f8-85d9-755c2aab8e95",
                       PropertyGroupTypeCode ="ON*",
                       TenderingCriterionProperties = new TenderingCriterionProperty[]
                       {
                           new TenderingCriterionProperty()
                           {
                             Description ="contributions.threshold.description",
                             ValueDataTypeCode ="AMOUNT"
                           },
                           new TenderingCriterionProperty()
                           {
                             Description ="contributions.additionalInformation.description",
                             ValueDataTypeCode ="DESCRIPTION"
                           },

                       },
                       SubsidiaryTenderingCriterionPropertyGroups = new TenderingCriterionPropertyGroup[]
                       {

                           new TenderingCriterionPropertyGroup()
                           {
                                Id ="098fd3cc-466e-4233-af1a-affe09471bce",
                                PropertyGroupTypeCode ="ON*",
                                TenderingCriterionProperties = new TenderingCriterionProperty[]
                                {
                                   new TenderingCriterionProperty()
                                   {
                                     Description ="common.yourAnswer.description",
                                     ValueDataTypeCode ="INDICATOR"
                                   },

                                },
                                SubsidiaryTenderingCriterionPropertyGroups = new TenderingCriterionPropertyGroup[]
                                {
                                    new TenderingCriterionPropertyGroup()
                                    {
                                        Id ="f8499787-f9f8-4355-95e2-9784426f4d7b",
                                        PropertyGroupTypeCode="ONTRUE",
                                        TenderingCriterionProperties = new TenderingCriterionProperty[]
                                        {
                                            new TenderingCriterionProperty()
                                            {
                                                 Description ="common.CountryOrMemberStateConcerned.description",
                                                 ValueDataTypeCode ="CODE_COUNTRY"
                                            },
                                            new TenderingCriterionProperty()
                                            {
                                                 Description ="common.amountConcerned.description",
                                                 ValueDataTypeCode ="AMOUNT"
                                            },

                                        },
                                        SubsidiaryTenderingCriterionPropertyGroups = new TenderingCriterionPropertyGroup[]
                                        {
                                            new TenderingCriterionPropertyGroup()
                                            {
                                                Id ="7c2aec9f-4876-4c33-89e6-2ab6d6cf5d02",
                                                PropertyGroupTypeCode="ON*",
                                                TenderingCriterionProperties = new TenderingCriterionProperty[]
                                                {
                                                    new TenderingCriterionProperty()
                                                    {
                                                         Description ="contributions.hasThisBreachOfObligations.description",
                                                         ValueDataTypeCode ="INDICATOR"
                                                    }
                                                },
                                                SubsidiaryTenderingCriterionPropertyGroups = new TenderingCriterionPropertyGroup[]
                                                {
                                                     new TenderingCriterionPropertyGroup()
                                                     {
                                                         Id =" 80633323-a7b6-4206-9728-e4534eaad8b2",
                                                         PropertyGroupTypeCode="ONTRUE",
                                                         TenderingCriterionProperties = new TenderingCriterionProperty[]
                                                            {
                                                                new TenderingCriterionProperty()
                                                                {
                                                                     Description ="contributions.pleaseDescribeWhichMeansWereUsed.description",
                                                                     ValueDataTypeCode ="DESCRIPTION"
                                                                }
                                                            },
                                                     },
                                                     new TenderingCriterionPropertyGroup()
                                                     {
                                                         Id ="a49e6e25-0059-47da-9397-72c2db5fd5b1",
                                                         PropertyGroupTypeCode="ON*",
                                                         TenderingCriterionProperties = new TenderingCriterionProperty[]
                                                            {
                                                                new TenderingCriterionProperty()
                                                                {
                                                                     Description ="contributions.hasTheEconomicOperatorFulfilled.description",
                                                                     ValueDataTypeCode ="INDICATOR"
                                                                }
                                                            },
                                                         SubsidiaryTenderingCriterionPropertyGroups = new TenderingCriterionPropertyGroup[]
                                                         {
                                                                 new TenderingCriterionPropertyGroup()
                                                                 {
                                                                     Id ="42a44eb9-b8c9-4a67-8776-e77fc5356efe",
                                                                     PropertyGroupTypeCode="ONTRUE",
                                                                     TenderingCriterionProperties = new TenderingCriterionProperty[]
                                                                        {
                                                                            new TenderingCriterionProperty()
                                                                            {
                                                                                 Description ="common.pleaseDescribeThem.description",
                                                                                 ValueDataTypeCode ="DESCRIPTION"
                                                                            }
                                                                     },
                                                                 }
                                                         }
                                                     },
                                                     new TenderingCriterionPropertyGroup()
                                                     {
                                                        Id ="536417dc-8130-4981-85c5-fceba5541c58",
                                                         PropertyGroupTypeCode="ONFALSE",
                                                         TenderingCriterionProperties = new TenderingCriterionProperty[]
                                                            {
                                                                new TenderingCriterionProperty()
                                                                {
                                                                     Description ="contributions.ifThisBreachOfObligationsWas.description",
                                                                     ValueDataTypeCode ="INDICATOR"
                                                                }
                                                            },
                                                         SubsidiaryTenderingCriterionPropertyGroups = new TenderingCriterionPropertyGroup[]
                                                         {
                                                                 new TenderingCriterionPropertyGroup()
                                                                 {
                                                                     Id =" 8aaac22d-1b59-442e-9210-a6e70ec05962",
                                                                     PropertyGroupTypeCode="ONTRUE",
                                                                     TenderingCriterionProperties = new TenderingCriterionProperty[]
                                                                     {
                                                                            new TenderingCriterionProperty()
                                                                            {
                                                                                 Description ="contributions.pleaseIindicateTheDateOfConvictionOrDecision.description",
                                                                                 ValueDataTypeCode ="DATE"
                                                                            },
                                                                             new TenderingCriterionProperty()
                                                                            {
                                                                                 Description ="contributions.inCaseOfAConviction.description",
                                                                                 ValueDataTypeCode ="PERIOD"
                                                                            }
                                                                     },
                                                                 }
                                                         }
                                                     }
                                                },

                                            },
                                            }

                                        }

                                    },
                                },

                           new TenderingCriterionPropertyGroup(){

                               Id ="9026e403-3eb6-4705-a9e9-e21a1efc867d",
                               PropertyGroupTypeCode="ON*",
                               TenderingCriterionProperties = new TenderingCriterionProperty[]
                               {
                                  new TenderingCriterionProperty()
                                  {
                                       Description ="common.informationAvailableFromEUDb.description",
                                       ValueDataTypeCode ="INDICATOR"
                                  }
                               },
                               SubsidiaryTenderingCriterionPropertyGroups = CriterionHelper.TenderingCriterionURLGroup
                           }

                           },
                       }
                   }

           }

        };


        public TenderingCriterion[] Social { get; set; } = new[]
        {
            new TenderingCriterion()
            {
               Name="social.environmentalLaw.name",
               Description = new TextType[]{ "social.environmentalLaw.description" },
               Id ="a80ddb62-d25b-4e4e-ae22-3968460dc0a9",
               Legislations = new Legislation[]{},
               TenderingCriterionPropertyGroups = CriterionHelper.Social_LawCriterionPropertyGroups,
               
            },
            new TenderingCriterion()
            {
               Name="social.socialLaw.name",
               Description = new TextType[]{ "social.socialLaw.description" },
               Id ="a261a395-ed17-4939-9c75-b9ff1109ca6e",
               Legislations = new Legislation[]{},
               TenderingCriterionPropertyGroups = CriterionHelper.Social_LawCriterionPropertyGroups
            },
            new TenderingCriterion()
            {
               Name="social.labourLaw.name",
               Description = new TextType[]{ "social.labourLaw.description" },
               Id ="a34b70d6-c43d-4726-9a88-8e2b438424bf",
               Legislations = new Legislation[]{},
               TenderingCriterionPropertyGroups = CriterionHelper.Social_LawCriterionPropertyGroups
            }
        };

        public TenderingCriterion[] Business { get; set; } = new[]
        {

            new TenderingCriterion()
            {
               Name="business.bankruptcy.name",
               Description = new TextType[]{ "business.bankruptcy.description" },
               Id ="d3732c09-7d62-4edc-a172-241da6636e7c",
               Legislations = new Legislation[]{},
               TenderingCriterionPropertyGroups = CriterionHelper.Business
            },
            new TenderingCriterion()
            {
               Name="business.insolvency.name",
               Description = new TextType[]{ "business.insolvency.description" },
               Id ="396f288a-e267-4c20-851a-ed4f7498f137",
               Legislations = new Legislation[]{},
               TenderingCriterionPropertyGroups = CriterionHelper.Business
            },
            new TenderingCriterion()
            {
               Name="business.arrangementWithCreditors.name",
               Description = new TextType[]{ "business.arrangementWithCreditors.description" },
               Id ="68918c7a-f5bc-4a1a-a62f-ad8983600d48",
               Legislations = new Legislation[]{},
               TenderingCriterionPropertyGroups = CriterionHelper.Business
            },
            new TenderingCriterion()
            {
               Name="business.analogousSituationLikeBankruptcyUnderNationalLaw.name",
               Description = new TextType[]{ "business.analogousSituationLikeBankruptcyUnderNationalLaw.description" },
               Id ="daffa2a9-9f8f-4568-8be8-7b8bf306d096",
               Legislations = new Legislation[]{},
               TenderingCriterionPropertyGroups = CriterionHelper.Business
            },
            new TenderingCriterion()
            {
               Name="business.assetsBeingAdministeredByLiquidator.name",
               Description = new TextType[]{ "business.assetsBeingAdministeredByLiquidator.description" },
               Id ="8fda202a-0c37-41bb-9d7d-de3f49edbfcb",
               Legislations = new Legislation[]{},
               TenderingCriterionPropertyGroups = CriterionHelper.Business
            },
            new TenderingCriterion()
            {
               Name="business.businessActivitiesAreSuspended.name",
               Description = new TextType[]{ "business.businessActivitiesAreSuspended.description" },
               Id ="166536e2-77f7-455c-b018-70582474e4f6",
               Legislations = new Legislation[]{},
               TenderingCriterionPropertyGroups = CriterionHelper.Business
            }

        };

        public TenderingCriterion[] Misconduct { get; set; } = new[]
        {
            new TenderingCriterion()
            {
               Name="misconduct.guiltyOfGraveProfessionalMisconduct.name",
               Description = new TextType[]{ "misconduct.guiltyOfGraveProfessionalMisconduct.description" },
               Id ="514d3fde-1e3e-4dcd-b02a-9f984d5bbda3",
               Legislations = new Legislation[]{},
               TenderingCriterionPropertyGroups = CriterionHelper.MisconductQuestions
            },
            new TenderingCriterion()
            {
               Name="misconduct.agreementsWithOtherEconomicOperators.name",
               Description = new TextType[]{ "misconduct.agreementsWithOtherEconomicOperators.description" },
               Id ="56d13e3d-76e8-4f23-8af6-13e60a2ee356",
               Legislations = new Legislation[]{},
               TenderingCriterionPropertyGroups = CriterionHelper.MisconductQuestions
            }
        };

        public TenderingCriterion[] Conflict_of_interest { get; set; } = new[]
        {
            new TenderingCriterion()
            {
               Name="conflictOfInterest.conflictOfIinterest.name",
               Description = new TextType[]{ "conflictOfInterest.conflictOfIinterest.description" },
               Id ="b1b5ac18-f393-4280-9659-1367943c1a2e",
               Legislations = new Legislation[]{},
               TenderingCriterionPropertyGroups = CriterionHelper.ConflictOfInterestQuestions
            },
            new TenderingCriterion()
            {
               Name="conflictOfInterest.directOrIndirectInvolvement.name",
               Description = new TextType[]{ "conflictOfInterest.directOrIndirectInvolvement.description" },
               Id ="61874050-5130-4f1c-a174-720939c7b483",
               Legislations = new Legislation[]{},
               TenderingCriterionPropertyGroups = CriterionHelper.ConflictOfInterestQuestions
            }
        };

        public TenderingCriterion[] Early_termination { get; set; } = new[]
        {
            new TenderingCriterion()
            {
               Name="earlyTermination.earlyTerminationDamagesOrOtherSanctions.name",
               Description = new TextType[]{ "earlyTermination.earlyTerminationDamagesOrOtherSanctions.description" },
               Id ="3293e92b-7f3e-42f1-bee6-a7641bb04251",
               Legislations = new Legislation[]{},
               TenderingCriterionPropertyGroups = new TenderingCriterionPropertyGroup[]
               {
                    new TenderingCriterionPropertyGroup()
                    {
                        Id="67362ec7-cec3-4cb8-a38e-5d7a2a31e6d8",
                        PropertyGroupTypeCode ="ON*",
                        TenderingCriterionProperties = new TenderingCriterionProperty[]
                        {
                            new TenderingCriterionProperty()
                            {
                                Description ="common.yourAnswer.description",
                                ValueDataTypeCode ="INDICATOR"
                            },
                        },
                        SubsidiaryTenderingCriterionPropertyGroups = new TenderingCriterionPropertyGroup[]
                        {
                            new TenderingCriterionPropertyGroup()
                            {
                                Id="73f0fe4c-4ed9-4343-8096-d898cf200146",
                                PropertyGroupTypeCode ="ON*",
                                TenderingCriterionProperties = new TenderingCriterionProperty[]
                                {
                                    new TenderingCriterionProperty()
                                    {
                                        Description ="common.pleaseDescribeThem.description",
                                        ValueDataTypeCode ="DESCRIPTION"
                                    },
                                },
                                SubsidiaryTenderingCriterionPropertyGroups = new TenderingCriterionPropertyGroup[]
                                {
                                    new TenderingCriterionPropertyGroup()
                                    {
                                        Id="20c5361b-7599-4ee6-b030-7f8323174d1e",
                                        PropertyGroupTypeCode ="ON*",
                                        TenderingCriterionProperties = new TenderingCriterionProperty[]
                                        {
                                            new TenderingCriterionProperty()
                                            {
                                                Description ="common.measuresToDemonstrateYourReliability.description",
                                                ValueDataTypeCode ="DESCRIPTION"
                                            },
                                        },
                                        SubsidiaryTenderingCriterionPropertyGroups = new TenderingCriterionPropertyGroup[]
                                        {
                                            new TenderingCriterionPropertyGroup()
                                            {
                                                Id="74e6c7b4-757b-4b40-ada6-fad6a997c310",
                                                PropertyGroupTypeCode ="ONTRUE",
                                                TenderingCriterionProperties = new TenderingCriterionProperty[]
                                                {
                                                    new TenderingCriterionProperty()
                                                    {
                                                        Description ="common.pleaseDescribeThem.description",
                                                        ValueDataTypeCode ="DESCRIPTION"
                                                    },
                                                }
                                            }

                                        }
                                    }

                                }
                            },

                        }
                    } 
               }
            }

        };

        public TenderingCriterion[] Misinterpretation { get; set; } = new[]
        {
            new TenderingCriterion()
            {
               Name="misinterpretation.guiltyOfMisinterpretation.name",
               Description = new TextType[]{ "misinterpretation.guiltyOfMisinterpretation.description",
                                             "misinterpretation.guiltyOfMisinterpretationA.description",
                                             "misinterpretation.guiltyOfMisinterpretationB.description",
                                             "misinterpretation.guiltyOfMisinterpretationC.description"},  
               Id ="696a75b2-6107-428f-8b74-82affb67e184",
               Legislations = new Legislation[]{},
               TenderingCriterionPropertyGroups = new TenderingCriterionPropertyGroup[]
               {
                    new TenderingCriterionPropertyGroup()
                    {
                        Id="f3a6836d-2de2-4cd1-81ca-fb06178d05c5",
                        PropertyGroupTypeCode ="ON*",
                        TenderingCriterionProperties = new TenderingCriterionProperty[]
                        {
                            new TenderingCriterionProperty()
                            {
                                Description ="common.yourAnswer.description",
                                ValueDataTypeCode ="INDICATOR"
                            },
                        }
                    }
               }
            }
        };

        //TODO
        public TenderingCriterion[] Purely_national { get; set; } = new[]
        {
            new TenderingCriterion()
            {
                Name="Purely national exclusion grounds",
                Description = new TextType[]{ "Other exclusion grounds that may be foreseen in the national legislation of the contracting authority's or contracting entity's Member State. Has the economic operator breached its obligations relating to the purely national grounds of exclusion, which are specified in the relevant notice or in the procurement documents?" },
                Id ="63adb07d-db1b-4ef0-a14e-a99785cf8cf6",
                Legislations = new Legislation[]{},
                TenderingCriterionPropertyGroups = new TenderingCriterionPropertyGroup[]
                {
                    new TenderingCriterionPropertyGroup()
                    {
                        Id="f3a6836d-2de2-4cd1-81ca-fb06178d05c5",
                        PropertyGroupTypeCode ="ON*",
                        TenderingCriterionProperties = new TenderingCriterionProperty[]
                        {
                            new TenderingCriterionProperty()
                            {
                                Description ="common.yourAnswer.description",
                                ValueDataTypeCode ="INDICATOR"
                            },
                        },
                        SubsidiaryTenderingCriterionPropertyGroups = CriterionHelper.TenderingCriterionURLGroup
                    }
                }
            }
        };



    };

    public class SelectionGroundsSpecification
    {
        public TenderingCriterion[] Suitability { get; set; } = new[]
        {
            new TenderingCriterion()
            {

            }
        };
    }

};

   


