using Hilma.Espd.EDM.CriterionModels.v2_1_0.Identifiers;
using Hilma.UBL.CommonAggregateComponents;

namespace Hilma.Espd.EDM.CriterionModels.v2_1_0
{

    public class CriterionHelper
    {
        public static TenderingCriterionPropertyGroup[] ConvictionsQuestionGroup =>
            new[]
                {
                    new TenderingCriterionPropertyGroup
                    {
                        _cardinality = CardinalityMetadata.ExactlyOne,
                        Id = new CriteriaTaxonomyIdentifier("7c637c0c-7703-4389-ba52-02997a055bd7"),
                        PropertyGroupTypeCode = PropertyGroupTypeCode.OnAlways,
                        TenderingCriterionProperties = new[]
                        {
                           new TenderingCriterionProperty
                           {
                             _cardinality = CardinalityMetadata.ExactlyOne,
                             Id = EuComGrowId.Random(),
                             TypeCode = CriterionElementType.Question,
                             Description ="common.yourAnswer.description",
                             ValueDataTypeCode = ResponseDataTypeCode.Indicator
                           }
                        },
                        SubsidiaryTenderingCriterionPropertyGroups = new[]
                        {
                            new TenderingCriterionPropertyGroup
                            {
                                _cardinality = CardinalityMetadata.ZeroOrMore,
                                Id = new CriteriaTaxonomyIdentifier("f5276600-a2b6-4ff6-a90e-b31fe19dae41"),
                                PropertyGroupTypeCode = PropertyGroupTypeCode.OnTrue,
                                TenderingCriterionProperties = new[]
                                {
                                   new TenderingCriterionProperty
                                   {
                                     _cardinality = CardinalityMetadata.ExactlyOne,
                                     Id = EuComGrowId.Random(),
                                     TypeCode = CriterionElementType.Question,
                                     Description ="convictions.dateOfConviction.description",
                                     ValueDataTypeCode = ResponseDataTypeCode.Date
                                   },
                                   new TenderingCriterionProperty
                                   {
                                     _cardinality = CardinalityMetadata.ExactlyOne,
                                     Id = EuComGrowId.Random(),
                                     TypeCode = CriterionElementType.Question,
                                     Description ="convictions.reason.description",
                                     ValueDataTypeCode = ResponseDataTypeCode.Description
                                   },
                                   new TenderingCriterionProperty
                                   {
                                     _cardinality = CardinalityMetadata.ExactlyOne,
                                     Id = EuComGrowId.Random(),
                                     TypeCode = CriterionElementType.Question,
                                     Description ="convictions.whoHasBeenConvicted.description",
                                     ValueDataTypeCode = ResponseDataTypeCode.Description
                                   },
                                   new TenderingCriterionProperty
                                   {
                                     _cardinality = CardinalityMetadata.ExactlyOne,
                                     Id = EuComGrowId.Random(),
                                     TypeCode = CriterionElementType.Question,
                                     Description ="convictions.lengthOfThePeriodOfExclusion.description",
                                     ValueDataTypeCode = ResponseDataTypeCode.Period
                                   }
                                },
                                SubsidiaryTenderingCriterionPropertyGroups = new[]
                                {
                                    new TenderingCriterionPropertyGroup
                                    {
                                        _cardinality = CardinalityMetadata.ExactlyOne,
                                        Id = new CriteriaTaxonomyIdentifier("5f9f09f7-f701-432c-9fdc-c22c124a74c9"),
                                        PropertyGroupTypeCode = PropertyGroupTypeCode.OnAlways,
                                        TenderingCriterionProperties = new[]
                                        {
                                            new TenderingCriterionProperty
                                            {
                                                 _cardinality = CardinalityMetadata.ExactlyOne,
                                                 Id = EuComGrowId.Random(),
                                                 TypeCode = CriterionElementType.Question,
                                                 Description ="convictions.measuresToDemonstrateYourReliability.description",
                                                 ValueDataTypeCode = ResponseDataTypeCode.Indicator
                                               }
                                        },
                                        SubsidiaryTenderingCriterionPropertyGroups = new[]
                                        {
                                            new TenderingCriterionPropertyGroup
                                            {
                                                _cardinality = CardinalityMetadata.Optional,
                                                Id = new CriteriaTaxonomyIdentifier("74e6c7b4-757b-4b40-ada6-fad6a997c310"),
                                                PropertyGroupTypeCode = PropertyGroupTypeCode.OnTrue,
                                                TenderingCriterionProperties = new[]
                                                {
                                                    new TenderingCriterionProperty
                                                    {
                                                         _cardinality = CardinalityMetadata.ExactlyOne,
                                                         Id = EuComGrowId.Random(),
                                                         TypeCode = CriterionElementType.Question,
                                                         Description ="common.pleaseDescribeThem.description",
                                                         ValueDataTypeCode = ResponseDataTypeCode.Description
                                                       }
                                                }
                                            }
                                        }
                                    }
                                }

                            }
                        }
                    },
                    new TenderingCriterionPropertyGroup
                    {
                        _cardinality = CardinalityMetadata.ExactlyOne,
                        Id = new CriteriaTaxonomyIdentifier("7458d42a-e581-4640-9283-34ceb3ad4345"),
                        PropertyGroupTypeCode = PropertyGroupTypeCode.OnAlways,
                        TenderingCriterionProperties = new[]
                        {
                           new TenderingCriterionProperty
                           {
                             _cardinality = CardinalityMetadata.ExactlyOne,
                             Id = EuComGrowId.Random(),
                             TypeCode = CriterionElementType.Question,
                             Description ="common.isThisInformationAvailableElectronically.description",
                             ValueDataTypeCode = ResponseDataTypeCode.Indicator
                           }
                        },
                        SubsidiaryTenderingCriterionPropertyGroups = TenderingCriterionURLGroup
                    }
                };
        public static TenderingCriterionPropertyGroup TurnOverisThisInformationAvailableElectronically =>
            new TenderingCriterionPropertyGroup()
            {
                 _cardinality = CardinalityMetadata.ExactlyOne,
                 Id = new CriteriaTaxonomyIdentifier("7458d42a-e581-4640-9283-34ceb3ad4345"),
                 PropertyGroupTypeCode = PropertyGroupTypeCode.OnAlways,
                 TenderingCriterionProperties = new[]
                 {
                     new TenderingCriterionProperty()
                     {
                       _cardinality = CardinalityMetadata.ExactlyOne,
                       TypeCode = CriterionElementType.Question,
                       Description = "common.isThisInformationAvailableElectronically.description",
                       ValueDataTypeCode = ResponseDataTypeCode.Indicator
                     }
                 },
                 SubsidiaryTenderingCriterionPropertyGroups = new TenderingCriterionPropertyGroup[]
                 {
                     new TenderingCriterionPropertyGroup()
                     {
                         _cardinality = CardinalityMetadata.ZeroOrMore,
                         Id = new CriteriaTaxonomyIdentifier("41dd2e9b-1bfd-44c7-93ee-56bd74a4334b"),
                         PropertyGroupTypeCode = PropertyGroupTypeCode.OnAlways,
                         TenderingCriterionProperties = new[]
                         {
                             new TenderingCriterionProperty()
                             {
                               _cardinality = CardinalityMetadata.OneOrMore,
                               TypeCode = CriterionElementType.Question,
                               Description = "common.evidenceSupplied",
                               ValueDataTypeCode = ResponseDataTypeCode.EvidenceIdentifier
                             }
                          }
                      }
                 }
            };
        // ReSharper disable once InconsistentNaming
        public static TenderingCriterionPropertyGroup[] Social_LawCriterionPropertyGroups =>
            new[]
               {

                   new TenderingCriterionPropertyGroup
                   {
                       _cardinality = CardinalityMetadata.ExactlyOne,
                       Id = new CriteriaTaxonomyIdentifier("976b5acb-c00f-46ca-8f83-5ce6abfdfe43"),
                       PropertyGroupTypeCode = PropertyGroupTypeCode.OnAlways,
                       TenderingCriterionProperties = new[]
                       {
                           new TenderingCriterionProperty
                           {
                             _cardinality = CardinalityMetadata.ExactlyOne,
                             Id = EuComGrowId.Random(),
                             TypeCode = CriterionElementType.Question,
                             Description ="common.yourAnswer.description",
                             ValueDataTypeCode = ResponseDataTypeCode.Indicator
                           }
                       },
                       SubsidiaryTenderingCriterionPropertyGroups = new[]
                       {
                           new TenderingCriterionPropertyGroup
                           {
                               _cardinality = CardinalityMetadata.Optional,
                               Id = new CriteriaTaxonomyIdentifier("64a2102c-4af1-4ecb-97b3-0c41907ec0f6"),
                               PropertyGroupTypeCode = PropertyGroupTypeCode.OnTrue,
                               TenderingCriterionProperties = new[]
                               {
                                   new TenderingCriterionProperty
                                   {
                                     _cardinality = CardinalityMetadata.ExactlyOne,
                                     Id = EuComGrowId.Random(),
                                     TypeCode = CriterionElementType.Question,
                                     Description ="common.pleaseDescribeThem.description",
                                     ValueDataTypeCode = ResponseDataTypeCode.Description
                                   }
                               },
                               SubsidiaryTenderingCriterionPropertyGroups = new[]
                               {
                                   new TenderingCriterionPropertyGroup
                                   {
                                       _cardinality = CardinalityMetadata.ExactlyOne,
                                       Id = new CriteriaTaxonomyIdentifier("5f9f09f7-f701-432c-9fdc-c22c124a74c9"),
                                       PropertyGroupTypeCode = PropertyGroupTypeCode.OnAlways,
                                       TenderingCriterionProperties = new[]
                                       {
                                           new TenderingCriterionProperty
                                           {
                                             _cardinality = CardinalityMetadata.ExactlyOne,
                                             Id = EuComGrowId.Random(),
                                             TypeCode = CriterionElementType.Question,
                                             Description ="convictions.measuresToDemonstrateYourReliability.description",
                                             ValueDataTypeCode = ResponseDataTypeCode.Indicator
                                           }
                                       },
                                       SubsidiaryTenderingCriterionPropertyGroups = new[]
                                       {
                                           new TenderingCriterionPropertyGroup
                                           {
                                               _cardinality = CardinalityMetadata.Optional,
                                               Id = new CriteriaTaxonomyIdentifier("74e6c7b4-757b-4b40-ada6-fad6a997c310"),
                                               PropertyGroupTypeCode = PropertyGroupTypeCode.OnTrue,
                                               TenderingCriterionProperties = new[]
                                               {
                                                   new TenderingCriterionProperty
                                                   {
                                                     _cardinality = CardinalityMetadata.ExactlyOne,
                                                     Id = EuComGrowId.Random(),
                                                     TypeCode = CriterionElementType.Question,
                                                     Description ="common.pleaseDescribeThem.description",
                                                     ValueDataTypeCode = ResponseDataTypeCode.Description
                                                   }
                                               }
                                           }

                                       }
                                   }

                               }
                           }

                       }
                   },
                   new TenderingCriterionPropertyGroup
                   {
                        _cardinality = CardinalityMetadata.ExactlyOne,
                        Id = new CriteriaTaxonomyIdentifier("7458d42a-e581-4640-9283-34ceb3ad4345"),
                        PropertyGroupTypeCode = PropertyGroupTypeCode.OnAlways,
                        TenderingCriterionProperties = new[]
                        {
                           new TenderingCriterionProperty
                           {
                             _cardinality = CardinalityMetadata.ExactlyOne,
                             Id = EuComGrowId.Random(),
                             TypeCode = CriterionElementType.Question,
                             Description ="common.isThisInformationAvailableElectronically.description",
                             ValueDataTypeCode = ResponseDataTypeCode.Indicator
                           }
                        },
                        SubsidiaryTenderingCriterionPropertyGroups = TenderingCriterionURLGroup
                    }

               };

