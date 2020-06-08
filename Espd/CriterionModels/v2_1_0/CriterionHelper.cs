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
        public static TenderingCriterionPropertyGroup IsThisInformationAvailableElectronically =>
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
                       Id = EuComGrowId.Random(),
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
                         PropertyGroupTypeCode = PropertyGroupTypeCode.OnTrue,
                         TenderingCriterionProperties = new[]
                         {
                             new TenderingCriterionProperty()
                             {
                               _cardinality = CardinalityMetadata.OneOrMore,
                               Id = EuComGrowId.Random(),
                               TypeCode = CriterionElementType.Question,
                               Description = "common.evidenceSupplied.description",
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
                            Description ="common.evidenceSupplied.description",
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

        public static TenderingCriterionPropertyGroup[] References =>
          new[]
          {
            new TenderingCriterionPropertyGroup(){
                         _cardinality = CardinalityMetadata.OneOrMore,
                         Id = new CriteriaTaxonomyIdentifier("381bea15-9460-49f7-a6d0-15d13059de29"),
                         PropertyGroupTypeCode = PropertyGroupTypeCode.OnAlways,
                         TenderingCriterionProperties = new[]
                         {
                           new TenderingCriterionProperty()
                           {
                             _cardinality = CardinalityMetadata.ExactlyOne,
                             Id = EuComGrowId.Random(),
                             TypeCode = CriterionElementType.Requirement,
                             Description = "references.minimumNumberOfReferences.description",
                             ValueDataTypeCode = ResponseDataTypeCode.QuantityInteger
                           }
                         },
                         SubsidiaryTenderingCriterionPropertyGroups = new TenderingCriterionPropertyGroup[]
                         {
                             new TenderingCriterionPropertyGroup(){
                                 _cardinality = CardinalityMetadata.ExactlyOne,
                                 Id = new CriteriaTaxonomyIdentifier("53c9aad8-dc80-48f8-85d9-755c2aab8e95"),
                                 PropertyGroupTypeCode = PropertyGroupTypeCode.OnAlways,
                                 TenderingCriterionProperties = new[]
                                 {
                                 new TenderingCriterionProperty()
                                 {
                                     _cardinality = CardinalityMetadata.ZeroOrMore,
                                     Id = EuComGrowId.Random(),
                                     TypeCode = CriterionElementType.Caption,
                                     ValueDataTypeCode = ResponseDataTypeCode.None
                                 }
                                 },
                                 SubsidiaryTenderingCriterionPropertyGroups = new TenderingCriterionPropertyGroup[]
                                    {
                                        new TenderingCriterionPropertyGroup()
                                        {
                                            _cardinality = CardinalityMetadata.ZeroOrMore,
                                            Id = new CriteriaTaxonomyIdentifier("d663aca5-5f3c-4980-b825-81e1bd7db381"),
                                            PropertyGroupTypeCode = PropertyGroupTypeCode.OnAlways,
                                            TenderingCriterionProperties = new[]
                                            {
                                                new TenderingCriterionProperty()
                                                {
                                                _cardinality = CardinalityMetadata.OneOrMore,
                                                Id = EuComGrowId.Random(),
                                                TypeCode = CriterionElementType.Requirement,
                                                Description ="common.requirement.description",
                                                ValueDataTypeCode = ResponseDataTypeCode.Description
                                                }
                                            }
                                        },
                                        new TenderingCriterionPropertyGroup()
                                        {
                                            Description = new[] {"references.theRequirementsApplyToTheFollowingLots.description"},
                                            _cardinality = CardinalityMetadata.ZeroOrMore,
                                            Id = new CriteriaTaxonomyIdentifier("167ab253-4fb7-4e45-81be-b049fba44b3a"),
                                            PropertyGroupTypeCode = PropertyGroupTypeCode.OnAlways,
                                            TenderingCriterionProperties = new[]
                                            {
                                                new TenderingCriterionProperty()
                                                {
                                                _cardinality = CardinalityMetadata.ZeroOrMore,
                                                Id = EuComGrowId.Random(),
                                                TypeCode = CriterionElementType.Requirement,
                                                Description ="common.lotID.description",
                                                ValueDataTypeCode = ResponseDataTypeCode.LotIdentifier
                                                }
                                            }
                                        }

                                    }
                             },
                             new TenderingCriterionPropertyGroup(){
                                  _cardinality = CardinalityMetadata.OneOrMore,
                                  Id = new CriteriaTaxonomyIdentifier("a44e24e9-f878-4651-9ead-e0b1387dae09"),
                                  PropertyGroupTypeCode = PropertyGroupTypeCode.OnAlways,
                                  TenderingCriterionProperties = new[]
                                  {
                                      new TenderingCriterionProperty()
                                        {
                                            _cardinality = CardinalityMetadata.ExactlyOne,
                                            Id = EuComGrowId.Random(),
                                            Description ="references.lotsTheseReferencesApplyTo.description",
                                            TypeCode = CriterionElementType.Caption,
                                            ValueDataTypeCode = ResponseDataTypeCode.None
                                        }
                                  },
                                  SubsidiaryTenderingCriterionPropertyGroups = new TenderingCriterionPropertyGroup[]
                                  {
                                      new TenderingCriterionPropertyGroup()
                                      {
                                          _cardinality = CardinalityMetadata.ExactlyOne,
                                          Id = new CriteriaTaxonomyIdentifier("b9ac8ecf-5902-408e-a9a6-604568b35e1e"),
                                          PropertyGroupTypeCode = PropertyGroupTypeCode.OnAlways,
                                          TenderingCriterionProperties = new[]
                                          {
                                              new TenderingCriterionProperty()
                                                {
                                                _cardinality = CardinalityMetadata.OneOrMore,
                                                Id = EuComGrowId.Random(),
                                                TypeCode = CriterionElementType.Question,
                                                Description ="common.lotID.description",
                                                ValueDataTypeCode = ResponseDataTypeCode.LotIdentifier
                                                }
                                          }
                                      },
                                      new TenderingCriterionPropertyGroup()
                                      {
                                          _cardinality = CardinalityMetadata.ExactlyOne,
                                          Description = new[]{"references.reference.description"},
                                          Id = new CriteriaTaxonomyIdentifier("c8ec5c30-2c17-4936-abbb-392523d873e5"),
                                          PropertyGroupTypeCode = PropertyGroupTypeCode.OnAlways,
                                          TenderingCriterionProperties = new[]
                                          {
                                              new TenderingCriterionProperty()
                                                {
                                                _cardinality = CardinalityMetadata.ZeroOrMore,
                                                Id = EuComGrowId.Random(),
                                                TypeCode = CriterionElementType.Question,
                                                Description ="references.referenceDescription.description",
                                                ValueDataTypeCode = ResponseDataTypeCode.Description
                                                },
                                              new TenderingCriterionProperty()
                                                {
                                                _cardinality = CardinalityMetadata.ZeroOrMore,
                                                Id = EuComGrowId.Random(),
                                                TypeCode = CriterionElementType.Question,
                                                Description ="references.totalAmount.description",
                                                ValueDataTypeCode = ResponseDataTypeCode.Amount
                                                },
                                              new TenderingCriterionProperty()
                                                {
                                                _cardinality = CardinalityMetadata.ZeroOrMore,
                                                Id = EuComGrowId.Random(),
                                                TypeCode = CriterionElementType.Question,
                                                Description ="references.ActivityOfTheEconomicOperator.description",
                                                ValueDataTypeCode = ResponseDataTypeCode.Description
                                                },
                                              new TenderingCriterionProperty()
                                                {
                                                _cardinality = CardinalityMetadata.ZeroOrMore,
                                                Id = EuComGrowId.Random(),
                                                TypeCode = CriterionElementType.Question,
                                                Description ="references.specificAmount.description",
                                                ValueDataTypeCode = ResponseDataTypeCode.Amount
                                                },
                                              new TenderingCriterionProperty()
                                                {
                                                _cardinality = CardinalityMetadata.ZeroOrMore,
                                                Id = EuComGrowId.Random(),
                                                TypeCode = CriterionElementType.Question,
                                                Description ="references.PeriodStartAndEndDates.description",
                                                ValueDataTypeCode = ResponseDataTypeCode.Period
                                                }
                                              ,new TenderingCriterionProperty()
                                                {
                                                _cardinality = CardinalityMetadata.ZeroOrMore,
                                                Id = EuComGrowId.Random(),
                                                TypeCode = CriterionElementType.Question,
                                                Description ="references.confidential.description",
                                                ValueDataTypeCode = ResponseDataTypeCode.Indicator
                                                }
                                          },
                                          SubsidiaryTenderingCriterionPropertyGroups = new TenderingCriterionPropertyGroup[]
                                          {
                                              new TenderingCriterionPropertyGroup()
                                                {
                                                    _cardinality = CardinalityMetadata.ZeroOrMore,
                                                    Description = new[]{"references.recipients.description"},
                                                    Id = new CriteriaTaxonomyIdentifier("6afa7569-e4c4-4538-be89-84a82b2a301b"),
                                                    PropertyGroupTypeCode = PropertyGroupTypeCode.OnAlways,
                                                    TenderingCriterionProperties = new[]
                                                    {
                                                        new TenderingCriterionProperty(){
                                                            _cardinality = CardinalityMetadata.ZeroOrMore,
                                                            Id = EuComGrowId.Random(),
                                                            TypeCode = CriterionElementType.Question,
                                                            Description ="references.recipientName.description",
                                                            ValueDataTypeCode = ResponseDataTypeCode.Description
                                                        },
                                                        new TenderingCriterionProperty(){
                                                            _cardinality = CardinalityMetadata.Optional,
                                                            Id = EuComGrowId.Random(),
                                                            TypeCode = CriterionElementType.Question,
                                                            Description ="references.contactPersonName.description",
                                                            ValueDataTypeCode = ResponseDataTypeCode.Description
                                                        },
                                                        new TenderingCriterionProperty(){
                                                            _cardinality = CardinalityMetadata.Optional,
                                                            Id = EuComGrowId.Random(),
                                                            TypeCode = CriterionElementType.Question,
                                                            Description ="references.contactEmail.description",
                                                            ValueDataTypeCode = ResponseDataTypeCode.Description
                                                        },
                                                        new TenderingCriterionProperty(){
                                                            _cardinality = CardinalityMetadata.Optional,
                                                            Id = EuComGrowId.Random(),
                                                            TypeCode = CriterionElementType.Question,
                                                            Description ="references.contactTelephone.description",
                                                            ValueDataTypeCode = ResponseDataTypeCode.Description
                                                        }
                                                    }
                                                },
                                              new TenderingCriterionPropertyGroup()
                                              {
                                                  _cardinality = CardinalityMetadata.ExactlyOne,
                                                  Description = new[]{"references.recipients.description"},
                                                  Id = new CriteriaTaxonomyIdentifier("7458d42a-e581-4640-9283-34ceb3ad4345"),
                                                  PropertyGroupTypeCode = PropertyGroupTypeCode.OnAlways,
                                                  TenderingCriterionProperties = new[]
                                                  {
                                                      new TenderingCriterionProperty(){
                                                            _cardinality = CardinalityMetadata.ExactlyOne,
                                                            Id = EuComGrowId.Random(),
                                                            TypeCode = CriterionElementType.Question,
                                                            Description ="common.isThisInformationAvailableOnline.description",
                                                            ValueDataTypeCode = ResponseDataTypeCode.Indicator
                                                        }
                                                  },
                                                  SubsidiaryTenderingCriterionPropertyGroups = new TenderingCriterionPropertyGroup[]
                                                  {
                                                      new TenderingCriterionPropertyGroup()
                                                      {
                                                          _cardinality = CardinalityMetadata.Optional,
                                                          Id = new CriteriaTaxonomyIdentifier("41dd2e9b-1bfd-44c7-93ee-56bd74a4334b"),
                                                          PropertyGroupTypeCode = PropertyGroupTypeCode.OnTrue,
                                                          TenderingCriterionProperties = new[]
                                                          {
                                                              new TenderingCriterionProperty(){
                                                                    _cardinality = CardinalityMetadata.OneOrMore,
                                                                    Id = EuComGrowId.Random(),
                                                                    TypeCode = CriterionElementType.Question,
                                                                    Description ="common.evidenceSupplied.description",
                                                                    ValueDataTypeCode = ResponseDataTypeCode.EvidenceIdentifier
                                                                }
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
        public static TenderingCriterionPropertyGroup[] AbilitiesPersons =>
          new[]
          {
              new TenderingCriterionPropertyGroup()
                     {
                         _cardinality = CardinalityMetadata.ExactlyOne,
                         Id = new CriteriaTaxonomyIdentifier("1e73d705-9dc1-43f1-9b5c-2d0deac7bc5f"),
                         PropertyGroupTypeCode = PropertyGroupTypeCode.OnAlways,
                         TenderingCriterionProperties = new[]
                         {
                           new TenderingCriterionProperty()
                           {
                             _cardinality = CardinalityMetadata.Optional,
                             Id = EuComGrowId.Random(),
                             TypeCode = CriterionElementType.Requirement,
                             Description = "common.thisCriterionWillBeWeighted.description",
                             ValueDataTypeCode = ResponseDataTypeCode.WeightIndicator
                           }
                         },
                         SubsidiaryTenderingCriterionPropertyGroups = new TenderingCriterionPropertyGroup[]
                         {
                             new TenderingCriterionPropertyGroup()
                             {
                                 _cardinality = CardinalityMetadata.OneOrMore,
                                 Id = new CriteriaTaxonomyIdentifier("f156d97a-9700-4ad9-8d21-e3ac57102278"),
                                 PropertyGroupTypeCode = PropertyGroupTypeCode.OnAlways,
                                 TenderingCriterionProperties = new[]
                                 {
                                     new TenderingCriterionProperty()
                                     {
                                     _cardinality = CardinalityMetadata.ExactlyOne,
                                     Id = EuComGrowId.Random(),
                                     TypeCode = CriterionElementType.Requirement,
                                     Description = "common.requirement.description",
                                     ValueDataTypeCode = ResponseDataTypeCode.Description
                                     }
                                 },
                                 SubsidiaryTenderingCriterionPropertyGroups = new TenderingCriterionPropertyGroup[]
                                 {
                                     new TenderingCriterionPropertyGroup()
                                     {
                                         _cardinality = CardinalityMetadata.Optional,
                                         Id = new CriteriaTaxonomyIdentifier("609cc954-64be-4b4f-800a-f17589deb936"),
                                         PropertyGroupTypeCode = PropertyGroupTypeCode.OnAlways,
                                         TenderingCriterionProperties = new[]
                                         {
                                             new TenderingCriterionProperty()
                                             {
                                             _cardinality = CardinalityMetadata.ExactlyOne,
                                             Id = EuComGrowId.Random(),
                                             TypeCode = CriterionElementType.Caption,
                                             ValueDataTypeCode = ResponseDataTypeCode.None
                                             }
                                         },
                                         SubsidiaryTenderingCriterionPropertyGroups = new TenderingCriterionPropertyGroup[]
                                         {
                                             new TenderingCriterionPropertyGroup()
                                             {
                                                 _cardinality = CardinalityMetadata.ZeroOrMore,
                                                 Description = new[]{"abilitiesPersons.technician.description"},
                                                 Id = new CriteriaTaxonomyIdentifier("52ffcf91-3598-438f-8c3d-faf97da02602"),
                                                 PropertyGroupTypeCode = PropertyGroupTypeCode.OnAlways,
                                                 TenderingCriterionProperties = new[]
                                                 {
                                                     new TenderingCriterionProperty()
                                                     {
                                                         _cardinality = CardinalityMetadata.Optional,
                                                         Id = EuComGrowId.Random(),
                                                         TypeCode = CriterionElementType.Question,
                                                         Description = "common.firstName.description",
                                                         ValueDataTypeCode = ResponseDataTypeCode.Description
                                                     },
                                                     new TenderingCriterionProperty()
                                                     {
                                                         _cardinality = CardinalityMetadata.Optional,
                                                         Id = EuComGrowId.Random(),
                                                         TypeCode = CriterionElementType.Question,
                                                         Description = "common.lastName.description",
                                                         ValueDataTypeCode = ResponseDataTypeCode.Description
                                                     },
                                                     new TenderingCriterionProperty()
                                                     {
                                                         _cardinality = CardinalityMetadata.ExactlyOne,
                                                         Id = EuComGrowId.Random(),
                                                         TypeCode = CriterionElementType.Question,
                                                         Description = "abilitiesPersons.profession.description",
                                                         ValueDataTypeCode = ResponseDataTypeCode.Description
                                                     },
                                                     new TenderingCriterionProperty()
                                                     {
                                                         _cardinality = CardinalityMetadata.Optional,
                                                         Id = EuComGrowId.Random(),
                                                         TypeCode = CriterionElementType.Question,
                                                         Description = "abilitiesPersons.experience.description",
                                                         ValueDataTypeCode = ResponseDataTypeCode.Description
                                                     },
                                                     new TenderingCriterionProperty()
                                                     {
                                                         _cardinality = CardinalityMetadata.Optional,
                                                         Id = EuComGrowId.Random(),
                                                         TypeCode = CriterionElementType.Question,
                                                         Description = "abilitiesPersons.otherInformation.description",
                                                         ValueDataTypeCode = ResponseDataTypeCode.Description
                                                     },
                                                     new TenderingCriterionProperty()
                                                     {
                                                         _cardinality = CardinalityMetadata.Optional,
                                                         Id = EuComGrowId.Random(),
                                                         TypeCode = CriterionElementType.Question,
                                                         Description = "abilitiesPersons.howLongWithEO.description",
                                                         ValueDataTypeCode = ResponseDataTypeCode.QuantityInteger
                                                     }

                                                 },
                                                 SubsidiaryTenderingCriterionPropertyGroups = new TenderingCriterionPropertyGroup[]
                                                 {
                                                     new TenderingCriterionPropertyGroup()
                                                     {
                                                         _cardinality = CardinalityMetadata.Optional,
                                                         Id = new CriteriaTaxonomyIdentifier("9026e403-3eb6-4705-a9e9-e21a1efc867d"),
                                                         PropertyGroupTypeCode = PropertyGroupTypeCode.OnAlways,
                                                         TenderingCriterionProperties = new[]
                                                         {
                                                             new TenderingCriterionProperty()
                                                             {
                                                                 _cardinality = CardinalityMetadata.ExactlyOne,
                                                                 Id = EuComGrowId.Random(),
                                                                 TypeCode = CriterionElementType.Question,
                                                                 Description = "common.isThisInformationAvailableOnline.description",
                                                                 ValueDataTypeCode = ResponseDataTypeCode.Indicator
                                                             },
                                                         },
                                                         SubsidiaryTenderingCriterionPropertyGroups = new TenderingCriterionPropertyGroup[]
                                                         {
                                                             new TenderingCriterionPropertyGroup()
                                                             {
                                                                 _cardinality = CardinalityMetadata.Optional,
                                                                 Id = new CriteriaTaxonomyIdentifier("0a166f0a-0c5f-42b0-81e9-0fc9fa598a48"),
                                                                 PropertyGroupTypeCode = PropertyGroupTypeCode.OnTrue,
                                                                 TenderingCriterionProperties = new[]
                                                                 {
                                                                     new TenderingCriterionProperty()
                                                                     {
                                                                         _cardinality = CardinalityMetadata.ExactlyOne,
                                                                         Id = EuComGrowId.Random(),
                                                                         TypeCode = CriterionElementType.Question,
                                                                         Description = "common.evidenceSupplied.description",
                                                                         ValueDataTypeCode = ResponseDataTypeCode.EvidenceIdentifier
                                                                     },
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
                                         _cardinality = CardinalityMetadata.Optional,
                                         Id = new CriteriaTaxonomyIdentifier("45a67f48-d146-4faf-8239-dd6977dffe29"),
                                         PropertyGroupTypeCode = PropertyGroupTypeCode.OnAlways,
                                         TenderingCriterionProperties = new[]
                                         {
                                             new TenderingCriterionProperty()
                                             {
                                             _cardinality = CardinalityMetadata.ExactlyOne,
                                             Id = EuComGrowId.Random(),
                                             TypeCode = CriterionElementType.Caption,
                                             ValueDataTypeCode = ResponseDataTypeCode.None
                                             }
                                         },
                                         SubsidiaryTenderingCriterionPropertyGroups = new TenderingCriterionPropertyGroup[]
                                         {
                                             new TenderingCriterionPropertyGroup()
                                             {
                                                 _cardinality = CardinalityMetadata.ZeroOrMore,
                                                 Description = new[]{"abilitiesPersons.technicalBody.description"},
                                                 Id = new CriteriaTaxonomyIdentifier("52ffcf91-3598-438f-8c3d-faf97da02602"),
                                                 PropertyGroupTypeCode = PropertyGroupTypeCode.OnAlways,
                                                 TenderingCriterionProperties = new[]
                                                 {
                                                     new TenderingCriterionProperty()
                                                     {
                                                         _cardinality = CardinalityMetadata.ExactlyOne,
                                                         Id = EuComGrowId.Random(),
                                                         TypeCode = CriterionElementType.Question,
                                                         Description = "common.name.description",
                                                         ValueDataTypeCode = ResponseDataTypeCode.Description
                                                     },
                                                     new TenderingCriterionProperty()
                                                     {
                                                         _cardinality = CardinalityMetadata.Optional,
                                                         Id = EuComGrowId.Random(),
                                                         TypeCode = CriterionElementType.Question,
                                                         Description = "abilitiesPersons.experienceArea.description",
                                                         ValueDataTypeCode = ResponseDataTypeCode.Description
                                                     },
                                                     new TenderingCriterionProperty()
                                                     {
                                                         _cardinality = CardinalityMetadata.Optional,
                                                         Id = EuComGrowId.Random(),
                                                         TypeCode = CriterionElementType.Question,
                                                         Description = "abilitiesPersons.otherInformation.description",
                                                         ValueDataTypeCode = ResponseDataTypeCode.Description
                                                     },
                                                 },
                                                 SubsidiaryTenderingCriterionPropertyGroups = new TenderingCriterionPropertyGroup[]
                                                 {
                                                     new TenderingCriterionPropertyGroup()
                                                     {
                                                         _cardinality = CardinalityMetadata.Optional,
                                                         Description = new[]{"abilitiesPersons.technicalBody.description"},
                                                         Id = new CriteriaTaxonomyIdentifier("0a166f0a-0c5f-42b0-81e9-0fc9fa598a48"),
                                                         PropertyGroupTypeCode = PropertyGroupTypeCode.OnTrue,
                                                         TenderingCriterionProperties = new[]
                                                         {
                                                             new TenderingCriterionProperty()
                                                             {
                                                                 _cardinality = CardinalityMetadata.OneOrMore,
                                                                 Id = EuComGrowId.Random(),
                                                                 TypeCode = CriterionElementType.Question,
                                                                 Description = "common.evidenceSupplied.description",
                                                                 ValueDataTypeCode = ResponseDataTypeCode.EvidenceIdentifier
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

        public static TenderingCriterionPropertyGroup[] AbilitiesFacilities =>
        new[]
        {
        new TenderingCriterionPropertyGroup()
                     {
                         _cardinality = CardinalityMetadata.ExactlyOne,
                         Id = new CriteriaTaxonomyIdentifier("1e73d705-9dc1-43f1-9b5c-2d0deac7bc5f"),
                         PropertyGroupTypeCode = PropertyGroupTypeCode.OnAlways,
                         TenderingCriterionProperties = new[]
                         {
                           new TenderingCriterionProperty()
                           {
                             _cardinality = CardinalityMetadata.Optional,
                             Id = EuComGrowId.Random(),
                             TypeCode = CriterionElementType.Requirement,
                             Description = "common.thisCriterionWillBeWeighted.description",
                             ValueDataTypeCode = ResponseDataTypeCode.WeightIndicator
                           }
                         },
                         SubsidiaryTenderingCriterionPropertyGroups = new TenderingCriterionPropertyGroup[]
                         {
                             new TenderingCriterionPropertyGroup()
                             {
                                 _cardinality = CardinalityMetadata.OneOrMore,
                                 Id = new CriteriaTaxonomyIdentifier("f156d97a-9700-4ad9-8d21-e3ac57102278"),
                                 PropertyGroupTypeCode = PropertyGroupTypeCode.OnAlways,
                                 TenderingCriterionProperties = new[]
                                 {
                                   new TenderingCriterionProperty()
                                   {
                                     _cardinality = CardinalityMetadata.Optional,
                                     Id = EuComGrowId.Random(),
                                     TypeCode = CriterionElementType.Requirement,
                                     Description = "common.requirement.description",
                                     ValueDataTypeCode = ResponseDataTypeCode.Description
                                   }
                                 },
                                 SubsidiaryTenderingCriterionPropertyGroups = new TenderingCriterionPropertyGroup[]
                                 {
                                     new TenderingCriterionPropertyGroup()
                                     {
                                         _cardinality = CardinalityMetadata.ExactlyOne,
                                         Id = new CriteriaTaxonomyIdentifier("488ca189-bcdb-4bf4-80c7-3ad507fd89fb"),
                                         PropertyGroupTypeCode = PropertyGroupTypeCode.OnAlways,
                                         TenderingCriterionProperties = new[]
                                         {
                                           new TenderingCriterionProperty()
                                           {
                                             _cardinality = CardinalityMetadata.ExactlyOne,
                                             Id = EuComGrowId.Random(),
                                             TypeCode = CriterionElementType.Question,
                                             Description = "common.pleaseDescribeThem.description",
                                             ValueDataTypeCode = ResponseDataTypeCode.Description
                                           }
                                         },
                                     },
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
                                             Id = EuComGrowId.Random(),
                                             TypeCode = CriterionElementType.Question,
                                             Description = "common.isThisInformationAvailableElectronically.description",
                                             ValueDataTypeCode = ResponseDataTypeCode.Indicator
                                           }
                                         },
                                         SubsidiaryTenderingCriterionPropertyGroups = new TenderingCriterionPropertyGroup[]
                                         {
                                             new TenderingCriterionPropertyGroup()
                                             {
                                                 _cardinality = CardinalityMetadata.Optional,
                                                 Id = new CriteriaTaxonomyIdentifier("41dd2e9b-1bfd-44c7-93ee-56bd74a4334b"),
                                                 PropertyGroupTypeCode = PropertyGroupTypeCode.OnTrue,
                                                 TenderingCriterionProperties = new[]
                                                 {
                                                   new TenderingCriterionProperty()
                                                   {
                                                     _cardinality = CardinalityMetadata.ExactlyOne,
                                                     Id = EuComGrowId.Random(),
                                                     TypeCode = CriterionElementType.Question,
                                                     Description = "common.evidenceSupplied.description",
                                                     ValueDataTypeCode = ResponseDataTypeCode.EvidenceIdentifier
                                                   }
                                                 },
                                             }
                                         }
                                     }
                                 }
                             }
                         }
                     }
        };

        public static TenderingCriterionPropertyGroup[] AbilitiesStaff =>
        new[]
        {
        new TenderingCriterionPropertyGroup()
            {
                _cardinality = CardinalityMetadata.ExactlyOne,
                Id = new CriteriaTaxonomyIdentifier("7f7949a8-dbe6-496c-a9f6-6f05b8648bad"),
                PropertyGroupTypeCode = PropertyGroupTypeCode.OnAlways,
                TenderingCriterionProperties = new[]
                {
                  new TenderingCriterionProperty()
                  {
                    _cardinality = CardinalityMetadata.ExactlyOne,
                    Id = EuComGrowId.Random(),
                    TypeCode = CriterionElementType.Requirement,
                    Description = "abilitiesStaff.minumNumberOfYears.description",
                    ValueDataTypeCode = ResponseDataTypeCode.QuantityInteger
                  },
                  new TenderingCriterionProperty()
                  {
                    _cardinality = CardinalityMetadata.Optional,
                    Id = EuComGrowId.Random(),
                    TypeCode = CriterionElementType.Requirement,
                    Description = "abilitiesStaff.additionalInformation.description",
                    ValueDataTypeCode = ResponseDataTypeCode.Description
                  }
                },
                SubsidiaryTenderingCriterionPropertyGroups = new TenderingCriterionPropertyGroup[]
                {
                    new TenderingCriterionPropertyGroup()
                    {
                        _cardinality = CardinalityMetadata.OneOrMore,
                        Id = new CriteriaTaxonomyIdentifier("96defecc-7d32-4957-82e9-aad5f3c5b736"),
                        PropertyGroupTypeCode = PropertyGroupTypeCode.OnAlways,
                        TenderingCriterionProperties = new[]
                        {
                          new TenderingCriterionProperty()
                          {
                            _cardinality = CardinalityMetadata.ExactlyOne,
                            Id = EuComGrowId.Random(),
                            TypeCode = CriterionElementType.Question,
                            Description = "common.year.description",
                            ValueDataTypeCode = ResponseDataTypeCode.QuantityYear
                          },
                          new TenderingCriterionProperty()
                          {
                            _cardinality = CardinalityMetadata.ExactlyOne,
                            Id = EuComGrowId.Random(),
                            TypeCode = CriterionElementType.Question,
                            Description = "common.number.description",
                            ValueDataTypeCode = ResponseDataTypeCode.QuantityInteger
                          }
                        }
                    },
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
                            Id = EuComGrowId.Random(),
                            TypeCode = CriterionElementType.Question,
                            Description = "common.isThisInformationAvailableOnline.description",
                            ValueDataTypeCode = ResponseDataTypeCode.Indicator
                          }
                        },
                        SubsidiaryTenderingCriterionPropertyGroups = new TenderingCriterionPropertyGroup[]
                        {
                           new TenderingCriterionPropertyGroup()
                           {
                               _cardinality = CardinalityMetadata.Optional,
                               Id = new CriteriaTaxonomyIdentifier("41dd2e9b-1bfd-44c7-93ee-56bd74a4334b"),
                               PropertyGroupTypeCode = PropertyGroupTypeCode.OnTrue,
                               TenderingCriterionProperties = new[]
                               {
                                   new TenderingCriterionProperty()
                                   {
                                       _cardinality = CardinalityMetadata.OneOrMore,
                                       Id = EuComGrowId.Random(),
                                       TypeCode = CriterionElementType.Question,
                                       Description = "common.evidenceSupplied.description",
                                       ValueDataTypeCode = ResponseDataTypeCode.EvidenceIdentifier
                                   }
                               }
                           }
                        }
                    },
                }
            }
        };

        public static TenderingCriterionPropertyGroup[] SamplesCertificates =>
        new[]
        {
            new TenderingCriterionPropertyGroup()
                      {
                            _cardinality = CardinalityMetadata.ExactlyOne,
                            Id = new CriteriaTaxonomyIdentifier("cb73544d-e8bb-4cc6-819b-b8e04f1e240e"),
                            PropertyGroupTypeCode = PropertyGroupTypeCode.OnAlways,
                            TenderingCriterionProperties = new[]
                            {
                              new TenderingCriterionProperty()
                              {
                                _cardinality = CardinalityMetadata.ExactlyOne,
                                Id = EuComGrowId.Random(),
                                TypeCode = CriterionElementType.Question,
                                Description = "common.yourAnswer.description",
                                ValueDataTypeCode = ResponseDataTypeCode.Indicator
                              }
                            }
                      },
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
                                Id = EuComGrowId.Random(),
                                TypeCode = CriterionElementType.Question,
                                Description = "common.isThisInformationAvailableElectronically.description",
                                ValueDataTypeCode = ResponseDataTypeCode.Indicator
                              }
                            },
                            SubsidiaryTenderingCriterionPropertyGroups = new TenderingCriterionPropertyGroup[]
                            {
                                new TenderingCriterionPropertyGroup()
                                {
                                    _cardinality = CardinalityMetadata.Optional,
                                    Id = new CriteriaTaxonomyIdentifier("41dd2e9b-1bfd-44c7-93ee-56bd74a4334b"),
                                    PropertyGroupTypeCode = PropertyGroupTypeCode.OnTrue,
                                    TenderingCriterionProperties = new[]
                                    {
                                      new TenderingCriterionProperty()
                                      {
                                        _cardinality = CardinalityMetadata.OneOrMore,
                                        Id = EuComGrowId.Random(),
                                        TypeCode = CriterionElementType.Question,
                                        Description = "common.evidenceSupplied.description",
                                        ValueDataTypeCode = ResponseDataTypeCode.EvidenceIdentifier
                                      }
                                    }
                                }
                            }
                      }
        };

        public static TenderingCriterionPropertyGroup[] QualityAssurance =>
        new[]
        {
            new TenderingCriterionPropertyGroup()
            {
                 _cardinality = CardinalityMetadata.OneOrMore,
                 Id = new CriteriaTaxonomyIdentifier("612d99eb-ea3b-4275-ac06-0db05e039c8c"),
                 PropertyGroupTypeCode = PropertyGroupTypeCode.OnAlways,
                 TenderingCriterionProperties = new[]
                 {
                   new TenderingCriterionProperty()
                   {
                     _cardinality = CardinalityMetadata.ExactlyOne,
                     Id = EuComGrowId.Random(),
                     TypeCode = CriterionElementType.Requirement,
                     Description = "common.requirement.description",
                     ValueDataTypeCode = ResponseDataTypeCode.Description
                   }
                 },
                 SubsidiaryTenderingCriterionPropertyGroups = new TenderingCriterionPropertyGroup[]
                 {
                   new TenderingCriterionPropertyGroup()
                   {
                       _cardinality = CardinalityMetadata.ExactlyOne,
                       Id = new CriteriaTaxonomyIdentifier("4887c3d7-05fc-4e3e-b066-f338910f0c4c"),
                       PropertyGroupTypeCode = PropertyGroupTypeCode.OnAlways,
                       TenderingCriterionProperties = new[]
                       {
                         new TenderingCriterionProperty()
                         {
                           _cardinality = CardinalityMetadata.ExactlyOne,
                           Id = EuComGrowId.Random(),
                           TypeCode = CriterionElementType.Question,
                           Description = "common.yourAnswer.description",
                           ValueDataTypeCode = ResponseDataTypeCode.Indicator
                         }
                       },
                       SubsidiaryTenderingCriterionPropertyGroups = new TenderingCriterionPropertyGroup[]
                       {
                           new TenderingCriterionPropertyGroup()
                           {
                               _cardinality = CardinalityMetadata.ExactlyOne,
                               Id = new CriteriaTaxonomyIdentifier("83f2f79e-0455-4918-89ff-d7829e8bf758"),
                               PropertyGroupTypeCode = PropertyGroupTypeCode.OnFalse,
                               TenderingCriterionProperties = new[]
                               {
                                 new TenderingCriterionProperty()
                                 {
                                   _cardinality = CardinalityMetadata.ExactlyOne,
                                   Id = EuComGrowId.Random(),
                                   TypeCode = CriterionElementType.Question,
                                   Description = "qualityAssurance.pleaseExplainWhyAndState.description",
                                   ValueDataTypeCode = ResponseDataTypeCode.Description
                                 }
                               }
                           }
                       }
                   },
                   IsThisInformationAvailableElectronically
                 }
            }
        };
        

    }
}



