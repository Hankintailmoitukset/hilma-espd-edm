using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Hilma.Espd.EDM.CriterionModel.Identifiers;
using Hilma.UBL.CommonAggregateComponents;
using Hilma.UBL.UnqualifiedDataTypes;

namespace Hilma.Espd.EDM.CriterionModel
{
    public class CriterionSpecification : IEnumerable<TenderingCriterion>
    {
        public ExclusionGroundsSpecification ExclusionGrounds { get; set; } = new ExclusionGroundsSpecification();

        public SelectionCriteriaSpecification SelectionCriteria { get; set; } = new SelectionCriteriaSpecification();

        public IEnumerable<TenderingCriterion> AllCriteria => new [] { 
            ExclusionGrounds.AllCriteria

        }.SelectMany( c => c);

        public IEnumerator<TenderingCriterion> GetEnumerator()
        {
            return AllCriteria.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return AllCriteria.GetEnumerator();
        }
    }

    public class ExclusionGroundsSpecification : IEnumerable<TenderingCriterion>
    {    
        public IEnumerable<TenderingCriterion> AllCriteria => new [] {

            Convictions,
            Contributions,
            Social,
            Business,
            Misconduct,
            ConflictOfInterest,
            EarlyTermination,
            Misinterpretation
            
        }.SelectMany( c => c);
        public IEnumerator<TenderingCriterion> GetEnumerator()
        {
            return AllCriteria.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return AllCriteria.GetEnumerator();
        }
        public TenderingCriterion[] Convictions { get; set; } = new[]
        {
            new TenderingCriterion()
            {   
                CriterionTypeCode = new CriterionTypeCode( "CRITERION.EXCLUSION.CONVICTIONS.PARTICIPATION_IN_CRIMINAL_ORGANISATION" ),
                Name="convictions.participationInCriminalOrganisation.name",
                Description = new TextType[]{ "convictions.participationInCriminalOrganisation.description" },
                Id = new CriteriaTaxonomyIdentifier("e6b21867-95b5-4549-8180-f4673219b179"),
                Legislations = new Legislation[]{},
                TenderingCriterionPropertyGroups = CriterionHelper.ConvictionsQuestionGroup
            },
            new TenderingCriterion()
            {
                CriterionTypeCode = new CriterionTypeCode( "CRITERION.EXCLUSION.CONVICTIONS.CORRUPTION" ),
                Name="convictions.corruption.name",
                Description = new TextType[]{ "convictions.corruption.description" },
                Id = new CriteriaTaxonomyIdentifier("e6b21867-95b5-4549-8180-f4673219b179"),
                Legislations = new Legislation[]{},
                TenderingCriterionPropertyGroups = CriterionHelper.ConvictionsQuestionGroup
            },
            new TenderingCriterion()
            {
                CriterionTypeCode = new CriterionTypeCode( "CRITERION.EXCLUSION.CONVICTIONS.FRAUD" ),
                Name="convictions.fraud.name",
                Description = new TextType[]{ "convictions.fraud.description" },
                Id = new CriteriaTaxonomyIdentifier("297d2323-3ede-424e-94bc-a91561e6f320"),
                Legislations = new Legislation[]{},
                TenderingCriterionPropertyGroups = CriterionHelper.ConvictionsQuestionGroup
            },
            new TenderingCriterion()
            {
                CriterionTypeCode = new CriterionTypeCode( "CRITERION.EXCLUSION.CONVICTIONS.TERRORIST_OFFENCES" ),
                Name="convictions.TerroristActivities.name",
                Description = new TextType[]{ "convictions.TerroristActivities.description" },
                Id = new CriteriaTaxonomyIdentifier("d486fb70-86b3-4e75-97f2-0d71b5697c7d"),
                Legislations = new Legislation[]{},
                TenderingCriterionPropertyGroups = CriterionHelper.ConvictionsQuestionGroup
            },
            new TenderingCriterion()
            {
                CriterionTypeCode = new CriterionTypeCode( "CRITERION.EXCLUSION.CONVICTIONS.MONEY_LAUNDERING" ),
                Name="convictions.moneyLaundering.name",
                Description = new TextType[]{ "convictions.moneyLaundering.description" },
                Id = new CriteriaTaxonomyIdentifier("47112079-6fec-47a3-988f-e561668c3aef"),               
                Legislations = new Legislation[]{},
                TenderingCriterionPropertyGroups = CriterionHelper.ConvictionsQuestionGroup
            },
            new TenderingCriterion()
            {
                CriterionTypeCode = new CriterionTypeCode( "CRITERION.EXCLUSION.CONVICTIONS.CHILD_LABOUR-HUMAN_TRAFFICKING" ),
                Name="convictions.childLabour.name",
                Description = new TextType[]{ "convictions.childLabour.description" },
                Id = new CriteriaTaxonomyIdentifier("d789d01a-fe03-4ccd-9898-73f9cfa080d1"),                
                Legislations = new Legislation[]{},
                TenderingCriterionPropertyGroups = CriterionHelper.ConvictionsQuestionGroup
            },

        };

