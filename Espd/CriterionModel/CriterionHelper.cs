using Hilma.Espd.EDM.CriterionModel.Identifiers;
using Hilma.UBL.CommonAggregateComponents;

namespace Hilma.Espd.EDM.CriterionModel
{
    public class CriterionHelper
    {
        public static TenderingCriterionPropertyGroup[] ConvictionsQuestionGroup =>
            new[]
                {
                    new TenderingCriterionPropertyGroup()
                    {
                        Id = new CriteriaTaxonomyIdentifier("7c637c0c-7703-4389-ba52-02997a055bd7"),
                        PropertyGroupTypeCode = new PropertyGroupTypeCode("ON*"),
                        TenderingCriterionProperties = new[]
                        {
                           new TenderingCriterionProperty()
                           {
                             TypeCode = new CriterionElementType("QUESTION"),
                             Description ="common.yourAnswer.description",
                             ValueDataTypeCode = new ResponseDataTypeCode("INDICATOR")
                           }
                        },
                        SubsidiaryTenderingCriterionPropertyGroups = new[]
                        {
                            new TenderingCriterionPropertyGroup()
                            {
                                Id = new CriteriaTaxonomyIdentifier("41dd2e9b-1bfd-44c7-93ee-56bd74a4334b"),
                                PropertyGroupTypeCode = new PropertyGroupTypeCode("ONTRUE"),
                                TenderingCriterionProperties = new[]
                                {
                                   new TenderingCriterionProperty()
                                   {
                                     TypeCode = new CriterionElementType("QUESTION"),
                                     Description ="convictions.dateOfConviction.description",
                                     ValueDataTypeCode =new ResponseDataTypeCode("DATE")
                                   },
                                   new TenderingCriterionProperty()
                                   {
                                     TypeCode = new CriterionElementType("QUESTION"),
                                     Description ="convictions.reason.description",
                                     ValueDataTypeCode = new ResponseDataTypeCode("DESCRIPTION")
                                   },
                                   new TenderingCriterionProperty()
                                   {
                                     TypeCode = new CriterionElementType("QUESTION"),
                                     Description ="convictions.whoHasBeenConvicted.description",
                                     ValueDataTypeCode = new ResponseDataTypeCode("DESCRIPTION")
                                   },
                                   new TenderingCriterionProperty()
                                   {
                                     TypeCode = new CriterionElementType("QUESTION"),
                                     Description ="convictions.lengthOfThePeriodOfExclusion.description",
                                     ValueDataTypeCode =new ResponseDataTypeCode("PERIOD")
                                   }
                                },
                                SubsidiaryTenderingCriterionPropertyGroups = new[]
                                {
                                    new TenderingCriterionPropertyGroup()
                                    {
                                        Id = new CriteriaTaxonomyIdentifier("5f9f09f7-f701-432c-9fdc-c22c124a74c9"),
                                        PropertyGroupTypeCode = new PropertyGroupTypeCode("ON*"),
                                        TenderingCriterionProperties = new[]
                                        {
                                            new TenderingCriterionProperty()
                                               {
                                                 TypeCode = new CriterionElementType("QUESTION"),
                                                 Description ="convictions.measuresToDemonstrateYourReliability.description",
                                                 ValueDataTypeCode =new ResponseDataTypeCode("INDICATOR")
                                               }
                                        },
                                        SubsidiaryTenderingCriterionPropertyGroups = new[]
                                        {
                                            new TenderingCriterionPropertyGroup()
                                            {
                                                Id = new CriteriaTaxonomyIdentifier("74e6c7b4-757b-4b40-ada6-fad6a997c310"),
                                                PropertyGroupTypeCode = new PropertyGroupTypeCode("ONTRUE"),
                                                TenderingCriterionProperties = new[]
                                                {
                                                    new TenderingCriterionProperty()
                                                       {
                                                         TypeCode = new CriterionElementType("QUESTION"),
                                                         Description ="common.pleaseDescribeThem.description",
                                                         ValueDataTypeCode = new ResponseDataTypeCode("DESCRIPTION")
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
                        TenderingCriterionProperties = new[]
                        {
                           new TenderingCriterionProperty()
                           {
                             TypeCode = new CriterionElementType("QUESTION"),
                             Description ="common.informationAvailableFromEUDb.description",
                             ValueDataTypeCode = new ResponseDataTypeCode("INDICATOR")
                           }
                        },
                        SubsidiaryTenderingCriterionPropertyGroups = TenderingCriterionURLGroup
                    }
                };

        // ReSharper disable once InconsistentNaming
        public static TenderingCriterionPropertyGroup[] Social_LawCriterionPropertyGroups =>
            new[]
               {

                   new TenderingCriterionPropertyGroup()
                   {
                       Id = new CriteriaTaxonomyIdentifier("976b5acb-c00f-46ca-8f83-5ce6abfdfe43"),
                       PropertyGroupTypeCode = new PropertyGroupTypeCode("ON*"),
                       TenderingCriterionProperties = new[]
                       {
                           new TenderingCriterionProperty()
                           {
                             TypeCode = new CriterionElementType("QUESTION"),
                             Description ="common.yourAnswer.description",
                             ValueDataTypeCode = new ResponseDataTypeCode("INDICATOR")
                           },
                       },
                       SubsidiaryTenderingCriterionPropertyGroups = new[]
                       {
                           new TenderingCriterionPropertyGroup()
                           {
                               Id = new CriteriaTaxonomyIdentifier("64a2102c-4af1-4ecb-97b3-0c41907ec0f6"),
                               PropertyGroupTypeCode = new PropertyGroupTypeCode("ONTRUE"),
                               TenderingCriterionProperties = new[]
                               {
                                   new TenderingCriterionProperty()
                                   {
                                     TypeCode = new CriterionElementType("QUESTION"),
                                     Description ="common.pleaseDescribeThem.description",
                                     ValueDataTypeCode =new ResponseDataTypeCode("DESCRIPTION")
                                   },
                               },
                               SubsidiaryTenderingCriterionPropertyGroups = new[]
                               {
                                   new TenderingCriterionPropertyGroup()
                                   {
                                       Id = new CriteriaTaxonomyIdentifier("5f9f09f7-f701-432c-9fdc-c22c124a74c9"),
                                       PropertyGroupTypeCode = new PropertyGroupTypeCode("ON*"),
                                       TenderingCriterionProperties = new[]
                                       {
                                           new TenderingCriterionProperty()
                                           {
                                             TypeCode = new CriterionElementType("QUESTION"),
                                             Description ="convictions.measuresToDemonstrateYourReliability.description",
                                             ValueDataTypeCode =new ResponseDataTypeCode("DESCRIPTION")
                                           },
                                       },
                                       SubsidiaryTenderingCriterionPropertyGroups = new[]
                                       {
                                           new TenderingCriterionPropertyGroup()
                                           {
                                               Id = new CriteriaTaxonomyIdentifier("74e6c7b4-757b-4b40-ada6-fad6a997c310"),
                                               PropertyGroupTypeCode = new PropertyGroupTypeCode("ONTRUE"),
                                               TenderingCriterionProperties = new[]
                                               {
                                                   new TenderingCriterionProperty()
                                                   {
                                                     TypeCode = new CriterionElementType("QUESTION"),
                                                     Description ="common.pleaseDescribeThem.description",
                                                     ValueDataTypeCode = new ResponseDataTypeCode("DESCRIPTION")
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
            new[]
            {
                new TenderingCriterionPropertyGroup()
                {
                    Id = new CriteriaTaxonomyIdentifier("0a166f0a-0c5f-42b0-81e9-0fc9fa598a48"),
                    PropertyGroupTypeCode = new PropertyGroupTypeCode("ONTRUE"),
                    TenderingCriterionProperties = new[]
                    {
                        new TenderingCriterionProperty()
                        {
                            TypeCode = new CriterionElementType("QUESTION"),
                            Description ="common.url.description",
                            ValueDataTypeCode = new ResponseDataTypeCode("EVIDENCE_URL")                        },
                        new TenderingCriterionProperty()
                        {
                            TypeCode = new CriterionElementType("QUESTION"),
                            Description ="common.verificationCode.description",
                            ValueDataTypeCode = new ResponseDataTypeCode("DESCRIPTION")
                        },
                        new TenderingCriterionProperty()
                        {
                            TypeCode = new CriterionElementType("QUESTION"),
                            Description ="common.issuer.description",
                            ValueDataTypeCode = new ResponseDataTypeCode("DESCRIPTION")
                        }
                    }
                }
            };

        public static TenderingCriterionPropertyGroup[] Business =>
             new[]
               {
                   new TenderingCriterionPropertyGroup()
                   {
                       Id = new CriteriaTaxonomyIdentifier("d91c11a1-f19e-4b83-8ade-c4be2bf00555"),
                       PropertyGroupTypeCode = new PropertyGroupTypeCode("ON*"),
                       TenderingCriterionProperties = new[]
                       {
                           new TenderingCriterionProperty()
                           {
                             TypeCode = new CriterionElementType("QUESTION"),
                             Description ="common.yourAnswer.description",
                             ValueDataTypeCode = new ResponseDataTypeCode("INDICATOR")
                           },
                       },

                       SubsidiaryTenderingCriterionPropertyGroups = new[]
                       {
                           new TenderingCriterionPropertyGroup()
                           {
                               Id = new CriteriaTaxonomyIdentifier("aeef523b-c8fc-4dba-9c34-03e34812567b"),
                               PropertyGroupTypeCode = new PropertyGroupTypeCode("ONTRUE"),
                               TenderingCriterionProperties = new[]
                               {
                                   new TenderingCriterionProperty()
                                   {
                                     TypeCode = new CriterionElementType("QUESTION"),
                                     Description ="common.pleaseDescribeThem.description",
                                     ValueDataTypeCode = new ResponseDataTypeCode("DESCRIPTION")
                                   },
                                   new TenderingCriterionProperty()
                                   {
                                     TypeCode = new CriterionElementType("QUESTION"),
                                     Description ="business.indicateReasonsForBeingNeverthelessToPerformTheContract.description",
                                     ValueDataTypeCode = new ResponseDataTypeCode("DESCRIPTION")
                                   },
                               }
                           }

                       }
                   },
                   new TenderingCriterionPropertyGroup()
                   {
                       Id = new CriteriaTaxonomyIdentifier("9026e403-3eb6-4705-a9e9-e21a1efc867d"),
                       PropertyGroupTypeCode = new PropertyGroupTypeCode("ON*"),
                       TenderingCriterionProperties = new[]
                       {
                           new TenderingCriterionProperty()
                           {
                             TypeCode = new CriterionElementType("QUESTION"),
                             Description ="common.informationAvailableFromEUDb.description",
                             ValueDataTypeCode = new ResponseDataTypeCode("INDICATOR")
                           },
                       },

                       SubsidiaryTenderingCriterionPropertyGroups = CriterionHelper.TenderingCriterionURLGroup
                   }


             };

        public static TenderingCriterionPropertyGroup[] MisconductQuestions =>
            new[]
               {
                   new TenderingCriterionPropertyGroup()
                   {
                       Id = new CriteriaTaxonomyIdentifier("67362ec7-cec3-4cb8-a38e-5d7a2a31e6d8"),
                       PropertyGroupTypeCode = new PropertyGroupTypeCode("ON*"),
                       TenderingCriterionProperties = new[]
                       {
                           new TenderingCriterionProperty()
                           {
                             TypeCode = new CriterionElementType("QUESTION"),
                             Description ="common.yourAnswer.description",
                             ValueDataTypeCode = new ResponseDataTypeCode("INDICATOR")
                           },
                       },
                       SubsidiaryTenderingCriterionPropertyGroups = new[]
                       {
                           new TenderingCriterionPropertyGroup()
                           {
                               Id = new CriteriaTaxonomyIdentifier("2cbcf978-765c-40aa-996b-b1d082485cef"),
                               PropertyGroupTypeCode = new PropertyGroupTypeCode("ONTRUE"),
                               TenderingCriterionProperties = new[]
                               {
                                   new TenderingCriterionProperty()
                                   {
                                     TypeCode = new CriterionElementType("QUESTION"),
                                     Description ="common.pleaseDescribeThem.description",
                                     ValueDataTypeCode = new ResponseDataTypeCode("INDICATOR")
                                   },
                               },

                           },
                            new TenderingCriterionPropertyGroup()
                           {
                               Id = new CriteriaTaxonomyIdentifier("5f9f09f7-f701-432c-9fdc-c22c124a74c9"),
                               PropertyGroupTypeCode = new PropertyGroupTypeCode("ON*"),
                               TenderingCriterionProperties = new[]
                               {
                                   new TenderingCriterionProperty()
                                   {
                                     TypeCode = new CriterionElementType("QUESTION"),
                                     Description ="misconduct.haveYouTakenMeasuresToDemonstrateYourReliability.description",
                                     ValueDataTypeCode = new ResponseDataTypeCode("INDICATOR")
                                   },
                               },
                               SubsidiaryTenderingCriterionPropertyGroups = new[]
                               {
                                   new TenderingCriterionPropertyGroup()
                                   {
                                       Id = new CriteriaTaxonomyIdentifier("74e6c7b4-757b-4b40-ada6-fad6a997c310"),
                                       PropertyGroupTypeCode = new PropertyGroupTypeCode("ON*"),
                                       TenderingCriterionProperties = new[]
                                       {
                                           new TenderingCriterionProperty()
                                           {
                                             TypeCode = new CriterionElementType("QUESTION"),
                                             Description ="common.pleaseDescribeThem.description",
                                             ValueDataTypeCode = new ResponseDataTypeCode("INDICATOR")
                                           },
                                       },

                                   }
                               }

                           }
                       }
                   }
               };

        public static TenderingCriterionPropertyGroup[] ConflictOfInterestQuestions =>
            new[]
               {
                    new TenderingCriterionPropertyGroup()
                    {
                        Id = new CriteriaTaxonomyIdentifier("67362ec7-cec3-4cb8-a38e-5d7a2a31e6d8"),
                        PropertyGroupTypeCode = new PropertyGroupTypeCode("ON*"),
                        TenderingCriterionProperties = new[]
                        {
                            new TenderingCriterionProperty()
                            {
                                TypeCode = new CriterionElementType("QUESTION"),
                                Description ="common.yourAnswer.description",
                                ValueDataTypeCode = new ResponseDataTypeCode("INDICATOR")
                            },
                        },
                        SubsidiaryTenderingCriterionPropertyGroups = new[]
                        {
                            new TenderingCriterionPropertyGroup()
                            {
                                Id = new CriteriaTaxonomyIdentifier("73f0fe4c-4ed9-4343-8096-d898cf200146"),
                                PropertyGroupTypeCode = new PropertyGroupTypeCode("ONTRUE"),
                                TenderingCriterionProperties = new[]
                                {
                                    new TenderingCriterionProperty()
                                    {
                                        TypeCode = new CriterionElementType("QUESTION"),
                                        Description ="common.pleaseDescribeThem.description",
                                        ValueDataTypeCode = new ResponseDataTypeCode("DESCRIPTION")
                                    },
                                }
                            }

                        }

                    }
               };

        public static TenderingCriterionPropertyGroup[] SuitabilityRegisterQuestionsGroups
        {
          get
          {
            return WrapWithLotRequirementGroup(
              new TenderingCriterionPropertyGroup()
              {
                Id = new CriteriaTaxonomyIdentifier("6cce6b8e-c53d-4598-8150-ac49aba3b9c7"),
                PropertyGroupTypeCode = new PropertyGroupTypeCode("ON*"),
                TenderingCriterionProperties = new[]
                {
                  new TenderingCriterionProperty()
                  {
                    TypeCode = new CriterionElementType("QUESTION"),
                    Description = "common.yourAnswer",
                    ValueDataTypeCode = new ResponseDataTypeCode("INDICATOR")
                  }
                },
                SubsidiaryTenderingCriterionPropertyGroups = new[]
                {
                  new TenderingCriterionPropertyGroup()
                  {
                    Id = new CriteriaTaxonomyIdentifier("3a4a5421-81cc-468e-b69f-b86bf8c7932d"),
                    PropertyGroupTypeCode = new PropertyGroupTypeCode("ONFALSE"),
                    TenderingCriterionProperties = new[]
                    {
                      new TenderingCriterionProperty()
                      {
                        TypeCode = new CriterionElementType("QUESTION"),
                        Description = "common.reasonWhyNotRegistered.description",
                        ValueDataTypeCode = new ResponseDataTypeCode("INDICATOR")
                      }
                    }
                  },
                  new TenderingCriterionPropertyGroup()
                  {
                    Id = new CriteriaTaxonomyIdentifier("9026e403-3eb6-4705-a9e9-e21a1efc867d"),
                    PropertyGroupTypeCode = new PropertyGroupTypeCode("ON*"),
                    TenderingCriterionProperties = new[]
                    {
                      new TenderingCriterionProperty()
                      {
                        TypeCode = new CriterionElementType("QUESTION"),
                        Description = "common.informationAvailableFromEUDb.description",
                        ValueDataTypeCode = new ResponseDataTypeCode("INDICATOR")
                      }

                    },
                    SubsidiaryTenderingCriterionPropertyGroups = TenderingCriterionURLGroup
                  }
                }
              });
          }
        }


        public static TenderingCriterionPropertyGroup[] WrapWithLotRequirementGroup( TenderingCriterionPropertyGroup group )
        {
          return new[]
          {
            new TenderingCriterionPropertyGroup()
            {
              Id = new CriteriaTaxonomyIdentifier("a53561d5-6614-4dbe-987e-b96f35387f4"),
              PropertyGroupTypeCode = new PropertyGroupTypeCode("ON*"),
              TenderingCriterionProperties = new[]
              {
                new TenderingCriterionProperty()
                {
                  TypeCode = new CriterionElementType("CAPTION"),
                  Description = "common.lotTheRequirementAppliesTo.description",
                  ValueDataTypeCode = new ResponseDataTypeCode("NONE"),
                },
                new TenderingCriterionProperty()
                {
                  TypeCode = new CriterionElementType("REQUIREMENT"),
                  Description = "common.lotId.description",
                  ValueDataTypeCode = new ResponseDataTypeCode("IDENTIFIER"),

                },

              },
              SubsidiaryTenderingCriterionPropertyGroups =
                new[]
                {
                  new TenderingCriterionPropertyGroup()
                  {
                    Id = new CriteriaTaxonomyIdentifier("3aacb82e-afba-440c-b64e-1834007965a2"),
                    PropertyGroupTypeCode = new PropertyGroupTypeCode("ON*"),
                    TenderingCriterionProperties = new[]
                    {
                      new TenderingCriterionProperty()
                      {
                        TypeCode = new CriterionElementType("REQUIREMENT"),
                        Description = "common.registerName.description",
                        ValueDataTypeCode = new ResponseDataTypeCode("DESCRIPTION"),

                      },
                      new TenderingCriterionProperty()
                      {
                        TypeCode = new CriterionElementType("REQUIREMENT"),
                        Description = "common.url.description",
                        ValueDataTypeCode = new ResponseDataTypeCode("URL")
                      },
                    }

                  },
                  group
                }
            }
          };
        }

    };
}



