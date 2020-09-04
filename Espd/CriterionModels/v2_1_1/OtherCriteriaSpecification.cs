using Hilma.UBL.CommonAggregateComponents;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hilma.Espd.EDM.CriterionModels.v2_1_1.Identifiers;

namespace Hilma.Espd.EDM.CriterionModels.v2_1_1
{
    public class OtherCriteriaSpecification : IEnumerable<TenderingCriterion>
    {
        public IEnumerable<TenderingCriterion> AllCriteria => new[] {

            OtherCaLots,
            OtherEoSheltered,
            OtherEoPqs,
            OtherEoGroups,
            OtherEoReliedOnEntities,
            OtherEoNotReliedOnEntities,
            OtherEoLots,
            EoReductionOfCandidates,
            OtherEOSME,
            DefenceSelectionOther,
            UtilitiesSelectionOther

        }.SelectMany(c => c);

        public IEnumerator<TenderingCriterion> GetEnumerator()
        {
            return AllCriteria.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return AllCriteria.GetEnumerator();
        }

        public TenderingCriterion[] OtherEoSheltered => new[]
   {
            new TenderingCriterion()
            {
                 CriterionTypeCode =
                   new CriterionTypeCode("CRITERION.OTHER.EO_DATA.SHELTERED_WORKSHOP"),
                 Name = "otherEoSheltered.question.name",
                 Description = new[] {"otherEoSheltered.question.description"},
                 ID = new CriteriaTaxonomyIdentifier("2043338f-a38a-490b-b3ec-2607cb25a017"),
                 Legislations = new Legislation[] { },
                 TenderingCriterionPropertyGroups = new TenderingCriterionPropertyGroup[]
                 {
                     new TenderingCriterionPropertyGroup()
                     {
                         _cardinality = CardinalityMetadata.ExactlyOne,
                         ID = new CriteriaTaxonomyIdentifier("6febbe4a-e715-427c-a2b1-19cfabadaef0"),
                         PropertyGroupTypeCode = PropertyGroupTypeCode.OnAlways,
                         TenderingCriterionProperties = new[]
                         {
                           new TenderingCriterionProperty()
                           {
                             _cardinality = CardinalityMetadata.ExactlyOne,
                             ID = EuComGrowId.Random(),
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
                               ID = new CriteriaTaxonomyIdentifier("a5e33369-e2b5-45f7-9969-ddb1c3ae17c8"),
                               PropertyGroupTypeCode = PropertyGroupTypeCode.OnTrue,
                               TenderingCriterionProperties = new[]
                               {
                                 new TenderingCriterionProperty()
                                 {
                                   _cardinality = CardinalityMetadata.Optional,
                                   ID = EuComGrowId.Random(),
                                   TypeCode = CriterionElementType.Question,
                                   Description = "otherEoSheltered.whatIsTheCorrespondingPercentage.description",
                                   ValueDataTypeCode = ResponseDataTypeCode.Percentage
                                 },
                                 new TenderingCriterionProperty()
                                 {
                                   _cardinality = CardinalityMetadata.Optional,
                                   ID = EuComGrowId.Random(),
                                   TypeCode = CriterionElementType.Question,
                                   Description = "otherEoSheltered.ifRequiredPleaseProvideDetails.description",
                                   ValueDataTypeCode = ResponseDataTypeCode.Description
                                 }
                               }
                            }
                         }
                     },
                     CriterionHelper.IsThisInformationAvailableElectronically

                 }

            }
        };
        public TenderingCriterion[] OtherEoPqs => new[]
        {
            new TenderingCriterion()
            {
                 CriterionTypeCode =
                   new CriterionTypeCode("CRITERION.OTHER.EO_DATA.REGISTERED_IN_OFFICIAL_LIST"),
                 Name = "otherEoPqs.question.name",
                 Description = new[] {"otherEoPqs.question.description"},
                 ID = new CriteriaTaxonomyIdentifier("9b19e869-6c89-4cc4-bd6c-ac9ca8602165"),
                 Legislations = new Legislation[] { },
                 TenderingCriterionPropertyGroups = new TenderingCriterionPropertyGroup[]
                 {
                     new TenderingCriterionPropertyGroup()
                     {
                         _cardinality = CardinalityMetadata.ExactlyOne,
                         ID = new CriteriaTaxonomyIdentifier("ecb5127b-9018-4fb8-8327-a6a7a2c73195"),
                         PropertyGroupTypeCode = PropertyGroupTypeCode.OnAlways,
                         TenderingCriterionProperties = new[]
                         {
                           new TenderingCriterionProperty()
                           {
                             _cardinality = CardinalityMetadata.ExactlyOne,
                             ID = EuComGrowId.Random(),
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
                                ID = new CriteriaTaxonomyIdentifier("dc4acf0c-c761-40d0-b031-4ee1f224be5c"),
                                PropertyGroupTypeCode = PropertyGroupTypeCode.OnTrue,
                                TenderingCriterionProperties = new[]
                                {
                                  new TenderingCriterionProperty()
                                  {
                                    _cardinality = CardinalityMetadata.ExactlyOne,
                                    ID = EuComGrowId.Random(),
                                    TypeCode = CriterionElementType.Question,
                                    Description = "otherEoPqs.pleaseProvideTheNameOfCertificate.description",
                                    ValueDataTypeCode = ResponseDataTypeCode.Description
                                  },
                                  new TenderingCriterionProperty()
                                  {
                                    _cardinality = CardinalityMetadata.Optional,
                                    ID = EuComGrowId.Random(),
                                    TypeCode = CriterionElementType.Question,
                                    Description = "otherEoPqs.ifTheCertificateOfRegistrationOrCertificationIsAvailableElectronically.description",
                                    ValueDataTypeCode = ResponseDataTypeCode.Url
                                  },
                                  new TenderingCriterionProperty()
                                  {
                                    _cardinality = CardinalityMetadata.Optional,
                                    ID = EuComGrowId.Random(),
                                    TypeCode = CriterionElementType.Question,
                                    Description = "otherEoPqs.pleaseStateTheReferencesRegistration.description",
                                    ValueDataTypeCode = ResponseDataTypeCode.Description
                                  }
                                },
                                SubsidiaryTenderingCriterionPropertyGroups = new TenderingCriterionPropertyGroup[]
                                {
                                    new TenderingCriterionPropertyGroup()
                                    {
                                        _cardinality = CardinalityMetadata.ExactlyOne,
                                        ID = new CriteriaTaxonomyIdentifier("92e44d3b-af8e-4a29-91a8-24d27aa27fee"),
                                        PropertyGroupTypeCode = PropertyGroupTypeCode.OnAlways,
                                        TenderingCriterionProperties = new[]
                                        {
                                          new TenderingCriterionProperty()
                                          {
                                            _cardinality = CardinalityMetadata.ExactlyOne,
                                            ID = EuComGrowId.Random(),
                                            TypeCode = CriterionElementType.Question,
                                            Description = "otherEoPqs.doesTheEegistrationOrCertificationCover.description",
                                            ValueDataTypeCode = ResponseDataTypeCode.Indicator
                                          },
                                        }
                                    }
                                }
                            },
                            new TenderingCriterionPropertyGroup()
                            {
                                _cardinality = CardinalityMetadata.ExactlyOne,
                                ID = new CriteriaTaxonomyIdentifier("59e6f3ef-15cd-4e21-82ac-ea497ccd44e2"),
                                PropertyGroupTypeCode = PropertyGroupTypeCode.OnFalse,
                                TenderingCriterionProperties = new[]
                                {
                                  new TenderingCriterionProperty()
                                  {
                                    _cardinality = CardinalityMetadata.ExactlyOne,
                                    ID = EuComGrowId.Random(),
                                    TypeCode = CriterionElementType.Question,
                                    Description = "otherEoPqs.willTheEconomicOperatorBeAbleToProvideCertificate.description",
                                    ValueDataTypeCode = ResponseDataTypeCode.Indicator
                                  }
                                }
                            }
                         }
                     },
                     CriterionHelper.IsThisInformationAvailableElectronically
                 }

            }
        };
        public TenderingCriterion[] OtherEoGroups => new[]
        {
            new TenderingCriterion()
            {
                 CriterionTypeCode =
                   new CriterionTypeCode("CRITERION.OTHER.EO_DATA.TOGETHER_WITH_OTHERS"),
                 Name = "otherEoGroups.question.name",
                 Description = new[] {"otherEoGroups.question.description"},
                 ID = new CriteriaTaxonomyIdentifier("ee51100f-8e3e-40c9-8f8b-57d5a15be1f2"),
                 Legislations = new Legislation[] { },
                 TenderingCriterionPropertyGroups = new TenderingCriterionPropertyGroup[]
                 {
                     new TenderingCriterionPropertyGroup()
                     {
                         _cardinality = CardinalityMetadata.ExactlyOne,
                         ID = new CriteriaTaxonomyIdentifier("d939f2c6-ba25-4dc4-889c-11d1853add19"),
                         PropertyGroupTypeCode = PropertyGroupTypeCode.OnAlways,
                         TenderingCriterionProperties = new[]
                         {
                           new TenderingCriterionProperty()
                           {
                             _cardinality = CardinalityMetadata.ExactlyOne,
                             ID = EuComGrowId.Random(),
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
                                ID = new CriteriaTaxonomyIdentifier("f5663c5a-d311-4ae4-be14-1575754be5f2"),
                                PropertyGroupTypeCode = PropertyGroupTypeCode.OnTrue,
                                TenderingCriterionProperties = new[]
                                {
                                  new TenderingCriterionProperty()
                                  {
                                    _cardinality = CardinalityMetadata.ExactlyOne,
                                    ID = EuComGrowId.Random(),
                                    TypeCode = CriterionElementType.Question,
                                    Description = "otherEoGroups.pleaseIndicateTheRoleOfTheEconomicOperator.description",
                                    ValueDataTypeCode = ResponseDataTypeCode.Code,
                                    CodeListId = CodeListIds.EORoleType
                                  },
                                  new TenderingCriterionProperty()
                                  {
                                    _cardinality = CardinalityMetadata.Optional,
                                    ID = EuComGrowId.Random(),
                                    TypeCode = CriterionElementType.Question,
                                    Description = "otherEoGroups.pleaseIdentifyTheOtherEconomicOperators.description",
                                    ValueDataTypeCode = ResponseDataTypeCode.Description
                                  },
                                  new TenderingCriterionProperty()
                                  {
                                    _cardinality = CardinalityMetadata.Optional,
                                    ID = EuComGrowId.Random(),
                                    TypeCode = CriterionElementType.Question,
                                    Description = "otherEoGroups.whereApplicableNameOfTheParticipatingGroup.description",
                                    ValueDataTypeCode = ResponseDataTypeCode.Description
                                  }
                              }
                            },
                            CriterionHelper.IsThisInformationAvailableElectronically
                         }
                     }
                 }
            }
        };
        public TenderingCriterion[] OtherEoReliedOnEntities => new[]
        {
            new TenderingCriterion()
            {
                 CriterionTypeCode =
                   new CriterionTypeCode("CRITERION.OTHER.EO_DATA.RELIES_ON_OTHER_CAPACITIES"),
                 Name = "otherEoReliedOnEntities.question.name",
                 Description = new[] {"otherEoReliedOnEntities.question.description"},
                 ID = new CriteriaTaxonomyIdentifier("0d62c6ed-f074-4fcf-8e9f-f691351d52ad"),
                 Legislations = new Legislation[] { },
                 TenderingCriterionPropertyGroups = new TenderingCriterionPropertyGroup[]
                 {
                     new TenderingCriterionPropertyGroup()
                     {
                         _cardinality = CardinalityMetadata.ExactlyOne,
                         ID = new CriteriaTaxonomyIdentifier("289f39b3-2a15-421a-8050-a29858031f35"),
                         PropertyGroupTypeCode = PropertyGroupTypeCode.OnAlways,
                         TenderingCriterionProperties = new[]
                         {
                           new TenderingCriterionProperty()
                           {
                             _cardinality = CardinalityMetadata.ExactlyOne,
                             ID = EuComGrowId.Random(),
                             TypeCode = CriterionElementType.Question,
                             Description = "common.yourAnswer.description",
                             ValueDataTypeCode = ResponseDataTypeCode.Indicator
                           }
                         },
                         SubsidiaryTenderingCriterionPropertyGroups = new TenderingCriterionPropertyGroup[]
                         {
                            new TenderingCriterionPropertyGroup()
                            {
                                _cardinality = CardinalityMetadata.ZeroOrMore,
                                ID = new CriteriaTaxonomyIdentifier("50e9a74e-969e-4d79-8e19-8af71cb7c54a"),
                                PropertyGroupTypeCode = PropertyGroupTypeCode.OnTrue,
                                TenderingCriterionProperties = new[]
                                {
                                  new TenderingCriterionProperty()
                                  {
                                    _cardinality = CardinalityMetadata.ExactlyOne,
                                    ID = EuComGrowId.Random(),
                                    TypeCode = CriterionElementType.Question,
                                    Description = "common.nameOfTheEntity.description",
                                    ValueDataTypeCode = ResponseDataTypeCode.Description
                                  },
                                  new TenderingCriterionProperty()
                                  {
                                    _cardinality = CardinalityMetadata.ExactlyOne,
                                    ID = EuComGrowId.Random(),
                                    TypeCode = CriterionElementType.Question,
                                    Description = "common.iDOfTheEntity.description",
                                    ValueDataTypeCode = ResponseDataTypeCode.EconomicOperatorIdentifier,
                                    CodeListId = CodeListIds.EOIDType

                                  },
                                  new TenderingCriterionProperty()
                                  {
                                    _cardinality = CardinalityMetadata.ExactlyOne,
                                    ID = EuComGrowId.Random(),
                                    TypeCode = CriterionElementType.Question,
                                    Description = "common.activityOfTheEntity.description",
                                    ValueDataTypeCode = ResponseDataTypeCode.Code
                                  }
                                }
                            }
                         }
                     },
                     CriterionHelper.IsThisInformationAvailableElectronically
                 }
            }
        };
        public TenderingCriterion[] OtherEoNotReliedOnEntities => new[]
        {
            new TenderingCriterion()
            {
                 CriterionTypeCode =
                   new CriterionTypeCode("CRITERION.OTHER.EO_DATA.SUBCONTRACTS_WITH_THIRD_PARTIES"),
                 Name = "otherEoNotReliedOnEntities.question.name",
                 Description = new[] {"otherEoNotReliedOnEntities.question.description"},
                 ID = new CriteriaTaxonomyIdentifier("72c0c4b1-ca50-4667-9487-461f3eed4ed7"),
                 Legislations = new Legislation[] { },
                 TenderingCriterionPropertyGroups = new TenderingCriterionPropertyGroup[]
                 {
                     new TenderingCriterionPropertyGroup()
                     {
                         _cardinality = CardinalityMetadata.ExactlyOne,
                         ID = new CriteriaTaxonomyIdentifier("289f39b3-2a15-421a-8050-a29858031f35"),
                         PropertyGroupTypeCode = PropertyGroupTypeCode.OnAlways,
                         TenderingCriterionProperties = new[]
                         {
                           new TenderingCriterionProperty()
                           {
                             _cardinality = CardinalityMetadata.ExactlyOne,
                             ID = EuComGrowId.Random(),
                             TypeCode = CriterionElementType.Question,
                             Description = "common.yourAnswer.description",
                             ValueDataTypeCode = ResponseDataTypeCode.Indicator
                           }
                         },
                         SubsidiaryTenderingCriterionPropertyGroups = new TenderingCriterionPropertyGroup[]
                         {
                            new TenderingCriterionPropertyGroup()
                            {
                                _cardinality = CardinalityMetadata.ZeroOrMore,
                                ID = new CriteriaTaxonomyIdentifier("50e9a74e-969e-4d79-8e19-8af71cb7c54a"),
                                PropertyGroupTypeCode = PropertyGroupTypeCode.OnTrue,
                                TenderingCriterionProperties = new[]
                                {
                                  new TenderingCriterionProperty()
                                  {
                                    _cardinality = CardinalityMetadata.ExactlyOne,
                                    ID = EuComGrowId.Random(),
                                    TypeCode = CriterionElementType.Question,
                                    Description = "common.nameOfTheEntity.description",
                                    ValueDataTypeCode = ResponseDataTypeCode.Description
                                  },
                                  new TenderingCriterionProperty()
                                  {
                                    _cardinality = CardinalityMetadata.ExactlyOne,
                                    ID = EuComGrowId.Random(),
                                    TypeCode = CriterionElementType.Question,
                                    Description = "common.iDOfTheSubcontractor.description",
                                    ValueDataTypeCode = ResponseDataTypeCode.EconomicOperatorIdentifier
                                  },
                                  new TenderingCriterionProperty()
                                  {
                                    _cardinality = CardinalityMetadata.ZeroOrMore,
                                    ID = EuComGrowId.Random(),
                                    TypeCode = CriterionElementType.Question,
                                    Description = "common.activityOfTheEntity.description",
                                    ValueDataTypeCode = ResponseDataTypeCode.Code
                                  }
                                }
                            }
                         }
                     },
                     CriterionHelper.IsThisInformationAvailableElectronically
                 }
            }
        };
        public TenderingCriterion[] OtherEoLots => new[]
        {
            new TenderingCriterion()
            {
                 CriterionTypeCode =
                   new CriterionTypeCode("CRITERION.OTHER.EO_DATA.LOTS_TENDERED"),
                 Name = "otherEoLots.question.name",
                 Description = new[] {"otherEoLots.question.description"},
                 ID = new CriteriaTaxonomyIdentifier("8b9700b7-b13c-41e6-a220-6bbf8d5fab31"),
                 Legislations = new Legislation[] { },
                 TenderingCriterionPropertyGroups = new TenderingCriterionPropertyGroup[]
                 {
                     new TenderingCriterionPropertyGroup()
                     {
                         _cardinality = CardinalityMetadata.OneOrMore,
                         ID = new CriteriaTaxonomyIdentifier("289f39b3-2a15-421a-8050-a29858031f35"),
                         PropertyGroupTypeCode = PropertyGroupTypeCode.OnAlways,
                         TenderingCriterionProperties = new[]
                         {
                           new TenderingCriterionProperty()
                           {
                             _cardinality = CardinalityMetadata.OneOrMore,
                             ID = EuComGrowId.Random(),
                             TypeCode = CriterionElementType.Question,
                             Description = "common.lotID.description",
                             ValueDataTypeCode = ResponseDataTypeCode.LotIdentifier
                           }
                         }
                     }
                 }
            }
        };
        public TenderingCriterion[] EoReductionOfCandidates => new[]
        {
            new TenderingCriterion()
            {
                 CriterionTypeCode =
                   new CriterionTypeCode(""),
                 Name = "eoReductionOfCandidates.question.name",
                 Description = new[] {"eoReductionOfCandidates.question.description"},
                 ID = new CriteriaTaxonomyIdentifier("51c39ba9-0444-4967-afe9-36f753b30175"),
                 Legislations = new Legislation[] { },
                 TenderingCriterionPropertyGroups = new TenderingCriterionPropertyGroup[]
                 {
                     new TenderingCriterionPropertyGroup()
                     {
                         _cardinality = CardinalityMetadata.ExactlyOne,
                         ID = new CriteriaTaxonomyIdentifier("ecc69670-f428-4446-908f-689568ca0d0d"),
                         PropertyGroupTypeCode = PropertyGroupTypeCode.OnAlways,
                         TenderingCriterionProperties = new[]
                         {
                           new TenderingCriterionProperty()
                           {
                             _cardinality = CardinalityMetadata.ExactlyOne,
                             ID = EuComGrowId.Random(),
                             TypeCode = CriterionElementType.Question,
                             Description = "common.yourAnswer.description",
                             ValueDataTypeCode = ResponseDataTypeCode.Indicator
                           }
                         },
                         SubsidiaryTenderingCriterionPropertyGroups = new TenderingCriterionPropertyGroup[]
                         {
                             new TenderingCriterionPropertyGroup()
                             {
                                 _cardinality = CardinalityMetadata.Optional,
                                 ID = new CriteriaTaxonomyIdentifier("f13754df-7e15-4155-aaa6-7ca6407baa47"),
                                 PropertyGroupTypeCode = PropertyGroupTypeCode.OnTrue,
                                 TenderingCriterionProperties = new[]
                                 {
                                   new TenderingCriterionProperty()
                                   {
                                     _cardinality = CardinalityMetadata.ExactlyOne,
                                     ID = EuComGrowId.Random(),
                                     TypeCode = CriterionElementType.Question,
                                     Description = "common.pleaseDescribeThem.description",
                                     ValueDataTypeCode = ResponseDataTypeCode.Description
                                   }
                                 }
                             }
                         }
                     },
                     CriterionHelper.IsThisInformationAvailableElectronically
                 }
            }
        };
        public TenderingCriterion[] OtherCaLots => new[]
        {
            new TenderingCriterion()
            {
                 CriterionTypeCode =
                   new CriterionTypeCode("CRITERION.OTHER.CA_DATA.LOTS_SUBMISSION"),
                 Name = "OtherCaLots.question.name",
                 Description = new[] {"OtherCaLots.question.description"},
                 ID = new CriteriaTaxonomyIdentifier("6a21c421-5c1e-46f4-9762-116fbcd33097"),
                 Legislations = new Legislation[] { },
                 TenderingCriterionPropertyGroups = new TenderingCriterionPropertyGroup[]
                 {
                     new TenderingCriterionPropertyGroup()
                     {
                         _cardinality = CardinalityMetadata.Optional,
                         ID = new CriteriaTaxonomyIdentifier("03cff8d1-4d22-4435-82fa-d6361af84be6"),
                         PropertyGroupTypeCode = PropertyGroupTypeCode.OnAlways,
                         TenderingCriterionProperties = new[]
                         {
                           new TenderingCriterionProperty()
                           {
                             _cardinality = CardinalityMetadata.ExactlyOne,
                             ID = EuComGrowId.Random(),
                             TypeCode = CriterionElementType.Requirement,
                             Description = "OtherCaLots.tendersMayBeSubmittedFor.description",
                             ValueDataTypeCode = ResponseDataTypeCode.Code
                           },
                           new TenderingCriterionProperty()
                           {
                             _cardinality = CardinalityMetadata.ExactlyOne,
                             ID = EuComGrowId.Random(),
                             TypeCode = CriterionElementType.Requirement,
                             Description = "OtherCaLots.maximumNumberOfLots.description",
                             ValueDataTypeCode = ResponseDataTypeCode.QuantityInteger
                           },
                           new TenderingCriterionProperty()
                           {
                             _cardinality = CardinalityMetadata.ExactlyOne,
                             ID = EuComGrowId.Random(),
                             TypeCode = CriterionElementType.Requirement,
                             Description = "OtherCaLots.maximumNumberOfLotsThatMayBeAwarded.description",
                             ValueDataTypeCode = ResponseDataTypeCode.QuantityInteger
                           }
                         }
                     }
                 }
            }
        };

