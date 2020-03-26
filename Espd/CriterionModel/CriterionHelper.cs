using Hilma.Espd.EDM.CriterionModel.Identifiers;
using Hilma.UBL.CommonAggregateComponents;
using Hilma.UBL.UnqualifiedDataTypes;

namespace Hilma.Espd.EDM.CriterionModel
{
    public class CriterionHelper
    {

        public static TenderingCriterion[] Subcriterion =>
         new TenderingCriterion[]
               {
                   new TenderingCriterion(){
                       Name ="[Name of the National Criterion]",
                       Description = new TextType[]{ "[Description of the National Criterion ]" },
                       Id ="e6b21867-95b5-4549-8180-f4673219b179",
                       CriterionTypeCode ="ON*",
                       TenderingCriterionPropertyGroups = new TenderingCriterionPropertyGroup[]
                       {
                           new TenderingCriterionPropertyGroup(){
                               PropertyGroupTypeCode = new PropertyGroupTypeCode("NONE"),
                               Description = new TextType[]{"[Additional information; e.g. no evidences online]" },
                           },
                           new TenderingCriterionPropertyGroup(){
                               PropertyGroupTypeCode = new PropertyGroupTypeCode("INDICATOR"),
                               Description = new TextType[]{"Your Answer" }
                           }

                       }
                   }
               };

        public static TenderingCriterionPropertyGroup[] ConvictionsQuestionGroup =>
            new TenderingCriterionPropertyGroup[]
                {
                    new TenderingCriterionPropertyGroup()
                    {
                        Id = new CriteriaTaxonomyIdentifier("7c637c0c-7703-4389-ba52-02997a055bd7"),
                        PropertyGroupTypeCode = new PropertyGroupTypeCode("ON*"),
                        TenderingCriterionProperties = new TenderingCriterionProperty[]
                        {
                           new TenderingCriterionProperty()
                           {
                             TypeCode = new CriterionElementType("QUESTION"),
                             Description ="common.yourAnswer.description",
                             ValueDataTypeCode ="INDICATOR"
                           }
                        },
                        SubsidiaryTenderingCriterionPropertyGroups = new TenderingCriterionPropertyGroup[]
                        {
                            new TenderingCriterionPropertyGroup()
                            {
                                Id = new CriteriaTaxonomyIdentifier("41dd2e9b-1bfd-44c7-93ee-56bd74a4334b"),
                                PropertyGroupTypeCode = new PropertyGroupTypeCode("ONTRUE"),
                                TenderingCriterionProperties = new TenderingCriterionProperty[]
                                {
                                   new TenderingCriterionProperty()
                                   {
                                     TypeCode = new CriterionElementType("QUESTION"),
                                     Description ="convictions.dateOfConviction.description",
                                     ValueDataTypeCode ="DATE"
                                   },
                                   new TenderingCriterionProperty()
                                   {
                                     TypeCode = new CriterionElementType("QUESTION"),
                                     Description ="convictions.reason.description",
                                     ValueDataTypeCode ="DESCRIPTION"
                                   },
                                   new TenderingCriterionProperty()
                                   {
                                     TypeCode = new CriterionElementType("QUESTION"),
                                     Description ="convictions.whoHasBeenConvicted.description",
                                     ValueDataTypeCode ="DESCRIPTION"
                                   },
                                   new TenderingCriterionProperty()
                                   {
                                     TypeCode = new CriterionElementType("QUESTION"),
                                     Description ="convictions.lengthOfThePeriodOfExclusion.description",
                                     ValueDataTypeCode ="PERIOD"
                                   }
                                },
                                SubsidiaryTenderingCriterionPropertyGroups = new TenderingCriterionPropertyGroup[]
                                {
                                    new TenderingCriterionPropertyGroup()
                                    {
                                        Id = new CriteriaTaxonomyIdentifier("5f9f09f7-f701-432c-9fdc-c22c124a74c9"),
                                        PropertyGroupTypeCode ="ON*",
                                        TenderingCriterionProperties = new TenderingCriterionProperty[]
                                        {
                                            new TenderingCriterionProperty()
                                               {
                                                 TypeCode = new CriterionElementType("QUESTION"),
                                                 Description ="convictions.measuresToDemonstrateYourReliability.description",
                                                 ValueDataTypeCode ="INDICATOR"
                                               }
                                        },
                                        SubsidiaryTenderingCriterionPropertyGroups = new TenderingCriterionPropertyGroup[]
                                        {
                                            new TenderingCriterionPropertyGroup()
                                            {
                                                Id = new CriteriaTaxonomyIdentifier("74e6c7b4-757b-4b40-ada6-fad6a997c310"),
                                                PropertyGroupTypeCode = new PropertyGroupTypeCode("ONTRUE"),
                                                TenderingCriterionProperties = new TenderingCriterionProperty[]
                                                {
                                                    new TenderingCriterionProperty()
                                                       {
                                                         TypeCode = new CriterionElementType("QUESTION"),
                                                         Description ="common.pleaseDescribeThem.description",
                                                         ValueDataTypeCode ="DESCRIPTION"
                                                       }
                                                }
                                            }
                                        }
                                    }
                                }

                            }
                        }
                    },
                    new TenderingCriterionPropertyGroup()
                    {
                        Id = new CriteriaTaxonomyIdentifier("9026e403-3eb6-4705-a9e9-e21a1efc867d"),
                        PropertyGroupTypeCode = new PropertyGroupTypeCode("ON*"),
                        TenderingCriterionProperties = new TenderingCriterionProperty[]
                        {
                           new TenderingCriterionProperty()
                           {
                             TypeCode = new CriterionElementType("QUESTION"),
                             Description ="common.informationAvailableFromEUDb.description",
                             ValueDataTypeCode ="INDICATOR"
                           }
                        },
                        SubsidiaryTenderingCriterionPropertyGroups = TenderingCriterionURLGroup
                    }
                };