        public static TenderingCriterionPropertyGroup[] TenderingCriterionURLGroup =>
            new[]
            {
                new TenderingCriterionPropertyGroup
                {
                    _cardinality = CardinalityMetadata.Optional,
                    Id = new CriteriaTaxonomyIdentifier("41dd2e9b-1bfd-44c7-93ee-56bd74a4334b"),
                    PropertyGroupTypeCode = PropertyGroupTypeCode.OnTrue,
                    TenderingCriterionProperties = new[]
                    {
                        new TenderingCriterionProperty
                        {
                            _cardinality = CardinalityMetadata.OneOrMore,
                            Id = EuComGrowId.Random(),
                            TypeCode = CriterionElementType.Question,
                            Description ="common.evidenceSupplied",
                            ValueDataTypeCode = ResponseDataTypeCode.EvidenceIdentifier
                        }
                    }
                }
            };

        public static TenderingCriterionPropertyGroup[] Business =>
             new[]
               {
                   new TenderingCriterionPropertyGroup
                   {
                       _cardinality = CardinalityMetadata.ExactlyOne,
                       Id = new CriteriaTaxonomyIdentifier("d91c11a1-f19e-4b83-8ade-c4be2bf00555"),
                       PropertyGroupTypeCode = PropertyGroupTypeCode.OnAlways,
                       TenderingCriterionProperties = new[]
                       {
                           new TenderingCriterionProperty
                           {
                             _cardinality = CardinalityMetadata.ExactlyOne,
                             Id = EuComGrowId.Random(),
                             TypeCode = CriterionElementType.Question,
                             Description ="common.yourAnswer.description",
                             ValueDataTypeCode = ResponseDataTypeCode.Indicator
                           }
                       },

                       SubsidiaryTenderingCriterionPropertyGroups = new[]
                       {
                           new TenderingCriterionPropertyGroup
                           {
                               Id = new CriteriaTaxonomyIdentifier("aeef523b-c8fc-4dba-9c34-03e34812567b"),
                               PropertyGroupTypeCode = PropertyGroupTypeCode.OnTrue,
                               TenderingCriterionProperties = new[]
                               {
                                   new TenderingCriterionProperty
                                   {
                                     _cardinality = CardinalityMetadata.ExactlyOne,
                                     Id = EuComGrowId.Random(),
                                     TypeCode = CriterionElementType.Question,
                                     Description ="common.pleaseDescribeThem.description",
                                     ValueDataTypeCode = ResponseDataTypeCode.Description
                                   },
                                   new TenderingCriterionProperty
                                   {
                                     _cardinality = CardinalityMetadata.ExactlyOne,
                                     Id = EuComGrowId.Random(),
                                     TypeCode = CriterionElementType.Question,
                                     Description ="business.indicateReasonsForBeingNeverthelessToPerformTheContract.description",
                                     ValueDataTypeCode = ResponseDataTypeCode.Description
                                   }
                               }
                           }

                       }
                   },
                   new TenderingCriterionPropertyGroup
                   {
                       _cardinality = CardinalityMetadata.ExactlyOne,
                       Id = new CriteriaTaxonomyIdentifier("7458d42a-e581-4640-9283-34ceb3ad4345"),
                       PropertyGroupTypeCode = PropertyGroupTypeCode.OnAlways,
                       TenderingCriterionProperties = new[]
                       {
                           new TenderingCriterionProperty
                           {
                             _cardinality = CardinalityMetadata.ExactlyOne,
                             Id = EuComGrowId.Random(),
                             TypeCode = CriterionElementType.Question,
                             Description ="common.informationAvailableFromEUDb.description",
                             ValueDataTypeCode = ResponseDataTypeCode.Indicator
                           }
                       },
                       SubsidiaryTenderingCriterionPropertyGroups = TenderingCriterionURLGroup
                   }


             };