        public TenderingCriterion[] OtherEOSME => new[]
        {
            new TenderingCriterion()
            {
                 CriterionTypeCode =
                   new CriterionTypeCode("CRITERION.OTHER.EO_SME"),
                 Name = "otherEOSME.question.name",
                 Description = new[] {"otherEOSME.question.description"},
                 ID = new CriteriaTaxonomyIdentifier("ede30cb7-70c2-4ead-ba11-22d0cac5ab7a"),
                 Legislations = new Legislation[] { },
                 TenderingCriterionPropertyGroups = new TenderingCriterionPropertyGroup[]
                 {
                     new TenderingCriterionPropertyGroup()
                     {
                         _cardinality = CardinalityMetadata.ExactlyOne,
                         ID = new CriteriaTaxonomyIdentifier("0aef9d77-7bcd-411e-b49e-f6b6cd47312c"),
                         PropertyGroupTypeCode = PropertyGroupTypeCode.OnAlways,
                         TenderingCriterionProperties = new[]
                         {
                           new TenderingCriterionProperty()
                           {
                             _cardinality = CardinalityMetadata.ExactlyOne,
                             ID = EuComGrowId.Random(),
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
                                 ID = new CriteriaTaxonomyIdentifier("5ee707fa-21fa-4966-9c1e-b9b4a98b6e98"),
                                 PropertyGroupTypeCode = PropertyGroupTypeCode.OnTrue,
                                 TenderingCriterionProperties = new[]
                                 {
                                   new TenderingCriterionProperty()
                                   {
                                     _cardinality = CardinalityMetadata.ExactlyOne,
                                     ID = EuComGrowId.Random(),
                                     TypeCode = CriterionElementType.Question,
                                     Description = "otherEOSME.numberOfEmployees.description",
                                     ValueDataTypeCode = ResponseDataTypeCode.QuantityInteger
                                   },
                                   new TenderingCriterionProperty()
                                   {
                                     _cardinality = CardinalityMetadata.ExactlyOne,
                                     ID = EuComGrowId.Random(),
                                     TypeCode = CriterionElementType.Question,
                                     Description = "otherEOSME.turnover.description",
                                     ValueDataTypeCode = ResponseDataTypeCode.Amount
                                   }
                                 }
                             }
                         }
                     }
                 }
            }
        };