        public static TenderingCriterionPropertyGroup[] Social_LawCriterionPropertyGroups =>
            new TenderingCriterionPropertyGroup[]
               {

                   new TenderingCriterionPropertyGroup()
                   {
                       Id = new CriteriaTaxonomyIdentifier("976b5acb-c00f-46ca-8f83-5ce6abfdfe43"),
                       PropertyGroupTypeCode = new PropertyGroupTypeCode("ON*"),
                       TenderingCriterionProperties = new TenderingCriterionProperty[]
                       {
                           new TenderingCriterionProperty()
                           {
                             TypeCode = new CriterionElementType("QUESTION"),
                             Description ="common.yourAnswer.description",
                             ValueDataTypeCode ="INDICATOR"
                           },
                       },
                       SubsidiaryTenderingCriterionPropertyGroups = new TenderingCriterionPropertyGroup[]
                       {
                           new TenderingCriterionPropertyGroup()
                           {
                               Id = new CriteriaTaxonomyIdentifier("64a2102c-4af1-4ecb-97b3-0c41907ec0f6"),
                               PropertyGroupTypeCode = new PropertyGroupTypeCode("ONTRUE"),
                               TenderingCriterionProperties = new TenderingCriterionProperty[]
                               {
                                   new TenderingCriterionProperty()
                                   {
                                     TypeCode = new CriterionElementType("QUESTION"),
                                     Description ="common.pleaseDescribeThem.description",
                                     ValueDataTypeCode ="DESCRIPTION"
                                   },
                               },
                               SubsidiaryTenderingCriterionPropertyGroups = new TenderingCriterionPropertyGroup[]
                               {
                                   new TenderingCriterionPropertyGroup()
                                   {
                                       Id = new CriteriaTaxonomyIdentifier("5f9f09f7-f701-432c-9fdc-c22c124a74c9"),
                                       PropertyGroupTypeCode = new PropertyGroupTypeCode("ON*"),
                                       TenderingCriterionProperties = new TenderingCriterionProperty[]
                                       {
                                           new TenderingCriterionProperty()
                                           {
                                             TypeCode = new CriterionElementType("QUESTION"),
                                             Description ="convictions.measuresToDemonstrateYourReliability.description",
                                             ValueDataTypeCode ="DESCRIPTION"
                                           },
                                       },
                                       SubsidiaryTenderingCriterionPropertyGroups = new TenderingCriterionPropertyGroup[]
                                       {
                                           new TenderingCriterionPropertyGroup()
                                           {
                                               Id = new CriteriaTaxonomyIdentifier("74e6c7b4-757b-4b40-ada6-fad6a997c310"),
                                               PropertyGroupTypeCode = new PropertyGroupTypeCode("ONTRUE"),
                                               TenderingCriterionProperties = new TenderingCriterionProperty[]
                                               {
                                                   new TenderingCriterionProperty()
                                                   {
                                                     TypeCode = new CriterionElementType("QUESTION"),
                                                     Description ="common.pleaseDescribeThem.description",
                                                     ValueDataTypeCode ="DESCRIPTION"
                                                   },
                                               },
                                           }

                                       }
                                   }

                               }
                           }

                       }
                   }
               };