        public static TenderingCriterionPropertyGroup[] MisconductQuestions =>
            new[]
               {
                   new TenderingCriterionPropertyGroup
                   {
                       _cardinality = CardinalityMetadata.ExactlyOne,
                       Id = new CriteriaTaxonomyIdentifier("67362ec7-cec3-4cb8-a38e-5d7a2a31e6d8"),
                       PropertyGroupTypeCode = PropertyGroupTypeCode.OnAlways,
                       TenderingCriterionProperties = new[]
                       {
                           new TenderingCriterionProperty
                           {
                             _cardinality = CardinalityMetadata.ExactlyOne,
                             Id = EuComGrowId.Random(),
                             TypeCode = CriterionElementType.Question,
                             Description ="common.yourAnswer.description",
                             ValueDataTypeCode = ResponseDataTypeCode.Indicator
                           }
                       },
                       SubsidiaryTenderingCriterionPropertyGroups = new[]
                       {
                           new TenderingCriterionPropertyGroup
                           {
                               _cardinality = CardinalityMetadata.Optional,
                               Id = new CriteriaTaxonomyIdentifier("2cbcf978-765c-40aa-996b-b1d082485cef"),
                               PropertyGroupTypeCode = PropertyGroupTypeCode.OnTrue,
                               TenderingCriterionProperties = new[]
                               {
                                   new TenderingCriterionProperty
                                   {
                                     _cardinality = CardinalityMetadata.ExactlyOne,
                                     Id = EuComGrowId.Random(),
                                     TypeCode = CriterionElementType.Question,
                                     Description ="common.pleaseDescribeThem.description",
                                     ValueDataTypeCode = ResponseDataTypeCode.Description
                                   }
                               },
                               SubsidiaryTenderingCriterionPropertyGroups = new[]
                               {
                                    new TenderingCriterionPropertyGroup
                                    {
                                       _cardinality = CardinalityMetadata.ExactlyOne,
                                       Id = new CriteriaTaxonomyIdentifier("5f9f09f7-f701-432c-9fdc-c22c124a74c9"),
                                       PropertyGroupTypeCode = PropertyGroupTypeCode.OnAlways,
                                       TenderingCriterionProperties = new[]
                                       {
                                           new TenderingCriterionProperty
                                           {
                                             _cardinality = CardinalityMetadata.ExactlyOne,
                                             Id = EuComGrowId.Random(),
                                             TypeCode = CriterionElementType.Question,
                                             Description ="misconduct.haveYouTakenMeasuresToDemonstrateYourReliability.description",
                                             ValueDataTypeCode = ResponseDataTypeCode.Indicator
                                           }
                                       },
                                       SubsidiaryTenderingCriterionPropertyGroups = new[]
                                       {
                                           new TenderingCriterionPropertyGroup
                                           {
                                               Id = new CriteriaTaxonomyIdentifier("74e6c7b4-757b-4b40-ada6-fad6a997c310"),
                                               PropertyGroupTypeCode = PropertyGroupTypeCode.OnAlways,
                                               TenderingCriterionProperties = new[]
                                               {
                                                   new TenderingCriterionProperty
                                                   {
                                                     _cardinality = CardinalityMetadata.ExactlyOne,
                                                     Id = EuComGrowId.Random(),
                                                     TypeCode = CriterionElementType.Question,
                                                     Description ="common.pleaseDescribeThem.description",
                                                     ValueDataTypeCode = ResponseDataTypeCode.Description
                                                   }
                                               }

                                           }
                                       }

                                    }
                               }
                           }
                           
                       }
                   },
                   new TenderingCriterionPropertyGroup
                   {
                       _cardinality = CardinalityMetadata.ExactlyOne,
                       Id = new CriteriaTaxonomyIdentifier("7458d42a-e581-4640-9283-34ceb3ad4345"),
                       PropertyGroupTypeCode = PropertyGroupTypeCode.OnAlways,
                       TenderingCriterionProperties = new[]
                       {
                           new TenderingCriterionProperty
                           {
                             _cardinality = CardinalityMetadata.ExactlyOne,
                             Id = EuComGrowId.Random(),
                             TypeCode = CriterionElementType.Question,
                             Description ="common.informationAvailableFromEUDb.description",
                             ValueDataTypeCode = ResponseDataTypeCode.Indicator
                           }
                       },
                       SubsidiaryTenderingCriterionPropertyGroups = TenderingCriterionURLGroup
                   }
               };