        public TenderingCriterion[] DefenceSelectionOther => new[]
        {
            new TenderingCriterion()
            {
                 CriterionTypeCode =
                   new CriterionTypeCode("CRITERION.DEFENCE.SELECTION.OTHER"),
                 Name = "defenceSelectionOther.question.name",
                 Description = new[] {"defenceSelectionOther.question.description"},
                 ID = new CriteriaTaxonomyIdentifier("0114620b-93e4-486e-84de-14849db1f023"),
                 Legislations = new Legislation[] { },
                 TenderingCriterionPropertyGroups = new TenderingCriterionPropertyGroup[]
                 {
                     new TenderingCriterionPropertyGroup()
                     {
                         _cardinality = CardinalityMetadata.ExactlyOne,
                         ID = new CriteriaTaxonomyIdentifier("7458d42a-e581-4640-9283-34ceb3ad4345"),
                         PropertyGroupTypeCode = PropertyGroupTypeCode.OnAlways,
                         TenderingCriterionProperties = new[]
                         {
                           new TenderingCriterionProperty()
                           {
                             _cardinality = CardinalityMetadata.ExactlyOne,
                             ID = EuComGrowId.Random(),
                             TypeCode = CriterionElementType.Question,
                             Description = "common.yourAnswer.description",
                             ValueDataTypeCode = ResponseDataTypeCode.Indicator
                           }
                         },
                         SubsidiaryTenderingCriterionPropertyGroups = new TenderingCriterionPropertyGroup[]
                         {
                             new TenderingCriterionPropertyGroup()
                             {
                                 _cardinality = CardinalityMetadata.Optional,
                                 ID = new CriteriaTaxonomyIdentifier("41dd2e9b-1bfd-44c7-93ee-56bd74a4334b"),
                                 PropertyGroupTypeCode = PropertyGroupTypeCode.OnTrue,
                                 TenderingCriterionProperties = new[]
                                 {
                                   new TenderingCriterionProperty()
                                   {
                                     _cardinality = CardinalityMetadata.OneOrMore,
                                     ID = EuComGrowId.Random(),
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
        };

        public TenderingCriterion[] UtilitiesSelectionOther => new[]
        {
            new TenderingCriterion()
            {
                 CriterionTypeCode =
                   new CriterionTypeCode("CRITERION.UTILITIES.SELECTION.OTHER"),
                 Name = "utilitiesSelectionOther.question.name",
                 Description = new[] {"utilitiesSelectionOther.question.description"},
                 ID = new CriteriaTaxonomyIdentifier("4c6928de-df28-464e-8e3f-efebf727c418"),
                 Legislations = new Legislation[] { },
                 TenderingCriterionPropertyGroups = new TenderingCriterionPropertyGroup[]
                 {
                     new TenderingCriterionPropertyGroup()
                     {
                         _cardinality = CardinalityMetadata.ExactlyOne,
                         ID = new CriteriaTaxonomyIdentifier("7458d42a-e581-4640-9283-34ceb3ad4345"),
                         PropertyGroupTypeCode = PropertyGroupTypeCode.OnAlways,
                         TenderingCriterionProperties = new[]
                         {
                           new TenderingCriterionProperty()
                           {
                             _cardinality = CardinalityMetadata.ExactlyOne,
                             ID = EuComGrowId.Random(),
                             TypeCode = CriterionElementType.Question,
                             Description = "common.yourAnswer.description",
                             ValueDataTypeCode = ResponseDataTypeCode.Indicator
                           }
                         },
                         SubsidiaryTenderingCriterionPropertyGroups = new TenderingCriterionPropertyGroup[]
                         {
                             new TenderingCriterionPropertyGroup()
                             {
                                 _cardinality = CardinalityMetadata.Optional,
                                 ID = new CriteriaTaxonomyIdentifier("41dd2e9b-1bfd-44c7-93ee-56bd74a4334b"),
                                 PropertyGroupTypeCode = PropertyGroupTypeCode.OnTrue,
                                 TenderingCriterionProperties = new[]
                                 {
                                   new TenderingCriterionProperty()
                                   {
                                     _cardinality = CardinalityMetadata.OneOrMore,
                                     ID = EuComGrowId.Random(),
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
        };


    }
}