        public static TenderingCriterionPropertyGroup[] TenderingCriterionURLGroup =>
            new TenderingCriterionPropertyGroup[]
            {
                new TenderingCriterionPropertyGroup()
                {
                    Id = new CriteriaTaxonomyIdentifier("0a166f0a-0c5f-42b0-81e9-0fc9fa598a48"),
                    PropertyGroupTypeCode = new PropertyGroupTypeCode("ONTRUE"),
                    TenderingCriterionProperties = new TenderingCriterionProperty[]
                    {
                        new TenderingCriterionProperty()
                        {
                            TypeCode = new CriterionElementType("QUESTION"),
                            Description ="common.url.description",
                            ValueDataTypeCode ="EVIDENCE_URL"
                        },
                        new TenderingCriterionProperty()
                        {
                            TypeCode = new CriterionElementType("QUESTION"),
                            Description ="common.verificationCode.description",
                            ValueDataTypeCode ="DESCRIPTION"
                        },
                        new TenderingCriterionProperty()
                        {
                            TypeCode = new CriterionElementType("QUESTION"),
                            Description ="common.issuer.description",
                            ValueDataTypeCode ="DESCRIPTION"
                        }
                    }
                }
            };

        public static TenderingCriterionPropertyGroup[] Business =>
             new TenderingCriterionPropertyGroup[]
               {
                   new TenderingCriterionPropertyGroup()
                   {
                       Id = new CriteriaTaxonomyIdentifier("d91c11a1-f19e-4b83-8ade-c4be2bf00555"),
                       PropertyGroupTypeCode = new PropertyGroupTypeCode("ON*"),
                       TenderingCriterionProperties = new TenderingCriterionProperty[]
                       {
                           new TenderingCriterionProperty()
                           {
                             TypeCode = new CriterionElementType("QUESTION"),
                             Description ="common.yourAnswer.description",
                             ValueDataTypeCode ="INDICATOR"
                           },
                       },

                       SubsidiaryTenderingCriterionPropertyGroups = new TenderingCriterionPropertyGroup[]
                       {
                           new TenderingCriterionPropertyGroup()
                           {
                               Id = new CriteriaTaxonomyIdentifier("aeef523b-c8fc-4dba-9c34-03e34812567b"),
                               PropertyGroupTypeCode = new PropertyGroupTypeCode("ONTRUE"),
                               TenderingCriterionProperties = new TenderingCriterionProperty[]
                               {
                                   new TenderingCriterionProperty()
                                   {
                                     TypeCode = new CriterionElementType("QUESTION"),
                                     Description ="common.pleaseDescribeThem.description",
                                     ValueDataTypeCode ="DESCRIPTION"
                                   },
                                   new TenderingCriterionProperty()
                                   {
                                     TypeCode = new CriterionElementType("QUESTION"),
                                     Description ="business.indicateReasonsForBeingNeverthelessToPerformTheContract.description",
                                     ValueDataTypeCode ="DESCRIPTION"
                                   },
                               }
                           }

                       }
                   },
                   new TenderingCriterionPropertyGroup()
                   {
                       Id = new CriteriaTaxonomyIdentifier("9026e403-3eb6-4705-a9e9-e21a1efc867d"),
                       PropertyGroupTypeCode = new PropertyGroupTypeCode("ON*"),
                       TenderingCriterionProperties = new TenderingCriterionProperty[]
                       {
                           new TenderingCriterionProperty()
                           {
                             TypeCode = new CriterionElementType("QUESTION"),
                             Description ="common.informationAvailableFromEUDb.description",
                             ValueDataTypeCode ="INDICATOR"
                           },
                       },

                       SubsidiaryTenderingCriterionPropertyGroups = CriterionHelper.TenderingCriterionURLGroup
                   }


             };