        public static TenderingCriterionPropertyGroup[] ConflictOfInterestQuestions =>
            new[]
               {
                    new TenderingCriterionPropertyGroup
                    {
                        _cardinality = CardinalityMetadata.ExactlyOne,
                        Id = new CriteriaTaxonomyIdentifier("67362ec7-cec3-4cb8-a38e-5d7a2a31e6d8"),
                        PropertyGroupTypeCode = PropertyGroupTypeCode.OnAlways,
                        TenderingCriterionProperties = new[]
                        {
                            new TenderingCriterionProperty
                            {
                                _cardinality = CardinalityMetadata.ExactlyOne,
                                Id = EuComGrowId.Random(),
                                TypeCode = CriterionElementType.Question,
                                Description ="common.yourAnswer.description",
                                ValueDataTypeCode = ResponseDataTypeCode.Indicator
                            }
                        },
                        SubsidiaryTenderingCriterionPropertyGroups = new[]
                        {
                            new TenderingCriterionPropertyGroup
                            {
                                _cardinality = CardinalityMetadata.Optional,
                                Id = new CriteriaTaxonomyIdentifier("73f0fe4c-4ed9-4343-8096-d898cf200146"),
                                PropertyGroupTypeCode = PropertyGroupTypeCode.OnTrue,
                                TenderingCriterionProperties = new[]
                                {
                                    new TenderingCriterionProperty
                                    {
                                        _cardinality = CardinalityMetadata.ExactlyOne,
                                        Id = EuComGrowId.Random(),
                                        TypeCode = CriterionElementType.Question,
                                        Description ="common.pleaseDescribeThem.description",
                                        ValueDataTypeCode = ResponseDataTypeCode.Description
                                    }
                                }
                            }

                        }

                    },
                    new TenderingCriterionPropertyGroup
                    {
                       _cardinality = CardinalityMetadata.ExactlyOne,
                       Id = new CriteriaTaxonomyIdentifier("7458d42a-e581-4640-9283-34ceb3ad4345"),
                       PropertyGroupTypeCode = PropertyGroupTypeCode.OnAlways,
                       TenderingCriterionProperties = new[]
                       {
                           new TenderingCriterionProperty
                           {
                             _cardinality = CardinalityMetadata.ExactlyOne,
                             Id = EuComGrowId.Random(),
                             TypeCode = CriterionElementType.Question,
                             Description ="common.informationAvailableFromEUDb.description",
                             ValueDataTypeCode = ResponseDataTypeCode.Indicator
                           }
                       },
                       SubsidiaryTenderingCriterionPropertyGroups = TenderingCriterionURLGroup
                   }
               };