        public TenderingCriterion[] Contributions { get; set; } = new[]
        {
           new TenderingCriterion()
           {
               CriterionTypeCode = new CriterionTypeCode( "CRITERION.EXCLUSION.CONTRIBUTIONS.PAYMENT_OF_TAXES" ),
               Name="contributions.paymentOfTaxes.name",
               Description = new TextType[]{ "contributions.paymentOfTaxes.description" },
               Id = new CriteriaTaxonomyIdentifier("e6b21867-95b5-4549-8180-f4673219b179"),
               Legislations = new Legislation[]{},
               TenderingCriterionPropertyGroups = new[]
               {

                   new TenderingCriterionPropertyGroup()
                   {
                       Id= new CriteriaTaxonomyIdentifier("53c9aad8-dc80-48f8-85d9-755c2aab8e95"),
                       PropertyGroupTypeCode = new PropertyGroupTypeCode("ON*"),
                       TenderingCriterionProperties = new[]
                       {
                           new TenderingCriterionProperty()
                           {
                             
                             TypeCode = new CriterionElementType("REQUIREMENT"),
                             Description ="contributions.threshold.description",
                             ValueDataTypeCode ="AMOUNT"
                           },
                           new TenderingCriterionProperty()
                           {
                             TypeCode = new CriterionElementType("REQUIREMENT"),
                             Description ="contributions.additionalInformation.description",
                             ValueDataTypeCode ="DESCRIPTION"
                           },

                       },
                       SubsidiaryTenderingCriterionPropertyGroups = new[]
                       {

                           new TenderingCriterionPropertyGroup()
                           {
                                Id = new CriteriaTaxonomyIdentifier("098fd3cc-466e-4233-af1a-affe09471bce"),
                                PropertyGroupTypeCode = new PropertyGroupTypeCode("ON*"),
                                TenderingCriterionProperties = new[]
                                {
                                   new TenderingCriterionProperty()
                                   {
                                     TypeCode = new CriterionElementType("QUESTION"),
                                     Description ="common.yourAnswer.description",
                                     ValueDataTypeCode ="INDICATOR"
                                   },

                                },
                                SubsidiaryTenderingCriterionPropertyGroups = new[]
                                {
                                    new TenderingCriterionPropertyGroup()
                                    {
                                        Id = new CriteriaTaxonomyIdentifier("f8499787-f9f8-4355-95e2-9784426f4d7b"),
                                        PropertyGroupTypeCode= new PropertyGroupTypeCode("ONTRUE"),
                                        TenderingCriterionProperties = new[]
                                        {
                                            new TenderingCriterionProperty()
                                            {
                                                 TypeCode = new CriterionElementType("QUESTION"),
                                                 Description ="common.CountryOrMemberStateConcerned.description",
                                                 ValueDataTypeCode ="CODE_COUNTRY"
                                            },
                                            new TenderingCriterionProperty()
                                            {
                                                 TypeCode = new CriterionElementType("QUESTION"),
                                                 Description ="common.amountConcerned.description",
                                                 ValueDataTypeCode ="AMOUNT"
                                            },

                                        },
                                        SubsidiaryTenderingCriterionPropertyGroups = new[]
                                        {
                                            new TenderingCriterionPropertyGroup()
                                            {
                                                Id = new CriteriaTaxonomyIdentifier("7c2aec9f-4876-4c33-89e6-2ab6d6cf5d02"),
                                                PropertyGroupTypeCode= new PropertyGroupTypeCode("ON*"),
                                                TenderingCriterionProperties = new[]
                                                {
                                                    new TenderingCriterionProperty()
                                                    {
                                                         TypeCode = new CriterionElementType("QUESTION"),
                                                         Description ="Has this breach of obligations been established by means other than a judicial or administrative decision?",
                                                         ValueDataTypeCode ="INDICATOR"
                                                    }
                                                },
                                                SubsidiaryTenderingCriterionPropertyGroups = new[]
                                                {
                                                     new TenderingCriterionPropertyGroup()
                                                     {
                                                         Id = new CriteriaTaxonomyIdentifier("80633323-a7b6-4206-9728-e4534eaad8b2"),
                                                         PropertyGroupTypeCode = new PropertyGroupTypeCode("ONTRUE"),
                                                         TenderingCriterionProperties = new[]
                                                            {
                                                                new TenderingCriterionProperty()
                                                                {
                                                                     TypeCode = new CriterionElementType("QUESTION"),
                                                                     Description ="contributions.pleaseDescribeWhichMeansWereUsed.description",
                                                                     ValueDataTypeCode ="DESCRIPTION"
                                                                }
                                                            },
                                                     },
                                                     new TenderingCriterionPropertyGroup()
                                                     {
                                                         Id = new CriteriaTaxonomyIdentifier("a49e6e25-0059-47da-9397-72c2db5fd5b1"),
                                                         PropertyGroupTypeCode= new PropertyGroupTypeCode("ON*"),
                                                         TenderingCriterionProperties = new[]
                                                            {
                                                                new TenderingCriterionProperty()
                                                                {
                                                                     TypeCode = new CriterionElementType("QUESTION"),
                                                                     Description ="contributions.hasTheEconomicOperatorFulfilled.description",
                                                                     ValueDataTypeCode ="INDICATOR"
                                                                }
                                                            },
                                                         SubsidiaryTenderingCriterionPropertyGroups = new[]
                                                         {
                                                                 new TenderingCriterionPropertyGroup()
                                                                 {
                                                                     Id = new CriteriaTaxonomyIdentifier("42a44eb9-b8c9-4a67-8776-e77fc5356efe"),
                                                                     PropertyGroupTypeCode= new PropertyGroupTypeCode("ONTRUE"),
                                                                     TenderingCriterionProperties = new[]
                                                                        {
                                                                            new TenderingCriterionProperty()
                                                                            {
                                                                                 TypeCode = new CriterionElementType("QUESTION"),
                                                                                 Description ="common.pleaseDescribeThem.description",
                                                                                 ValueDataTypeCode ="DESCRIPTION"
                                                                            }
                                                                     },
                                                                 }
                                                         }
                                                     },
                                                     new TenderingCriterionPropertyGroup()
                                                     {
                                                        Id = new CriteriaTaxonomyIdentifier("536417dc-8130-4981-85c5-fceba5541c58"),
                                                         PropertyGroupTypeCode= new PropertyGroupTypeCode("ONFALSE"),
                                                         TenderingCriterionProperties = new[]
                                                            {
                                                                new TenderingCriterionProperty()
                                                                {
                                                                     TypeCode = new CriterionElementType("QUESTION"),
                                                                     Description ="contributions.ifThisBreachOfObligationsWas.description",
                                                                     ValueDataTypeCode ="INDICATOR"
                                                                }
                                                            },
                                                         SubsidiaryTenderingCriterionPropertyGroups = new[]
                                                         {
                                                                 new TenderingCriterionPropertyGroup()
                                                                 {
                                                                     Id = new CriteriaTaxonomyIdentifier("8aaac22d-1b59-442e-9210-a6e70ec05962"),
                                                                     PropertyGroupTypeCode= new PropertyGroupTypeCode("ONTRUE"),
                                                                     TenderingCriterionProperties = new[]
                                                                     {
                                                                            new TenderingCriterionProperty()
                                                                            {
                                                                                 TypeCode = new CriterionElementType("QUESTION"),
                                                                                 Description ="contributions.pleaseIindicateTheDateOfConvictionOrDecision.description",
                                                                                 ValueDataTypeCode ="DATE"
                                                                            },
                                                                             new TenderingCriterionProperty()
                                                                            {
                                                                                 TypeCode = new CriterionElementType("QUESTION"),
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

                               Id = new CriteriaTaxonomyIdentifier("9026e403-3eb6-4705-a9e9-e21a1efc867d"),
                               PropertyGroupTypeCode= new PropertyGroupTypeCode("ON*"),
                               TenderingCriterionProperties = new[]
                                  {
                                      new TenderingCriterionProperty()
                                      {
                                           TypeCode = new CriterionElementType("QUESTION"),
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
               CriterionTypeCode = new CriterionTypeCode( "CRITERION.EXCLUSION.CONTRIBUTIONS.PAYMENT_OF_SOCIAL_SECURITY" ),
               Name="contributions.paymentOfSocialSecurityContributions.name",
               Description = new TextType[]{ "contributions.paymentOfSocialSecurityContributions.description" },
               Id = new CriteriaTaxonomyIdentifier("7d85e333-bbab-49c0-be8d-c36d71a72f5e"),
               Legislations = new Legislation[]{},
               TenderingCriterionPropertyGroups = new[]
               {

                   new TenderingCriterionPropertyGroup()
                   {
                       Id= new CriteriaTaxonomyIdentifier("53c9aad8-dc80-48f8-85d9-755c2aab8e95"),
                       PropertyGroupTypeCode = new PropertyGroupTypeCode("ON*"),
                       TenderingCriterionProperties = new[]
                       {
                           new TenderingCriterionProperty()
                           {
                             TypeCode = new CriterionElementType("QUESTION"),
                             Description ="contributions.threshold.description",
                             ValueDataTypeCode ="AMOUNT"
                           },
                           new TenderingCriterionProperty()
                           {
                             TypeCode = new CriterionElementType("QUESTION"),
                             Description ="contributions.additionalInformation.description",
                             ValueDataTypeCode ="DESCRIPTION"
                           },

                       },
                       SubsidiaryTenderingCriterionPropertyGroups = new[]
                       {

                           new TenderingCriterionPropertyGroup()
                           {
                                Id = new CriteriaTaxonomyIdentifier("098fd3cc-466e-4233-af1a-affe09471bce"),
                                PropertyGroupTypeCode = new PropertyGroupTypeCode("ON*"),
                                TenderingCriterionProperties = new[]
                                {
                                   new TenderingCriterionProperty()
                                   {
                                     TypeCode = new CriterionElementType("QUESTION"),
                                     Description ="common.yourAnswer.description",
                                     ValueDataTypeCode ="INDICATOR"
                                   },

                                },
                                SubsidiaryTenderingCriterionPropertyGroups = new[]
                                {
                                    new TenderingCriterionPropertyGroup()
                                    {
                                        Id = new CriteriaTaxonomyIdentifier("f8499787-f9f8-4355-95e2-9784426f4d7b"),
                                        PropertyGroupTypeCode= new PropertyGroupTypeCode("ONTRUE"),
                                        TenderingCriterionProperties = new[]
                                        {
                                            new TenderingCriterionProperty()
                                            {
                                                 TypeCode = new CriterionElementType("QUESTION"),
                                                 Description ="common.CountryOrMemberStateConcerned.description",
                                                 ValueDataTypeCode ="CODE_COUNTRY"
                                            },
                                            new TenderingCriterionProperty()
                                            {
                                                 TypeCode = new CriterionElementType("QUESTION"),
                                                 Description ="common.amountConcerned.description",
                                                 ValueDataTypeCode ="AMOUNT"
                                            },

                                        },
                                        SubsidiaryTenderingCriterionPropertyGroups = new[]
                                        {
                                            new TenderingCriterionPropertyGroup()
                                            {
                                                Id = new CriteriaTaxonomyIdentifier("7c2aec9f-4876-4c33-89e6-2ab6d6cf5d02"),
                                                PropertyGroupTypeCode= new PropertyGroupTypeCode("ON*"),
                                                TenderingCriterionProperties = new[]
                                                {
                                                    new TenderingCriterionProperty()
                                                    {
                                                         TypeCode = new CriterionElementType("QUESTION"),
                                                         Description ="contributions.hasThisBreachOfObligations.description",
                                                         ValueDataTypeCode ="INDICATOR"
                                                    }
                                                },
                                                SubsidiaryTenderingCriterionPropertyGroups = new[]
                                                {
                                                     new TenderingCriterionPropertyGroup()
                                                     {
                                                         Id = new CriteriaTaxonomyIdentifier("80633323-a7b6-4206-9728-e4534eaad8b2"),
                                                         PropertyGroupTypeCode= new PropertyGroupTypeCode("ONTRUE"),
                                                         TenderingCriterionProperties = new[]
                                                            {
                                                                new TenderingCriterionProperty()
                                                                {
                                                                     TypeCode = new CriterionElementType("QUESTION"),
                                                                     Description ="contributions.pleaseDescribeWhichMeansWereUsed.description",
                                                                     ValueDataTypeCode ="DESCRIPTION"
                                                                }
                                                            },
                                                     },
                                                     new TenderingCriterionPropertyGroup()
                                                     {
                                                         Id = new CriteriaTaxonomyIdentifier("a49e6e25-0059-47da-9397-72c2db5fd5b1"),
                                                         PropertyGroupTypeCode= new PropertyGroupTypeCode("ON*"),
                                                         TenderingCriterionProperties = new[]
                                                            {
                                                                new TenderingCriterionProperty()
                                                                {
                                                                     TypeCode = new CriterionElementType("QUESTION"),
                                                                     Description ="contributions.hasTheEconomicOperatorFulfilled.description",
                                                                     ValueDataTypeCode ="INDICATOR"
                                                                }
                                                            },
                                                         SubsidiaryTenderingCriterionPropertyGroups = new[]
                                                         {
                                                                 new TenderingCriterionPropertyGroup()
                                                                 {
                                                                     Id = new CriteriaTaxonomyIdentifier("42a44eb9-b8c9-4a67-8776-e77fc5356efe"),
                                                                     PropertyGroupTypeCode= new PropertyGroupTypeCode("ONTRUE"),
                                                                     TenderingCriterionProperties = new[]
                                                                        {
                                                                            new TenderingCriterionProperty()
                                                                            {
                                                                                 TypeCode = new CriterionElementType("QUESTION"),
                                                                                 Description ="common.pleaseDescribeThem.description",
                                                                                 ValueDataTypeCode ="DESCRIPTION"
                                                                            }
                                                                     },
                                                                 }
                                                         }
                                                     },
                                                     new TenderingCriterionPropertyGroup()
                                                     {
                                                        Id = new CriteriaTaxonomyIdentifier("536417dc-8130-4981-85c5-fceba5541c58"),
                                                         PropertyGroupTypeCode= new PropertyGroupTypeCode("ONFALSE"),
                                                         TenderingCriterionProperties = new[]
                                                            {
                                                                new TenderingCriterionProperty()
                                                                {
                                                                     TypeCode = new CriterionElementType("QUESTION"),
                                                                     Description ="contributions.ifThisBreachOfObligationsWas.description",
                                                                     ValueDataTypeCode ="INDICATOR"
                                                                }
                                                            },
                                                         SubsidiaryTenderingCriterionPropertyGroups = new[]
                                                         {
                                                                 new TenderingCriterionPropertyGroup()
                                                                 {
                                                                     Id = new CriteriaTaxonomyIdentifier("8aaac22d-1b59-442e-9210-a6e70ec05962"),
                                                                     PropertyGroupTypeCode= new PropertyGroupTypeCode("ONTRUE"),
                                                                     TenderingCriterionProperties = new[]
                                                                     {
                                                                            new TenderingCriterionProperty()
                                                                            {
                                                                                 TypeCode = new CriterionElementType("QUESTION"),
                                                                                 Description ="contributions.pleaseIindicateTheDateOfConvictionOrDecision.description",
                                                                                 ValueDataTypeCode ="DATE"
                                                                            },
                                                                             new TenderingCriterionProperty()
                                                                            {
                                                                                 TypeCode = new CriterionElementType("QUESTION"),
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

                               Id = new CriteriaTaxonomyIdentifier("9026e403-3eb6-4705-a9e9-e21a1efc867d"),
                               PropertyGroupTypeCode= new PropertyGroupTypeCode("ON*"),
                               TenderingCriterionProperties = new[]
                               {
                                  new TenderingCriterionProperty()
                                  {
                                       TypeCode = new CriterionElementType("QUESTION"),
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
               CriterionTypeCode = new CriterionTypeCode( "CRITERION.EXCLUSION.SOCIAL.ENVIRONMENTAL_LAW" ),
               Name="social.environmentalLaw.name",
               Description = new TextType[]{ "social.environmentalLaw.description" },
               Id = new CriteriaTaxonomyIdentifier("a80ddb62-d25b-4e4e-ae22-3968460dc0a9"),
               Legislations = new Legislation[]{},
               TenderingCriterionPropertyGroups = CriterionHelper.Social_LawCriterionPropertyGroups,
               
            },
            new TenderingCriterion()
            {
               CriterionTypeCode = new CriterionTypeCode( "CRITERION.EXCLUSION.SOCIAL.SOCIAL_LAW" ),
               Name="social.socialLaw.name",
               Description = new TextType[]{ "social.socialLaw.description" },
               Id = new CriteriaTaxonomyIdentifier("a261a395-ed17-4939-9c75-b9ff1109ca6e"),
               Legislations = new Legislation[]{},
               TenderingCriterionPropertyGroups = CriterionHelper.Social_LawCriterionPropertyGroups
            },
            new TenderingCriterion()
            {
               CriterionTypeCode = new CriterionTypeCode( "CRITERION.EXCLUSION.SOCIAL.LABOUR_LAW" ),
               Name="social.labourLaw.name",
               Description = new TextType[]{ "social.labourLaw.description" },
               Id = new CriteriaTaxonomyIdentifier("a34b70d6-c43d-4726-9a88-8e2b438424bf"),
               Legislations = new Legislation[]{},
               TenderingCriterionPropertyGroups = CriterionHelper.Social_LawCriterionPropertyGroups
            }
        };

        public TenderingCriterion[] Business { get; set; } = new[]
        {

            new TenderingCriterion()
            {
               CriterionTypeCode = new CriterionTypeCode( "CRITERION.EXCLUSION.BUSINESS.BANKRUPTCY" ),
               Name="business.bankruptcy.name",
               Description = new TextType[]{ "business.bankruptcy.description" },
               Id = new CriteriaTaxonomyIdentifier("d3732c09-7d62-4edc-a172-241da6636e7c"),
               Legislations = new Legislation[]{},
               TenderingCriterionPropertyGroups = CriterionHelper.Business
            },
            new TenderingCriterion()
            {
               CriterionTypeCode = new CriterionTypeCode( "CRITERION.EXCLUSION.BUSINESS.INSOLVENCY" ),
               Name="business.insolvency.name",
               Description = new TextType[]{ "business.insolvency.description" },
               Id = new CriteriaTaxonomyIdentifier("396f288a-e267-4c20-851a-ed4f7498f137"),
               Legislations = new Legislation[]{},
               TenderingCriterionPropertyGroups = CriterionHelper.Business
            },
            new TenderingCriterion()
            {
               CriterionTypeCode = new CriterionTypeCode( "CRITERION.EXCLUSION.BUSINESS.CREDITORS_ARRANGEMENT" ),
               Name="business.arrangementWithCreditors.name",
               Description = new TextType[]{ "business.arrangementWithCreditors.description" },
               Id = new CriteriaTaxonomyIdentifier("68918c7a-f5bc-4a1a-a62f-ad8983600d48"),
               Legislations = new Legislation[]{},
               TenderingCriterionPropertyGroups = CriterionHelper.Business
            },
            new TenderingCriterion()
            {
               CriterionTypeCode = new CriterionTypeCode( "CRITERION.EXCLUSION.BUSINESS.BANKRUPTCY_ANALOGOUS" ),
               Name="business.analogousSituationLikeBankruptcyUnderNationalLaw.name",
               Description = new TextType[]{ "business.analogousSituationLikeBankruptcyUnderNationalLaw.description" },
               Id = new CriteriaTaxonomyIdentifier("daffa2a9-9f8f-4568-8be8-7b8bf306d096"),
               Legislations = new Legislation[]{},
               TenderingCriterionPropertyGroups = CriterionHelper.Business
            },
            new TenderingCriterion()
            {
               CriterionTypeCode = new CriterionTypeCode( "CRITERION.EXCLUSION.BUSINESS.LIQUIDATOR_ADMINISTERED" ),
               Name="business.assetsBeingAdministeredByLiquidator.name",
               Description = new TextType[]{ "business.assetsBeingAdministeredByLiquidator.description" },
               Id = new CriteriaTaxonomyIdentifier("8fda202a-0c37-41bb-9d7d-de3f49edbfcb"),
               Legislations = new Legislation[]{},
               TenderingCriterionPropertyGroups = CriterionHelper.Business
            },
            new TenderingCriterion()
            {
               CriterionTypeCode = new CriterionTypeCode( "CRITERION.EXCLUSION.BUSINESS.ACTIVITIES_SUSPENDED" ),
               Name="business.businessActivitiesAreSuspended.name",
               Description = new TextType[]{ "business.businessActivitiesAreSuspended.description" },
               Id = new CriteriaTaxonomyIdentifier("166536e2-77f7-455c-b018-70582474e4f6"),
               Legislations = new Legislation[]{},
               TenderingCriterionPropertyGroups = CriterionHelper.Business
            }

        };

        public TenderingCriterion[] Misconduct { get; set; } = new[]
        {
            new TenderingCriterion()
            {
               CriterionTypeCode = new CriterionTypeCode( "CRITERION.EXCLUSION.MISCONDUCT.MC_PROFESSIONAL" ),
               Name="misconduct.guiltyOfGraveProfessionalMisconduct.name",
               Description = new TextType[]{ "misconduct.guiltyOfGraveProfessionalMisconduct.description" },
               Id = new CriteriaTaxonomyIdentifier("514d3fde-1e3e-4dcd-b02a-9f984d5bbda3"),
               Legislations = new Legislation[]{},
               TenderingCriterionPropertyGroups = CriterionHelper.MisconductQuestions
            },
            new TenderingCriterion()
            {
               CriterionTypeCode = new CriterionTypeCode( "CRITERION.EXCLUSION.MISCONDUCT.MARKET_DISTORTION" ),
               Name="misconduct.agreementsWithOtherEconomicOperators.name",
               Description = new TextType[]{ "misconduct.agreementsWithOtherEconomicOperators.description" },
               Id = new CriteriaTaxonomyIdentifier("56d13e3d-76e8-4f23-8af6-13e60a2ee356"),
               Legislations = new Legislation[]{},
               TenderingCriterionPropertyGroups = CriterionHelper.MisconductQuestions
            }
        };

        public TenderingCriterion[] ConflictOfInterest { get; set; } = new[]
        {
            new TenderingCriterion()
            {
               CriterionTypeCode = new CriterionTypeCode( "CRITERION.EXCLUSION.CONFLICT_OF_INTEREST.PROCEDURE_PARTICIPATION" ),
               Name="conflictOfInterest.conflictOfIinterest.name",
               Description = new TextType[]{ "conflictOfInterest.conflictOfIinterest.description" },
               Id = new CriteriaTaxonomyIdentifier("b1b5ac18-f393-4280-9659-1367943c1a2e"),
               Legislations = new Legislation[]{},
               TenderingCriterionPropertyGroups = CriterionHelper.ConflictOfInterestQuestions
            },
            new TenderingCriterion()
            {
               CriterionTypeCode = new CriterionTypeCode( "CRITERION.EXCLUSION.CONFLICT_OF_INTEREST.PROCEDURE_PREPARATION" ),
               Name="conflictOfInterest.directOrIndirectInvolvement.name",
               Description = new TextType[]{ "conflictOfInterest.directOrIndirectInvolvement.description" },
               Id = new CriteriaTaxonomyIdentifier("61874050-5130-4f1c-a174-720939c7b483"),
               Legislations = new Legislation[]{},
               TenderingCriterionPropertyGroups = CriterionHelper.ConflictOfInterestQuestions
            }
        };

        public TenderingCriterion[] EarlyTermination { get; set; } = new[]
        {
            new TenderingCriterion()
            {
               CriterionTypeCode = new CriterionTypeCode( "CRITERION.EXCLUSION.CONFLICT_OF_INTEREST.EARLY_TERMINATION" ),
               Name="earlyTermination.earlyTerminationDamagesOrOtherSanctions.name",
               Description = new TextType[]{ "earlyTermination.earlyTerminationDamagesOrOtherSanctions.description" },
               Id = new CriteriaTaxonomyIdentifier("3293e92b-7f3e-42f1-bee6-a7641bb04251"),
               Legislations = new Legislation[]{},
               TenderingCriterionPropertyGroups = new[]
               {
                    new TenderingCriterionPropertyGroup()
                    {
                        Id= new CriteriaTaxonomyIdentifier("67362ec7-cec3-4cb8-a38e-5d7a2a31e6d8"),
                        PropertyGroupTypeCode = new PropertyGroupTypeCode("ON*"),
                        TenderingCriterionProperties = new[]
                        {
                            new TenderingCriterionProperty()
                            {
                                TypeCode = new CriterionElementType("QUESTION"),
                                Description ="common.yourAnswer.description",
                                ValueDataTypeCode ="INDICATOR"
                            },
                        },
                        SubsidiaryTenderingCriterionPropertyGroups = new[]
                        {
                            new TenderingCriterionPropertyGroup()
                            {
                                Id= new CriteriaTaxonomyIdentifier("73f0fe4c-4ed9-4343-8096-d898cf200146"),
                                PropertyGroupTypeCode = new PropertyGroupTypeCode("ON*"),
                                TenderingCriterionProperties = new[]
                                {
                                    new TenderingCriterionProperty()
                                    {
                                        TypeCode = new CriterionElementType("QUESTION"),
                                        Description ="common.pleaseDescribeThem.description",
                                        ValueDataTypeCode ="DESCRIPTION"
                                    },
                                },
                                SubsidiaryTenderingCriterionPropertyGroups = new[]
                                {
                                    new TenderingCriterionPropertyGroup()
                                    {
                                        Id= new CriteriaTaxonomyIdentifier("20c5361b-7599-4ee6-b030-7f8323174d1e"),
                                        PropertyGroupTypeCode = new PropertyGroupTypeCode("ON*"),
                                        TenderingCriterionProperties = new[]
                                        {
                                            new TenderingCriterionProperty()
                                            {
                                                TypeCode = new CriterionElementType("QUESTION"),
                                                Description ="common.measuresToDemonstrateYourReliability.description",
                                                ValueDataTypeCode ="DESCRIPTION"
                                            },
                                        },
                                        SubsidiaryTenderingCriterionPropertyGroups = new[]
                                        {
                                            new TenderingCriterionPropertyGroup()
                                            {
                                                Id= new CriteriaTaxonomyIdentifier("74e6c7b4-757b-4b40-ada6-fad6a997c310"),
                                                PropertyGroupTypeCode = new PropertyGroupTypeCode("ONTRUE"),
                                                TenderingCriterionProperties = new[]
                                                {
                                                    new TenderingCriterionProperty()
                                                    {
                                                        TypeCode = new CriterionElementType("QUESTION"),
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
               CriterionTypeCode = new CriterionTypeCode( "CRITERION.EXCLUSION.CONFLICT_OF_INTEREST.MISINTERPRETATION" ),
               Name="misinterpretation.guiltyOfMisinterpretation.name",
               Description = new TextType[]{ "misinterpretation.guiltyOfMisinterpretation.description",
                                             "misinterpretation.guiltyOfMisinterpretationA.description",
                                             "misinterpretation.guiltyOfMisinterpretationB.description",
                                             "misinterpretation.guiltyOfMisinterpretationC.description"},  
               Id = new CriteriaTaxonomyIdentifier("696a75b2-6107-428f-8b74-82affb67e184"),
               Legislations = new Legislation[]{},
               TenderingCriterionPropertyGroups = new[]
               {
                    new TenderingCriterionPropertyGroup()
                    {
                        Id= new CriteriaTaxonomyIdentifier("f3a6836d-2de2-4cd1-81ca-fb06178d05c5"),
                        PropertyGroupTypeCode = new PropertyGroupTypeCode("ON*"),
                        TenderingCriterionProperties = new[]
                        {
                            new TenderingCriterionProperty()
                            {
                                TypeCode = new CriterionElementType("QUESTION"),
                                Description ="common.yourAnswer.description",
                                ValueDataTypeCode ="INDICATOR"
                            },
                        }
                    }
               }
            }
        };

        //TODO
        public TenderingCriterion[] PurelyNational { get; set; } = new[]
        {
            new TenderingCriterion()
            {
                CriterionTypeCode = new CriterionTypeCode( "CRITERION.EXCLUSION.NATIONAL.OTHER" ),
                Name="Purely national exclusion grounds",
                Description = new TextType[]{ "Other exclusion grounds that may be foreseen in the national legislation of the contracting authority's or contracting entity's Member State. Has the economic operator breached its obligations relating to the purely national grounds of exclusion, which are specified in the relevant notice or in the procurement documents?" },
                Id = new CriteriaTaxonomyIdentifier("63adb07d-db1b-4ef0-a14e-a99785cf8cf6"),
                Legislations = new Legislation[]{},
                TenderingCriterionPropertyGroups = new[]
                {
                    new TenderingCriterionPropertyGroup()
                    {
                        Id=new CriteriaTaxonomyIdentifier("f3a6836d-2de2-4cd1-81ca-fb06178d05c5"),
                        PropertyGroupTypeCode = new PropertyGroupTypeCode("ON*"),
                        TenderingCriterionProperties = new[]
                        {
                            new TenderingCriterionProperty()
                            {
                                TypeCode = new CriterionElementType("QUESTION"),
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

    public class SelectionCriteriaSpecification
    {
        public TenderingCriterion[] Suitability { get; set; } = new[]
        {
            new TenderingCriterion()
        };
    }

};

   