        public static TenderingCriterionPropertyGroup[] MisconductQuestions =>
            new TenderingCriterionPropertyGroup[]
               {
                   new TenderingCriterionPropertyGroup()
                   {
                       Id = new CriteriaTaxonomyIdentifier("67362ec7-cec3-4cb8-a38e-5d7a2a31e6d8"),
                       PropertyGroupTypeCode = new PropertyGroupTypeCode("ON*"),
                       TenderingCriterionProperties = new TenderingCriterionProperty[]
                       {
                           new TenderingCriterionProperty()
                           {
                             TypeCode = new CriterionElementType("QUESTION"),
                             Description ="common.yourAnswer.description",
                             ValueDataTypeCode ="INDICATOR"
                           },
                       },
                       SubsidiaryTenderingCriterionPropertyGroups = new TenderingCriterionPropertyGroup[]
                       {
                           new TenderingCriterionPropertyGroup()
                           {
                               Id = new CriteriaTaxonomyIdentifier("2cbcf978-765c-40aa-996b-b1d082485cef"),
                               PropertyGroupTypeCode = new PropertyGroupTypeCode("ONTRUE"),
                               TenderingCriterionProperties = new TenderingCriterionProperty[]
                               {
                                   new TenderingCriterionProperty()
                                   {
                                     TypeCode = new CriterionElementType("QUESTION"),
                                     Description ="common.pleaseDescribeThem.description",
                                     ValueDataTypeCode ="INDICATOR"
                                   },
                               },

                           },
                            new TenderingCriterionPropertyGroup()
                           {
                               Id = new CriteriaTaxonomyIdentifier("5f9f09f7-f701-432c-9fdc-c22c124a74c9"),
                               PropertyGroupTypeCode = new PropertyGroupTypeCode("ON*"),
                               TenderingCriterionProperties = new TenderingCriterionProperty[]
                               {
                                   new TenderingCriterionProperty()
                                   {
                                     TypeCode = new CriterionElementType("QUESTION"),
                                     Description ="misconduct.haveYouTakenMeasuresToDemonstrateYourReliability.description",
                                     ValueDataTypeCode ="INDICATOR"
                                   },
                               },
                               SubsidiaryTenderingCriterionPropertyGroups = new TenderingCriterionPropertyGroup[]
                               {
                                   new TenderingCriterionPropertyGroup()
                                   {
                                       Id = new CriteriaTaxonomyIdentifier("74e6c7b4-757b-4b40-ada6-fad6a997c310"),
                                       PropertyGroupTypeCode = new PropertyGroupTypeCode("ON*"),
                                       TenderingCriterionProperties = new TenderingCriterionProperty[]
                                       {
                                           new TenderingCriterionProperty()
                                           {
                                             TypeCode = new CriterionElementType("QUESTION"),
                                             Description ="common.pleaseDescribeThem.description",
                                             ValueDataTypeCode ="INDICATOR"
                                           },
                                       },

                                   }
                               }

                           }
                       }
                   }
               };

        public static TenderingCriterionPropertyGroup[] ConflictOfInterestQuestions =>
            new TenderingCriterionPropertyGroup[]
               {
                    new TenderingCriterionPropertyGroup()
                    {
                        Id = new CriteriaTaxonomyIdentifier("67362ec7-cec3-4cb8-a38e-5d7a2a31e6d8"),
                        PropertyGroupTypeCode = new PropertyGroupTypeCode("ON*"),
                        TenderingCriterionProperties = new TenderingCriterionProperty[]
                        {
                            new TenderingCriterionProperty()
                            {
                                TypeCode = new CriterionElementType("QUESTION"),
                                Description ="common.yourAnswer.description",
                                ValueDataTypeCode ="INDICATOR"
                            },
                        },
                        SubsidiaryTenderingCriterionPropertyGroups = new TenderingCriterionPropertyGroup[]
                        {
                            new TenderingCriterionPropertyGroup()
                            {
                                Id = new CriteriaTaxonomyIdentifier("73f0fe4c-4ed9-4343-8096-d898cf200146"),
                                PropertyGroupTypeCode = new PropertyGroupTypeCode("ONTRUE"),
                                TenderingCriterionProperties = new TenderingCriterionProperty[]
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
               };

    };
}



