using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Hilma.Espd.EDM.CriterionModel.Identifiers;
using Hilma.UBL.CommonAggregateComponents;

namespace Hilma.Espd.EDM.CriterionModel
{
    public class ExclusionGroundsSpecification : IEnumerable<TenderingCriterion>
    {
        public IEnumerable<TenderingCriterion> AllCriteria => new[]
        {

      Convictions,
      Contributions,
      Social,
      Business,
      Misconduct,
      ConflictOfInterest,
      EarlyTermination,
      Misinterpretation

    }.SelectMany(c => c);

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
        CriterionTypeCode = new CriterionTypeCode("CRITERION.EXCLUSION.CONVICTIONS.PARTICIPATION_IN_CRIMINAL_ORGANISATION"),
        Name = "convictions.participationInCriminalOrganisation.name",
        Description = new[] {"convictions.participationInCriminalOrganisation.description"},
        Id = new CriteriaTaxonomyIdentifier("005eb9ed-1347-4ca3-bb29-9bc0db64e1ab"),
        Legislations = new Legislation[] { },
        TenderingCriterionPropertyGroups = CriterionHelper.ConvictionsQuestionGroup
      },
      new TenderingCriterion()
      {
        CriterionTypeCode = new CriterionTypeCode("CRITERION.EXCLUSION.CONVICTIONS.CORRUPTION"),
        Name = "convictions.corruption.name",
        Description = new[] {"convictions.corruption.description"},
        Id = new CriteriaTaxonomyIdentifier("c27b7c4e-c837-4529-b867-ed55ce639db5"),
        Legislations = new Legislation[] { },
        TenderingCriterionPropertyGroups = CriterionHelper.ConvictionsQuestionGroup
      },
      new TenderingCriterion()
      {
        CriterionTypeCode = new CriterionTypeCode("CRITERION.EXCLUSION.CONVICTIONS.FRAUD"),
        Name = "convictions.fraud.name",
        Description = new[] {"convictions.fraud.description"},
        Id = new CriteriaTaxonomyIdentifier("297d2323-3ede-424e-94bc-a91561e6f320"),
        Legislations = new Legislation[] { },
        TenderingCriterionPropertyGroups = CriterionHelper.ConvictionsQuestionGroup
      },
      new TenderingCriterion()
      {
        CriterionTypeCode = new CriterionTypeCode("CRITERION.EXCLUSION.CONVICTIONS.TERRORIST_OFFENCES"),
        Name = "convictions.terroristActivities.name",
        Description = new[] {"convictions.terroristActivities.description"},
        Id = new CriteriaTaxonomyIdentifier("d486fb70-86b3-4e75-97f2-0d71b5697c7d"),
        Legislations = new Legislation[] { },
        TenderingCriterionPropertyGroups = CriterionHelper.ConvictionsQuestionGroup
      },
      new TenderingCriterion()
      {
        CriterionTypeCode = new CriterionTypeCode("CRITERION.EXCLUSION.CONVICTIONS.MONEY_LAUNDERING"),
        Name = "convictions.moneyLaundering.name",
        Description = new[] {"convictions.moneyLaundering.description"},
        Id = new CriteriaTaxonomyIdentifier("47112079-6fec-47a3-988f-e561668c3aef"),
        Legislations = new Legislation[] { },
        TenderingCriterionPropertyGroups = CriterionHelper.ConvictionsQuestionGroup
      },
      new TenderingCriterion()
      {
        CriterionTypeCode = new CriterionTypeCode("CRITERION.EXCLUSION.CONVICTIONS.CHILD_LABOUR-HUMAN_TRAFFICKING"),
        Name = "convictions.childLabour.name",
        Description = new[] {"convictions.childLabour.description"},
        Id = new CriteriaTaxonomyIdentifier("d789d01a-fe03-4ccd-9898-73f9cfa080d1"),
        Legislations = new Legislation[] { },
        TenderingCriterionPropertyGroups = CriterionHelper.ConvictionsQuestionGroup
      },

    };

        public TenderingCriterion[] Contributions { get; set; } = new[]
        {
      new TenderingCriterion()
      {
        CriterionTypeCode = new CriterionTypeCode("CRITERION.EXCLUSION.CONTRIBUTIONS.PAYMENT_OF_TAXES"),
        Name = "contributions.paymentOfTaxes.name",
        Description = new[] {"contributions.paymentOfTaxes.description"},
        Id = new CriteriaTaxonomyIdentifier("b61bbeb7-690e-4a40-bc68-d6d4ecfaa3d4"),
        Legislations = new Legislation[] { },
        TenderingCriterionPropertyGroups = new[]
        {

          new TenderingCriterionPropertyGroup()
          {
            _cardinality = CardinalityMetadata.ExactlyOne,
            Id = new CriteriaTaxonomyIdentifier("53c9aad8-dc80-48f8-85d9-755c2aab8e95"),
            PropertyGroupTypeCode = new PropertyGroupTypeCode("ON*"),
            TenderingCriterionProperties = new[]
            {
              new TenderingCriterionProperty()
              {
                _cardinality = CardinalityMetadata.ExactlyOne,
                TypeCode = new CriterionElementType("REQUIREMENT"),
                Description = "contributions.threshold.description",
                ValueDataTypeCode = new ResponseDataTypeCode("AMOUNT")
              },
              new TenderingCriterionProperty()
              {
                _cardinality = CardinalityMetadata.ExactlyOne,
                TypeCode = new CriterionElementType("REQUIREMENT"),
                Description = "contributions.additionalInformation.description",
                ValueDataTypeCode = new ResponseDataTypeCode("DESCRIPTION")
              },

            },
            SubsidiaryTenderingCriterionPropertyGroups = new[]
            {

              new TenderingCriterionPropertyGroup()
              {
                _cardinality = CardinalityMetadata.ExactlyOne,
                Id = new CriteriaTaxonomyIdentifier("098fd3cc-466e-4233-af1a-affe09471bce"),
                PropertyGroupTypeCode = new PropertyGroupTypeCode("ON*"),
                TenderingCriterionProperties = new[]
                {
                  new TenderingCriterionProperty()
                  {
                    _cardinality = CardinalityMetadata.ExactlyOne,
                    TypeCode = new CriterionElementType("QUESTION"),
                    Description = "common.yourAnswer.description",
                    ValueDataTypeCode = new ResponseDataTypeCode("INDICATOR")
                  }
                },
                SubsidiaryTenderingCriterionPropertyGroups = new[]
                {
                  new TenderingCriterionPropertyGroup()
                  {
                    _cardinality = CardinalityMetadata.ZeroOrMore,
                    Id = new CriteriaTaxonomyIdentifier("f8499787-f9f8-4355-95e2-9784426f4d7b"),
                    PropertyGroupTypeCode = new PropertyGroupTypeCode("ONTRUE"),
                    TenderingCriterionProperties = new[]
                    {
                      new TenderingCriterionProperty()
                      {
                        _cardinality = CardinalityMetadata.ExactlyOne,
                        TypeCode = new CriterionElementType("QUESTION"),
                        Description = "common.CountryOrMemberStateConcerned.description",
                        ValueDataTypeCode = new ResponseDataTypeCode("CODE_COUNTRY")
                      },
                      new TenderingCriterionProperty()
                      {
                        _cardinality = CardinalityMetadata.ExactlyOne,
                        TypeCode = new CriterionElementType("QUESTION"),
                        Description = "common.amountConcerned.description",
                        ValueDataTypeCode = new ResponseDataTypeCode("AMOUNT")
                      },

                    },
                    SubsidiaryTenderingCriterionPropertyGroups = new[]
                    {
                      new TenderingCriterionPropertyGroup()
                      {
                        Id = new CriteriaTaxonomyIdentifier("7c2aec9f-4876-4c33-89e6-2ab6d6cf5d02"),
                        PropertyGroupTypeCode = new PropertyGroupTypeCode("ON*"),
                        TenderingCriterionProperties = new[]
                        {
                          new TenderingCriterionProperty()
                          {
                            _cardinality = CardinalityMetadata.ExactlyOne,
                            TypeCode = new CriterionElementType("QUESTION"),
                            Description ="contributions.hasThisBreachOfObligations.description",
                            ValueDataTypeCode = new ResponseDataTypeCode("INDICATOR")
                          }
                        },
                        SubsidiaryTenderingCriterionPropertyGroups = new[]
                        {
                          new TenderingCriterionPropertyGroup()
                          {
                            _cardinality = CardinalityMetadata.Optional,
                            Id = new CriteriaTaxonomyIdentifier("3cb7abf1-662a-4756-b61c-7bc716c1fafc"),
                            PropertyGroupTypeCode = new PropertyGroupTypeCode("ONTRUE"),
                            TenderingCriterionProperties = new[]
                            {
                              new TenderingCriterionProperty()
                              {
                                _cardinality = CardinalityMetadata.ExactlyOne,
                                TypeCode = new CriterionElementType("QUESTION"),
                                Description = "contributions.pleaseDescribeWhichMeansWereUsed.description",
                                ValueDataTypeCode = new ResponseDataTypeCode("DESCRIPTION")
                              }
                            },
                            SubsidiaryTenderingCriterionPropertyGroups = new[]
                            {
                                new TenderingCriterionPropertyGroup()
                                  {
                                    _cardinality = CardinalityMetadata.Optional,
                                    Id = new CriteriaTaxonomyIdentifier("fc57e473-d63e-4a04-b589-dcf81cab8052"),
                                    PropertyGroupTypeCode = new PropertyGroupTypeCode("ON*"),
                                    TenderingCriterionProperties = new[]
                                    {
                                      new TenderingCriterionProperty()
                                      {
                                        _cardinality = CardinalityMetadata.ExactlyOne,
                                        TypeCode = new CriterionElementType("QUESTION"),
                                        Description = "contributions.hasTheEconomicOperatorFulfilled.description",
                                        ValueDataTypeCode = new ResponseDataTypeCode("INDICATOR")
                                      }
                                    },
                                    SubsidiaryTenderingCriterionPropertyGroups = new[]
                                    {
                                      new TenderingCriterionPropertyGroup()
                                      {
                                        _cardinality = CardinalityMetadata.Optional,
                                        Id = new CriteriaTaxonomyIdentifier("6c3609e1-9add-4fa9-9409-62ce72ae4548"),
                                        PropertyGroupTypeCode = new PropertyGroupTypeCode("ONTRUE"),
                                        TenderingCriterionProperties = new[]
                                        {
                                          new TenderingCriterionProperty()
                                          {
                                            _cardinality = CardinalityMetadata.ExactlyOne,
                                            TypeCode = new CriterionElementType("QUESTION"),
                                            Description = "common.pleaseDescribeThem.description",
                                            ValueDataTypeCode = new ResponseDataTypeCode("DESCRIPTION")
                                          }
                                        },
                                      }
                                    }
                                  },
                            }
                          },

                          new TenderingCriterionPropertyGroup()
                          {
                            _cardinality = CardinalityMetadata.Optional,
                            Id = new CriteriaTaxonomyIdentifier("c882afa4-6971-4b00-8970-0c283eb122cc"),
                            PropertyGroupTypeCode = new PropertyGroupTypeCode("ONFALSE"),
                            TenderingCriterionProperties = new[]
                            {
                              new TenderingCriterionProperty()
                              {
                                _cardinality = CardinalityMetadata.ExactlyOne,
                                TypeCode = new CriterionElementType("QUESTION"),
                                Description = "contributions.ifThisBreachOfObligationsWas.description",
                                ValueDataTypeCode = new ResponseDataTypeCode("INDICATOR")
                              }
                            },
                            SubsidiaryTenderingCriterionPropertyGroups = new[]
                            {
                              new TenderingCriterionPropertyGroup()
                              {
                                _cardinality = CardinalityMetadata.Optional,
                                Id = new CriteriaTaxonomyIdentifier("815422d6-f8a1-418a-8bf0-3524f7c8f721"),
                                PropertyGroupTypeCode = new PropertyGroupTypeCode("ONTRUE"),
                                TenderingCriterionProperties = new[]
                                {
                                  new TenderingCriterionProperty()
                                  {
                                    _cardinality = CardinalityMetadata.ExactlyOne,
                                    TypeCode = new CriterionElementType("QUESTION"),
                                    Description = "contributions.pleaseIindicateTheDateOfConvictionOrDecision.description",
                                    ValueDataTypeCode = new ResponseDataTypeCode("DATE")
                                  },
                                  new TenderingCriterionProperty()
                                  {
                                    _cardinality = CardinalityMetadata.ExactlyOne,
                                    TypeCode = new CriterionElementType("QUESTION"),
                                    Description = "contributions.inCaseOfAConviction.description",
                                    ValueDataTypeCode = new ResponseDataTypeCode("PERIOD")
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

              new TenderingCriterionPropertyGroup()
              {
                _cardinality = CardinalityMetadata.ExactlyOne,
                Id = new CriteriaTaxonomyIdentifier("7458d42a-e581-4640-9283-34ceb3ad4345"),
                PropertyGroupTypeCode = new PropertyGroupTypeCode("ON*"),
                TenderingCriterionProperties = new[]
                {
                  new TenderingCriterionProperty()
                  {
                    _cardinality = CardinalityMetadata.ExactlyOne,
                    TypeCode = new CriterionElementType("QUESTION"),
                    Description = "common.isThisInformationAvailableElectronically.description",
                    ValueDataTypeCode = new ResponseDataTypeCode("INDICATOR")
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
        CriterionTypeCode = new CriterionTypeCode("CRITERION.EXCLUSION.CONTRIBUTIONS.PAYMENT_OF_SOCIAL_SECURITY"),
        Name = "contributions.paymentOfSocialSecurityContributions.name",
        Description = new[] {"contributions.paymentOfSocialSecurityContributions.description"},
        Id = new CriteriaTaxonomyIdentifier("7d85e333-bbab-49c0-be8d-c36d71a72f5e"),
        Legislations = new Legislation[] { },
        TenderingCriterionPropertyGroups = new[]
        {

          new TenderingCriterionPropertyGroup()
          {
            Id = new CriteriaTaxonomyIdentifier("53c9aad8-dc80-48f8-85d9-755c2aab8e95"),
            PropertyGroupTypeCode = new PropertyGroupTypeCode("ON*"),
            TenderingCriterionProperties = new[]
            {
              new TenderingCriterionProperty()
              {
                TypeCode = new CriterionElementType("QUESTION"),
                Description = "contributions.threshold.description",
                ValueDataTypeCode = new ResponseDataTypeCode("AMOUNT")
              },
              new TenderingCriterionProperty()
              {
                TypeCode = new CriterionElementType("QUESTION"),
                Description = "contributions.additionalInformation.description",
                ValueDataTypeCode = new ResponseDataTypeCode("DESCRIPTION")
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
                    Description = "common.yourAnswer.description",
                    ValueDataTypeCode = new ResponseDataTypeCode("INDICATOR")
                  },

                },
                SubsidiaryTenderingCriterionPropertyGroups = new[]
                {
                  new TenderingCriterionPropertyGroup()
                  {
                    Id = new CriteriaTaxonomyIdentifier("f8499787-f9f8-4355-95e2-9784426f4d7b"),
                    PropertyGroupTypeCode = new PropertyGroupTypeCode("ONTRUE"),
                    TenderingCriterionProperties = new[]
                    {
                      new TenderingCriterionProperty()
                      {
                        TypeCode = new CriterionElementType("QUESTION"),
                        Description = "common.CountryOrMemberStateConcerned.description",
                        ValueDataTypeCode = new ResponseDataTypeCode("CODE_COUNTRY")
                      },
                      new TenderingCriterionProperty()
                      {
                        TypeCode = new CriterionElementType("QUESTION"),
                        Description = "common.amountConcerned.description",
                        ValueDataTypeCode = new ResponseDataTypeCode("AMOUNT")
                      },

                    },
                    SubsidiaryTenderingCriterionPropertyGroups = new[]
                    {
                      new TenderingCriterionPropertyGroup()
                      {
                        Id = new CriteriaTaxonomyIdentifier("7c2aec9f-4876-4c33-89e6-2ab6d6cf5d02"),
                        PropertyGroupTypeCode = new PropertyGroupTypeCode("ON*"),
                        TenderingCriterionProperties = new[]
                        {
                          new TenderingCriterionProperty()
                          {
                            TypeCode = new CriterionElementType("QUESTION"),
                            Description = "contributions.hasThisBreachOfObligations.description",
                            ValueDataTypeCode = new ResponseDataTypeCode("INDICATOR")
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
                                Description = "contributions.pleaseDescribeWhichMeansWereUsed.description",
                                ValueDataTypeCode = new ResponseDataTypeCode("DESCRIPTION")
                              }
                            },
                          },
                          new TenderingCriterionPropertyGroup()
                          {
                            Id = new CriteriaTaxonomyIdentifier("a49e6e25-0059-47da-9397-72c2db5fd5b1"),
                            PropertyGroupTypeCode = new PropertyGroupTypeCode("ON*"),
                            TenderingCriterionProperties = new[]
                            {
                              new TenderingCriterionProperty()
                              {
                                TypeCode = new CriterionElementType("QUESTION"),
                                Description = "contributions.hasTheEconomicOperatorFulfilled.description",
                                ValueDataTypeCode = new ResponseDataTypeCode("INDICATOR")
                              }
                            },
                            SubsidiaryTenderingCriterionPropertyGroups = new[]
                            {
                              new TenderingCriterionPropertyGroup()
                              {
                                Id = new CriteriaTaxonomyIdentifier("42a44eb9-b8c9-4a67-8776-e77fc5356efe"),
                                PropertyGroupTypeCode = new PropertyGroupTypeCode("ONTRUE"),
                                TenderingCriterionProperties = new[]
                                {
                                  new TenderingCriterionProperty()
                                  {
                                    TypeCode = new CriterionElementType("QUESTION"),
                                    Description = "common.pleaseDescribeThem.description",
                                    ValueDataTypeCode = new ResponseDataTypeCode("DESCRIPTION")
                                  }
                                },
                              }
                            }
                          },
                          new TenderingCriterionPropertyGroup()
                          {
                            Id = new CriteriaTaxonomyIdentifier("536417dc-8130-4981-85c5-fceba5541c58"),
                            PropertyGroupTypeCode = new PropertyGroupTypeCode("ONFALSE"),
                            TenderingCriterionProperties = new[]
                            {
                              new TenderingCriterionProperty()
                              {
                                TypeCode = new CriterionElementType("QUESTION"),
                                Description = "contributions.ifThisBreachOfObligationsWas.description",
                                ValueDataTypeCode = new ResponseDataTypeCode("INDICATOR")
                              }
                            },
                            SubsidiaryTenderingCriterionPropertyGroups = new[]
                            {
                              new TenderingCriterionPropertyGroup()
                              {
                                Id = new CriteriaTaxonomyIdentifier("8aaac22d-1b59-442e-9210-a6e70ec05962"),
                                PropertyGroupTypeCode = new PropertyGroupTypeCode("ONTRUE"),
                                TenderingCriterionProperties = new[]
                                {
                                  new TenderingCriterionProperty()
                                  {
                                    TypeCode = new CriterionElementType("QUESTION"),
                                    Description =
                                      "contributions.pleaseIindicateTheDateOfConvictionOrDecision.description",
                                    ValueDataTypeCode = new ResponseDataTypeCode("DATE")
                                  },
                                  new TenderingCriterionProperty()
                                  {
                                    TypeCode = new CriterionElementType("QUESTION"),
                                    Description = "contributions.inCaseOfAConviction.description",
                                    ValueDataTypeCode = new ResponseDataTypeCode("PERIOD")
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
            CriterionTypeCode = new CriterionTypeCode("CRITERION.EXCLUSION.SOCIAL.ENVIRONMENTAL_LAW"),
            Name = "social.environmentalLaw.name",
            Description = new[] {"social.environmentalLaw.description"},
            Id = new CriteriaTaxonomyIdentifier("a80ddb62-d25b-4e4e-ae22-3968460dc0a9"),
            Legislations = new Legislation[] { },
            TenderingCriterionPropertyGroups = CriterionHelper.Social_LawCriterionPropertyGroups,

          },
          new TenderingCriterion()
          {
            CriterionTypeCode = new CriterionTypeCode("CRITERION.EXCLUSION.SOCIAL.SOCIAL_LAW"),
            Name = "social.socialLaw.name",
            Description = new[] {"social.socialLaw.description"},
            Id = new CriteriaTaxonomyIdentifier("a261a395-ed17-4939-9c75-b9ff1109ca6e"),
            Legislations = new Legislation[] { },
            TenderingCriterionPropertyGroups = CriterionHelper.Social_LawCriterionPropertyGroups
          },
          new TenderingCriterion()
      {
        CriterionTypeCode = new CriterionTypeCode("CRITERION.EXCLUSION.SOCIAL.LABOUR_LAW"),
        Name = "social.labourLaw.name",
        Description = new[] {"social.labourLaw.description"},
        Id = new CriteriaTaxonomyIdentifier("a34b70d6-c43d-4726-9a88-8e2b438424bf"),
        Legislations = new Legislation[] { },
        TenderingCriterionPropertyGroups = CriterionHelper.Social_LawCriterionPropertyGroups
      }
        };

        public TenderingCriterion[] Business { get; set; } = new[]
        {

          new TenderingCriterion()
          {
            CriterionTypeCode = new CriterionTypeCode("CRITERION.EXCLUSION.BUSINESS.BANKRUPTCY"),
            Name = "business.bankruptcy.name",
            Description = new[] {"business.bankruptcy.description"},
            Id = new CriteriaTaxonomyIdentifier("d3732c09-7d62-4edc-a172-241da6636e7c"),
            Legislations = new Legislation[] { },
            TenderingCriterionPropertyGroups = CriterionHelper.Business
          },
          new TenderingCriterion()
          {
            CriterionTypeCode = new CriterionTypeCode("CRITERION.EXCLUSION.BUSINESS.INSOLVENCY"),
            Name = "business.insolvency.name",
            Description = new[] {"business.insolvency.description"},
            Id = new CriteriaTaxonomyIdentifier("396f288a-e267-4c20-851a-ed4f7498f137"),
            Legislations = new Legislation[] { },
            TenderingCriterionPropertyGroups = CriterionHelper.Business
          },
          new TenderingCriterion()
          {
            CriterionTypeCode = new CriterionTypeCode("CRITERION.EXCLUSION.BUSINESS.CREDITORS_ARRANGEMENT"),
            Name = "business.arrangementWithCreditors.name",
            Description = new[] {"business.arrangementWithCreditors.description"},
            Id = new CriteriaTaxonomyIdentifier("68918c7a-f5bc-4a1a-a62f-ad8983600d48"),
            Legislations = new Legislation[] { },
            TenderingCriterionPropertyGroups = CriterionHelper.Business
          },
          new TenderingCriterion()
          {
            CriterionTypeCode = new CriterionTypeCode("CRITERION.EXCLUSION.BUSINESS.BANKRUPTCY_ANALOGOUS"),
            Name = "business.analogousSituationLikeBankruptcyUnderNationalLaw.name",
            Description = new[] {"business.analogousSituationLikeBankruptcyUnderNationalLaw.description"},
            Id = new CriteriaTaxonomyIdentifier("daffa2a9-9f8f-4568-8be8-7b8bf306d096"),
            Legislations = new Legislation[] { },
            TenderingCriterionPropertyGroups = CriterionHelper.Business
          },
          new TenderingCriterion()
          {
            CriterionTypeCode = new CriterionTypeCode("CRITERION.EXCLUSION.BUSINESS.LIQUIDATOR_ADMINISTERED"),
            Name = "business.assetsBeingAdministeredByLiquidator.name",
            Description = new[] {"business.assetsBeingAdministeredByLiquidator.description"},
            Id = new CriteriaTaxonomyIdentifier("8fda202a-0c37-41bb-9d7d-de3f49edbfcb"),
            Legislations = new Legislation[] { },
            TenderingCriterionPropertyGroups = CriterionHelper.Business
          },
          new TenderingCriterion()
      {
        CriterionTypeCode = new CriterionTypeCode("CRITERION.EXCLUSION.BUSINESS.ACTIVITIES_SUSPENDED"),
        Name = "business.businessActivitiesAreSuspended.name",
        Description = new[] {"business.businessActivitiesAreSuspended.description"},
        Id = new CriteriaTaxonomyIdentifier("166536e2-77f7-455c-b018-70582474e4f6"),
        Legislations = new Legislation[] { },
        TenderingCriterionPropertyGroups = CriterionHelper.Business
      }

        };

        public TenderingCriterion[] Misconduct { get; set; } = new[]
        {
      new TenderingCriterion()
      {
        CriterionTypeCode = new CriterionTypeCode("CRITERION.EXCLUSION.MISCONDUCT.MC_PROFESSIONAL"),
        Name = "misconduct.guiltyOfGraveProfessionalMisconduct.name",
        Description = new[] {"misconduct.guiltyOfGraveProfessionalMisconduct.description"},
        Id = new CriteriaTaxonomyIdentifier("514d3fde-1e3e-4dcd-b02a-9f984d5bbda3"),
        Legislations = new Legislation[] { },
        TenderingCriterionPropertyGroups = CriterionHelper.MisconductQuestions
      },
      new TenderingCriterion()
      {
        CriterionTypeCode = new CriterionTypeCode("CRITERION.EXCLUSION.MISCONDUCT.MARKET_DISTORTION"),
        Name = "misconduct.agreementsWithOtherEconomicOperators.name",
        Description = new[] {"misconduct.agreementsWithOtherEconomicOperators.description"},
        Id = new CriteriaTaxonomyIdentifier("56d13e3d-76e8-4f23-8af6-13e60a2ee356"),
        Legislations = new Legislation[] { },
        TenderingCriterionPropertyGroups = CriterionHelper.MisconductQuestions
      }
    };

        public TenderingCriterion[] ConflictOfInterest { get; set; } = new[]
        {
          new TenderingCriterion()
          {
            CriterionTypeCode = new CriterionTypeCode("CRITERION.EXCLUSION.CONFLICT_OF_INTEREST.PROCEDURE_PARTICIPATION"),
            Name = "conflictOfInterest.conflictOfInterest.name",
            Description = new[] {"conflictOfInterest.conflictOfInterest.description"},
            Id = new CriteriaTaxonomyIdentifier("b1b5ac18-f393-4280-9659-1367943c1a2e"),
            Legislations = new Legislation[] { },
            TenderingCriterionPropertyGroups = CriterionHelper.ConflictOfInterestQuestions
          },
          new TenderingCriterion()
      {
        CriterionTypeCode = new CriterionTypeCode("CRITERION.EXCLUSION.CONFLICT_OF_INTEREST.PROCEDURE_PREPARATION"),
        Name = "conflictOfInterest.directOrIndirectInvolvement.name",
        Description = new[] {"conflictOfInterest.directOrIndirectInvolvement.description"},
        Id = new CriteriaTaxonomyIdentifier("61874050-5130-4f1c-a174-720939c7b483"),
        Legislations = new Legislation[] { },
        TenderingCriterionPropertyGroups = CriterionHelper.ConflictOfInterestQuestions
      }
        };

        public TenderingCriterion[] EarlyTermination { get; set; } = new[]
        {
           new TenderingCriterion()
          {
            CriterionTypeCode = new CriterionTypeCode("CRITERION.EXCLUSION.CONFLICT_OF_INTEREST.EARLY_TERMINATION"),
            Name = "earlyTermination.earlyTerminationDamagesOrOtherSanctions.name",
            Description = new[] {"earlyTermination.earlyTerminationDamagesOrOtherSanctions.description"},
            Id = new CriteriaTaxonomyIdentifier("3293e92b-7f3e-42f1-bee6-a7641bb04251"),
            Legislations = new Legislation[] { },
            TenderingCriterionPropertyGroups = new[]
            {
              new TenderingCriterionPropertyGroup()
              {
                _cardinality = CardinalityMetadata.ExactlyOne,
                Id = new CriteriaTaxonomyIdentifier("67362ec7-cec3-4cb8-a38e-5d7a2a31e6d8"),
                PropertyGroupTypeCode = new PropertyGroupTypeCode("ON*"),
                TenderingCriterionProperties = new[]
                {
                  new TenderingCriterionProperty()
                  {
                    _cardinality = CardinalityMetadata.ExactlyOne,
                    TypeCode = new CriterionElementType("QUESTION"),
                    Description = "common.yourAnswer.description",
                    ValueDataTypeCode = new ResponseDataTypeCode("INDICATOR")
                  },
                },
                SubsidiaryTenderingCriterionPropertyGroups = new[]
                {
                  new TenderingCriterionPropertyGroup()
                  {
                    _cardinality = CardinalityMetadata.Optional,
                    Id = new CriteriaTaxonomyIdentifier("73f0fe4c-4ed9-4343-8096-d898cf200146"),
                    PropertyGroupTypeCode = new PropertyGroupTypeCode("ON*"),
                    TenderingCriterionProperties = new[]
                    {
                      new TenderingCriterionProperty()
                      {
                        _cardinality = CardinalityMetadata.ExactlyOne,
                        TypeCode = new CriterionElementType("QUESTION"),
                        Description = "common.pleaseDescribeThem.description",
                        ValueDataTypeCode = new ResponseDataTypeCode("DESCRIPTION")
                      },
                    },
                    SubsidiaryTenderingCriterionPropertyGroups = new[]
                    {
                      new TenderingCriterionPropertyGroup()
                      {
                        _cardinality = CardinalityMetadata.Optional,
                        Id = new CriteriaTaxonomyIdentifier("5f9f09f7-f701-432c-9fdc-c22c124a74c9"),
                        PropertyGroupTypeCode = new PropertyGroupTypeCode("ON*"),
                        TenderingCriterionProperties = new[]
                        {
                          new TenderingCriterionProperty()
                          {
                            _cardinality = CardinalityMetadata.ExactlyOne,
                            TypeCode = new CriterionElementType("QUESTION"),
                            Description = "common.measuresToDemonstrateYourReliability.description",
                            ValueDataTypeCode = new ResponseDataTypeCode("INDICATOR")
                          },
                        },
                        SubsidiaryTenderingCriterionPropertyGroups = new[]
                        {
                          new TenderingCriterionPropertyGroup()
                          {
                            _cardinality = CardinalityMetadata.Optional,
                            Id = new CriteriaTaxonomyIdentifier("74e6c7b4-757b-4b40-ada6-fad6a997c310"),
                            PropertyGroupTypeCode = new PropertyGroupTypeCode("ONTRUE"),
                            TenderingCriterionProperties = new[]
                            {
                              new TenderingCriterionProperty()
                              {
                                TypeCode = new CriterionElementType("QUESTION"),
                                Description = "common.pleaseDescribeThem.description",
                                ValueDataTypeCode = new ResponseDataTypeCode("DESCRIPTION")
                              },
                            }
                          }

                        }
                      }

                    }
                  },

                }
              },
              new TenderingCriterionPropertyGroup()
                   {
                       _cardinality = CardinalityMetadata.ExactlyOne,
                       Id = new CriteriaTaxonomyIdentifier("7458d42a-e581-4640-9283-34ceb3ad4345"),
                       PropertyGroupTypeCode = new PropertyGroupTypeCode("ON*"),
                       TenderingCriterionProperties = new[]
                       {
                           new TenderingCriterionProperty()
                           {
                             _cardinality = CardinalityMetadata.ExactlyOne,
                             TypeCode = new CriterionElementType("QUESTION"),
                             Description ="common.informationAvailableFromEUDb.description",
                             ValueDataTypeCode = new ResponseDataTypeCode("INDICATOR")
                           },
                       },
                       SubsidiaryTenderingCriterionPropertyGroups = CriterionHelper.TenderingCriterionURLGroup
                   }
            }
          }
        };

        public TenderingCriterion[] Misinterpretation { get; set; } = new[]
        {
            new TenderingCriterion()
            {
                CriterionTypeCode = new CriterionTypeCode("CRITERION.EXCLUSION.CONFLICT_OF_INTEREST.MISINTERPRETATION"),
                Name = "misinterpretation.guiltyOfMisinterpretation.name",
                Description = new[]
                {
                    "misinterpretation.guiltyOfMisinterpretation.description",
                    "misinterpretation.guiltyOfMisinterpretationA.description",
                    "misinterpretation.guiltyOfMisinterpretationB.description",
                    "misinterpretation.guiltyOfMisinterpretationC.description"
                },
                Id = new CriteriaTaxonomyIdentifier("696a75b2-6107-428f-8b74-82affb67e184"),
                Legislations = new Legislation[] { },
                TenderingCriterionPropertyGroups = new[]
                {
                    new TenderingCriterionPropertyGroup()
                    {
                        _cardinality = CardinalityMetadata.ExactlyOne,
                        Id = new CriteriaTaxonomyIdentifier("f3a6836d-2de2-4cd1-81ca-fb06178d05c5"),
                        PropertyGroupTypeCode = new PropertyGroupTypeCode("ON*"),
                        TenderingCriterionProperties = new[]
                        {
                            new TenderingCriterionProperty()
                            {
                                _cardinality = CardinalityMetadata.ExactlyOne,
                                TypeCode = new CriterionElementType("QUESTION"),
                                Description = "common.yourAnswer.description",
                                ValueDataTypeCode = new ResponseDataTypeCode("INDICATOR")
                            },
                        }
                    },
                    new TenderingCriterionPropertyGroup()
                   {
                       _cardinality = CardinalityMetadata.ExactlyOne,
                       Id = new CriteriaTaxonomyIdentifier("7458d42a-e581-4640-9283-34ceb3ad4345"),
                       PropertyGroupTypeCode = new PropertyGroupTypeCode("ON*"),
                       TenderingCriterionProperties = new[]
                       {
                           new TenderingCriterionProperty()
                           {
                             _cardinality = CardinalityMetadata.ExactlyOne,
                             TypeCode = new CriterionElementType("QUESTION"),
                             Description ="common.informationAvailableFromEUDb.description",
                             ValueDataTypeCode = new ResponseDataTypeCode("INDICATOR")
                           },
                       },
                       SubsidiaryTenderingCriterionPropertyGroups = CriterionHelper.TenderingCriterionURLGroup
                   }
                }
            }
        };

        //TODO
        public TenderingCriterion[] PurelyNational { get; set; } = new[]
        {
      new TenderingCriterion()
      {
        CriterionTypeCode = new CriterionTypeCode("CRITERION.EXCLUSION.NATIONAL.OTHER"),
        Name = "Purely national exclusion grounds",
        Description = new[]
        {
          "Other exclusion grounds that may be foreseen in the national legislation of the contracting authority's or contracting entity's Member State. Has the economic operator breached its obligations relating to the purely national grounds of exclusion, which are specified in the relevant notice or in the procurement documents?"
        },
        Id = new CriteriaTaxonomyIdentifier("63adb07d-db1b-4ef0-a14e-a99785cf8cf6"),
        Legislations = new Legislation[] { },
        TenderingCriterionPropertyGroups = new[]
        {
          new TenderingCriterionPropertyGroup()
          {
            Id = new CriteriaTaxonomyIdentifier("f3a6836d-2de2-4cd1-81ca-fb06178d05c5"),
            PropertyGroupTypeCode = new PropertyGroupTypeCode("ON*"),
            TenderingCriterionProperties = new[]
            {
              new TenderingCriterionProperty()
              {
                TypeCode = new CriterionElementType("QUESTION"),
                Description = "common.yourAnswer.description",
                ValueDataTypeCode = new ResponseDataTypeCode("INDICATOR")
              },
            },
            SubsidiaryTenderingCriterionPropertyGroups = CriterionHelper.TenderingCriterionURLGroup
          }
        }
      }
    };

    };
}