        public static TenderingCriterionPropertyGroup[] SuitabilityRegisterQuestionsGroups =>
          new[]
          {
            new TenderingCriterionPropertyGroup
            {
              _cardinality = CardinalityMetadata.OneOrMore,
              Id = new CriteriaTaxonomyIdentifier("a53561d5-6614-4dbe-987e-b96f35387f46"),
              PropertyGroupTypeCode = PropertyGroupTypeCode.OnAlways,
              TenderingCriterionProperties = new[]
              {
                new TenderingCriterionProperty
                {
                  _cardinality = CardinalityMetadata.ExactlyOne,
                  Id = EuComGrowId.Random(),
                  TypeCode = CriterionElementType.Caption,
                  Description = "common.lotTheRequirementAppliesTo.description",
                  ValueDataTypeCode = ResponseDataTypeCode.None 
                },
                new TenderingCriterionProperty
                {
                  _cardinality = CardinalityMetadata.ZeroOrMore,
                  Id = EuComGrowId.Random(),
                  TypeCode = CriterionElementType.Requirement,
                  Description = "common.lotId.description",
                  ValueDataTypeCode = ResponseDataTypeCode.LotIdentifier

                }

              },
              SubsidiaryTenderingCriterionPropertyGroups =
                new[]
                {
                  new TenderingCriterionPropertyGroup
                  {
                    _cardinality = CardinalityMetadata.ExactlyOne,
                    Id = new CriteriaTaxonomyIdentifier("3aacb82e-afba-440c-b64e-1834007965a2"),
                    PropertyGroupTypeCode = PropertyGroupTypeCode.OnAlways,
                    TenderingCriterionProperties = new[]
                    {
                      new TenderingCriterionProperty
                      {
                        _cardinality = CardinalityMetadata.ExactlyOne,
                        Id = EuComGrowId.Random(),
                        TypeCode = CriterionElementType.Requirement,
                        Description = "common.registerName.description",
                        ValueDataTypeCode = ResponseDataTypeCode.Description

                      },
                      new TenderingCriterionProperty
                      {
                        _cardinality = CardinalityMetadata.ExactlyOne,
                        Id = EuComGrowId.Random(),
                        TypeCode = CriterionElementType.Requirement,
                        Description = "common.url.description",
                        ValueDataTypeCode = ResponseDataTypeCode.Url
                      }
                    }

                  },
                  new TenderingCriterionPropertyGroup
                  {
                    _cardinality = CardinalityMetadata.OneOrMore,
                    Id = new CriteriaTaxonomyIdentifier("6cce6b8e-c53d-4598-8150-ac49aba3b9c7"),
                    PropertyGroupTypeCode = PropertyGroupTypeCode.OnAlways,
                    TenderingCriterionProperties = new[]
                    {
                      new TenderingCriterionProperty
                      {
                        _cardinality = CardinalityMetadata.ExactlyOne,
                        Id = EuComGrowId.Random(),
                        TypeCode = CriterionElementType.Question,
                        Description = "common.yourAnswer",
                        ValueDataTypeCode = ResponseDataTypeCode.Indicator
                      }
                    },
                    SubsidiaryTenderingCriterionPropertyGroups = new[]
                    {
                      new TenderingCriterionPropertyGroup
                      {
                        _cardinality = CardinalityMetadata.Optional,
                        Id = new CriteriaTaxonomyIdentifier("70d5bbcf-0581-4d0f-b5c7-8b604a791972"),
                        PropertyGroupTypeCode = PropertyGroupTypeCode.OnTrue,
                        TenderingCriterionProperties = new[]
                        {
                          new TenderingCriterionProperty
                          {
                            _cardinality = CardinalityMetadata.Optional,
                            Id = EuComGrowId.Random(),
                            TypeCode = CriterionElementType.Question,
                            Description = "common.registrationNumber.description",
                            ValueDataTypeCode = ResponseDataTypeCode.Description
                          }
                        }
                      },
                      new TenderingCriterionPropertyGroup
                      {
                        _cardinality = CardinalityMetadata.Optional,
                        Id = new CriteriaTaxonomyIdentifier("3a4a5421-81cc-468e-b69f-b86bf8c7932d"),
                        PropertyGroupTypeCode = PropertyGroupTypeCode.OnFalse,
                        TenderingCriterionProperties = new[]
                        {
                          new TenderingCriterionProperty
                          {
                            _cardinality = CardinalityMetadata.ExactlyOne,
                            Id = EuComGrowId.Random(),
                            TypeCode = CriterionElementType.Question,
                            Description = "common.reasonWhyNotRegistered.description",
                            ValueDataTypeCode = ResponseDataTypeCode.Description
                          }
                        }
                      },
                      new TenderingCriterionPropertyGroup
                      {
                        _cardinality = CardinalityMetadata.ExactlyOne,
                        Id = new CriteriaTaxonomyIdentifier("7458d42a-e581-4640-9283-34ceb3ad4345"),
                        PropertyGroupTypeCode = PropertyGroupTypeCode.OnAlways,
                        TenderingCriterionProperties = new[]
                        {
                          new TenderingCriterionProperty
                          {
                            _cardinality = CardinalityMetadata.ExactlyOne,
                            Id = EuComGrowId.Random(),
                            TypeCode = CriterionElementType.Question,
                            Description = "common.isThisInformationAvailableElectronically.description",
                            ValueDataTypeCode = ResponseDataTypeCode.Indicator
                          }

                        },
                        SubsidiaryTenderingCriterionPropertyGroups = TenderingCriterionURLGroup
                      }
                    }
                  }
                }
            }
          };
    }
}



