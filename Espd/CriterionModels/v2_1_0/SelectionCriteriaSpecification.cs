using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Hilma.Espd.EDM.CriterionModels.v2_1_0.Identifiers;
using Hilma.UBL.CommonAggregateComponents;
using UBL.Enums;

namespace Hilma.Espd.EDM.CriterionModels.v2_1_0
{
    public class SelectionCriteriaSpecification : IEnumerable<TenderingCriterion>
    {
        public IEnumerable<TenderingCriterion> AllCriteria => new[]
        {
            Suitability,
            GeneralYearlyTurnover,
            GeneralAvarageTurnover,
            SpecificYearlyTurnover,
            SpecificAverageTurnover,
            SetupOfEconomicOperator,
            FinancialRatios,
            ProfessionalRiskInsurance,
            OtherEconomicOrFinancial,
            References,
            AbilitiesPersons,
            AbilitiesFacilities,
            AbilitiesEducation,
            AbilitiesChecks,
            AbilitiesStaff,
            SubcontractingProportion,
            SamplesCertificates,
            QualityAssurance

        }.SelectMany(c => c);

        public IEnumerator<TenderingCriterion> GetEnumerator()
        {
            return AllCriteria.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return AllCriteria.GetEnumerator();
        }

        public TenderingCriterion[] Suitability => new[]
         {
          new TenderingCriterion
          {
            CriterionTypeCode = new CriterionTypeCode("CRITERION.SELECTION.SUITABILITY.PROFESSIONAL_REGISTER_ENROLMENT"),
            Name = "suitability.enrolmentInRelevantProfessionalRegister.name",
            Description = new[] {"suitability.enrolmentInRelevantProfessionalRegister.description"},
            Id = new CriteriaTaxonomyIdentifier("6ee55a59-6adb-4c3a-b89f-e62a7ad7be7f"),
            Legislations = new Legislation[] { },
            TenderingCriterionPropertyGroups =  CriterionHelper.SuitabilityRegisterQuestionsGroups
          },
          new TenderingCriterion
          {
            CriterionTypeCode = new CriterionTypeCode("CRITERION.SELECTION.SUITABILITY.TRADE_REGISTER_ENROLMENT"),
            Name = "suitability.tradeRegisterEnrolment.name",
            Description = new[] {"suitability.tradeRegisterEnrolment.description"},
            Id = new CriteriaTaxonomyIdentifier("87b3fa26-3549-4f92-b8e0-3fd8f04bf5c7"),
            Legislations = new Legislation[] { },
            TenderingCriterionPropertyGroups = CriterionHelper.SuitabilityRegisterQuestionsGroups
          },
          new TenderingCriterion
          {
            CriterionTypeCode = new CriterionTypeCode("CRITERION.SELECTION.SUITABILITY.AUTHORISATION"),
            Name = "suitability.authorisationForParticularOrganisationNeeded.name",
            Description = new[] {"suitability.authorisationForParticularOrganisationNeeded.description"},
            Id = new CriteriaTaxonomyIdentifier("9eeb6d5c-0eb8-48e8-a4c5-5087a7c095a4"),
            Legislations = new Legislation[] { },
            TenderingCriterionPropertyGroups = CriterionHelper.SuitabilityRegisterQuestionsGroups,
            ApplicableContractType = ContractType.Services
          },
          new TenderingCriterion
          {
            CriterionTypeCode = new CriterionTypeCode("CRITERION.SELECTION.SUITABILITY.MEMBERSHIP"),
            Name = "suitability.membershipForParticularOrganisationNeeded.name",
            Description = new[] {"suitability.membershipForParticularOrganisationNeeded.description"},
            Id = new CriteriaTaxonomyIdentifier("73f10e36-ed7a-412e-995c-aa76463e3776"),
            Legislations = new Legislation[] { },
            TenderingCriterionPropertyGroups = CriterionHelper.SuitabilityRegisterQuestionsGroups,
            ApplicableContractType = ContractType.Services
          }

        };
        public TenderingCriterion[] GeneralYearlyTurnover => new[]
        {
            new TenderingCriterion()
            {
                CriterionTypeCode = new CriterionTypeCode("CRITERION.SELECTION.ECONOMIC_FINANCIAL_STANDING.TURNOVER.GENERAL_YEARLY"),
                Name = "economicFinancialStanding.generalTurnoverYearly.name",
                Description = new[] { "economicFinancialStanding.generalTurnoverYearly.description"},
                Id = new CriteriaTaxonomyIdentifier("499efc97-2ac1-4af2-9e84-323c2ca67747"),
                Legislations = new Legislation[] { },
                TenderingCriterionPropertyGroups = new []
                {
                    new TenderingCriterionPropertyGroup()
                    {
                        _cardinality = CardinalityMetadata.OneOrMore,
                        Id = new CriteriaTaxonomyIdentifier("5ca58d66-3ef1-4145-957c-45d5b18a837f"),
                        PropertyGroupTypeCode = PropertyGroupTypeCode.OnAlways,
                        TenderingCriterionProperties = new []
                        {
                            new TenderingCriterionProperty()
                            {
                              _cardinality = CardinalityMetadata.ExactlyOne,
                              Id = EuComGrowId.Random(),
                              TypeCode = CriterionElementType.Requirement,
                              Description = "economicFinancialStanding.minimumRequirement.description",
                              ValueDataTypeCode = ResponseDataTypeCode.Amount
                            },
                        },
                        SubsidiaryTenderingCriterionPropertyGroups = new []
                        {
                            new TenderingCriterionPropertyGroup()
                            {
                                _cardinality = CardinalityMetadata.ExactlyOne,
                                Id = new CriteriaTaxonomyIdentifier("c0cd9c1c-e90a-4ff9-bce3-ac0fe31abf16"),
                                PropertyGroupTypeCode = PropertyGroupTypeCode.OnAlways,
                                TenderingCriterionProperties = new []
                                {
                                    new TenderingCriterionProperty()
                                    {
                                        _cardinality = CardinalityMetadata.ExactlyOne,
                                        Id = EuComGrowId.Random(),
                                        TypeCode = CriterionElementType.Question,
                                        Description = "common.amount.description",
                                        ValueDataTypeCode = ResponseDataTypeCode.Amount,
                                    },
                                    //pitäisikö olla period tyyppinen eikä kahta date kenttää?
                                    new TenderingCriterionProperty()
                                    {
                                        _cardinality = CardinalityMetadata.ExactlyOne,
                                        Id = EuComGrowId.Random(),
                                        TypeCode = CriterionElementType.Question,
                                        Description = "common.startDate.description",
                                        ValueDataTypeCode = ResponseDataTypeCode.Date,
                                    },
                                    new TenderingCriterionProperty()
                                    {
                                        _cardinality = CardinalityMetadata.ExactlyOne,
                                        Id = EuComGrowId.Random(),
                                        TypeCode = CriterionElementType.Question,
                                        Description = "common.endDate.description",
                                        ValueDataTypeCode = ResponseDataTypeCode.Date
                                    },
                                }
                            },
                            CriterionHelper.IsThisInformationAvailableElectronically
                        }
                    }
                }
            },
        };
        public TenderingCriterion[] GeneralAvarageTurnover => new[]
        {
            new TenderingCriterion()
            {
                CriterionTypeCode =
                  new CriterionTypeCode("CRITERION.SELECTION.ECONOMIC_FINANCIAL_STANDING.TURNOVER.AVERAGE_YEARLY"),
                Name = "economicFinancialStanding.averageTurnoverYearly.name",
                Description = new[] {"economicFinancialStanding.specificTurnoverYearly.description"},
                Id = new CriteriaTaxonomyIdentifier("b16cb9fc-6cb7-4585-9302-9533b415cf48"),
                Legislations = new Legislation[] { },
                TenderingCriterionPropertyGroups = new[]
                {
                  new TenderingCriterionPropertyGroup()
                  {
                    _cardinality = CardinalityMetadata.ExactlyOne,
                    Id = new CriteriaTaxonomyIdentifier("53882893-f4a8-40ae-99dc-cad7b0748790"),
                    PropertyGroupTypeCode = PropertyGroupTypeCode.OnAlways,
                    TenderingCriterionProperties = new[]
                    {
                      new TenderingCriterionProperty()
                      {
                        _cardinality = CardinalityMetadata.ExactlyOne,
                        Id = EuComGrowId.Random(),
                        TypeCode = CriterionElementType.Requirement,
                        Description = "common.startDateEndDate.description",
                        ValueDataTypeCode = ResponseDataTypeCode.Period,
                      },
                      new TenderingCriterionProperty()
                      {
                        _cardinality = CardinalityMetadata.ExactlyOne,
                        Id = EuComGrowId.Random(),
                        TypeCode = CriterionElementType.Requirement,
                        Description = "economicFinancialStanding.minimumRequirement.description",
                        ValueDataTypeCode = ResponseDataTypeCode.Amount
                      },

                    },
                    SubsidiaryTenderingCriterionPropertyGroups = new[]
                    {
                      new TenderingCriterionPropertyGroup()
                      {
                        Id = new CriteriaTaxonomyIdentifier("e1886054-ada4-473c-9afc-2fde82c24cf4"),
                        PropertyGroupTypeCode = PropertyGroupTypeCode.OnAlways,
                        TenderingCriterionProperties = new[]
                        {
                          new TenderingCriterionProperty()
                          {
                            _cardinality = CardinalityMetadata.ExactlyOne,
                            Id = EuComGrowId.Random(),
                            TypeCode = CriterionElementType.Question,
                            Description = "economicFinancialStanding.averageForRequiredPeriod.description",
                            ValueDataTypeCode = ResponseDataTypeCode.Amount,
                          },
                          new TenderingCriterionProperty()
                          {
                            _cardinality = CardinalityMetadata.ExactlyOne,
                            Id = EuComGrowId.Random(),
                            TypeCode = CriterionElementType.Question,
                            Description = "economicFinancialStanding.cpvCode.description",
                            ValueDataTypeCode = ResponseDataTypeCode.Description,
                          }
                        }
                      },
                      CriterionHelper.IsThisInformationAvailableElectronically
                    }
                  }
                }
           }
        };
        public TenderingCriterion[] SpecificAverageTurnover => new[]
        {
            new TenderingCriterion()
            {
                CriterionTypeCode =
                  new CriterionTypeCode("CRITERION.SELECTION.ECONOMIC_FINANCIAL_STANDING.TURNOVER.SPECIFIC_AVERAGE"),
                Name = "specificAverageTurnover.question.name",
                Description = new[] {"specificAverageTurnover.question.description"},
                Id = new CriteriaTaxonomyIdentifier("d3dfb714-f558-4512-bbc5-e456fa2339de"),
                Legislations = new Legislation[] { },
                TenderingCriterionPropertyGroups = new[]
            {
                new TenderingCriterionPropertyGroup()
                {
                    _cardinality = CardinalityMetadata.ExactlyOne,
                    Id = new CriteriaTaxonomyIdentifier("6cff132b-8d15-4f79-ae37-2f9295432381"),
                    PropertyGroupTypeCode = PropertyGroupTypeCode.OnAlways,
                    TenderingCriterionProperties = new[]
                    {
                        new TenderingCriterionProperty()
                        {
                          _cardinality = CardinalityMetadata.ExactlyOne,
                          Id = EuComGrowId.Random(),
                          TypeCode = CriterionElementType.Requirement,
                          Description = "common.numberOfFiscalYears.description",
                          ValueDataTypeCode = ResponseDataTypeCode.QuantityInteger,
                        },
                        new TenderingCriterionProperty()
                        {
                          _cardinality = CardinalityMetadata.OneOrMore,
                          Id = EuComGrowId.Random(),
                          TypeCode = CriterionElementType.Requirement,
                          Description = "specificAverageTurnover.ausinessDomainDescription.description",
                          ValueDataTypeCode = ResponseDataTypeCode.Description,
                        },
                        new TenderingCriterionProperty()
                        {
                          _cardinality = CardinalityMetadata.ExactlyOne,
                          Id = EuComGrowId.Random(),
                          TypeCode = CriterionElementType.Requirement,
                          Description = "common.minimumRequirement.description",
                          ValueDataTypeCode = ResponseDataTypeCode.Amount,
                        },
                    },
                    SubsidiaryTenderingCriterionPropertyGroups = new TenderingCriterionPropertyGroup[]
                    {
                       new TenderingCriterionPropertyGroup()
                       {
                         _cardinality = CardinalityMetadata.ExactlyOne,
                         Id = new CriteriaTaxonomyIdentifier("6d87673d-af3f-4c39-b0e4-fbef046bd435"),
                         PropertyGroupTypeCode = PropertyGroupTypeCode.OnAlways,
                         TenderingCriterionProperties = new[]
                         {
                           new TenderingCriterionProperty()
                           {
                             Id = EuComGrowId.Random(),
                             TypeCode = CriterionElementType.Caption,
                             Description = "specificAverageTurnover.cpvs.description",

                             ValueDataTypeCode = ResponseDataTypeCode.None
                           },
                           new TenderingCriterionProperty()
                           {
                             _cardinality = CardinalityMetadata.OneOrMore,
                             Id = EuComGrowId.Random(),
                             TypeCode = CriterionElementType.Requirement,
                             Description = "common.cpvCode.description",
                             ValueDataTypeCode = ResponseDataTypeCode.Code,
                             CodeListId = CodeListIds.CpvCodes,
                           }
                         }
                        },
                       new TenderingCriterionPropertyGroup()
                       {
                           _cardinality = CardinalityMetadata.ExactlyOne,
                           Id = new CriteriaTaxonomyIdentifier("c0cd9c1c-e90a-4ff9-bce3-ac0fe31abf16"),
                           PropertyGroupTypeCode = PropertyGroupTypeCode.OnAlways,
                           TenderingCriterionProperties = new[]
                           {
                               new TenderingCriterionProperty()
                               {
                                 _cardinality = CardinalityMetadata.ExactlyOne,
                                 Id = EuComGrowId.Random(),
                                 TypeCode = CriterionElementType.Question,
                                 Description = "common.startDateEndDate.description",
                                 ValueDataTypeCode = ResponseDataTypeCode.Period
                               },
                               new TenderingCriterionProperty()
                               {
                                 _cardinality = CardinalityMetadata.ExactlyOne,
                                 Id = EuComGrowId.Random(),
                                 TypeCode = CriterionElementType.Question,
                                 Description = "common.amount.description",
                                 ValueDataTypeCode = ResponseDataTypeCode.Amount
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
                                         Description = "common.evidenceSupplied",
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
        };
        public TenderingCriterion[] SpecificYearlyTurnover => new[]
        {
            new TenderingCriterion()
            {
                CriterionTypeCode =
                  new CriterionTypeCode("CRITERION.SELECTION.ECONOMIC_FINANCIAL_STANDING.TURNOVER.SPECIFIC_YEARLY"),
                Name = "economicFinancialStanding.specificTurnoverYearly.name",
                Description = new[] {"economicFinancialStanding.specificTurnoverYearly.description"},
                Id = new CriteriaTaxonomyIdentifier("074f6031-55f9-4e99-b9a4-c4363e8bc315"),
                Legislations = new Legislation[] { },
                TenderingCriterionPropertyGroups = new[]
                {
                    new TenderingCriterionPropertyGroup()
                    {
                        _cardinality = CardinalityMetadata.ExactlyOne,
                        Id = new CriteriaTaxonomyIdentifier("5ca58d66-3ef1-4145-957c-45d5b18a837f"),
                        PropertyGroupTypeCode = PropertyGroupTypeCode.OnAlways,
                        TenderingCriterionProperties = new[]
                        {
                          new TenderingCriterionProperty()
                          {
                            _cardinality = CardinalityMetadata.ExactlyOne,
                            Id = EuComGrowId.Random(),
                            TypeCode = CriterionElementType.Requirement,
                            Description = "economicFinancialStanding.numberOfFiscalYears.description",
                            ValueDataTypeCode = ResponseDataTypeCode.QuantityInteger
                          },
                          new TenderingCriterionProperty()
                          {
                            _cardinality= CardinalityMetadata.ExactlyOne,
                            Id = EuComGrowId.Random(),
                            TypeCode = CriterionElementType.Requirement,
                            Description = "economicFinancialStanding.businessDomainDescription.description",
                            ValueDataTypeCode = ResponseDataTypeCode.Description,
                          },
                          new TenderingCriterionProperty()
                          {
                            _cardinality= CardinalityMetadata.ExactlyOne,
                            Id = EuComGrowId.Random(),
                            TypeCode = CriterionElementType.Question,
                            Description = "common.minimumRequirement.description",
                            ValueDataTypeCode = ResponseDataTypeCode.Amount
                          }
                        },
                        SubsidiaryTenderingCriterionPropertyGroups = new[]
                         {
                             new TenderingCriterionPropertyGroup()
                             {
                                 _cardinality= CardinalityMetadata.ExactlyOne,
                                 Id = new CriteriaTaxonomyIdentifier("6d87673d-af3f-4c39-b0e4-fbef046bd435"),
                                 PropertyGroupTypeCode = PropertyGroupTypeCode.OnAlways,
                                 TenderingCriterionProperties = new[]
                                 {
                                   new TenderingCriterionProperty()
                                   {
                                     _cardinality= CardinalityMetadata.ExactlyOne,
                                     Id = EuComGrowId.Random(),
                                     TypeCode = CriterionElementType.Caption,
                                     Description = "economicFinancialStanding.cpvsCaption.description",
                                     ValueDataTypeCode = ResponseDataTypeCode.None,
                                   },
                                   new TenderingCriterionProperty()
                                   {
                                     _cardinality= CardinalityMetadata.OneOrMore,
                                     Id = EuComGrowId.Random(),
                                     TypeCode = CriterionElementType.Requirement,
                                     Description = "common.cpvCode.description",
                                     ValueDataTypeCode = ResponseDataTypeCode.Code,
                                     CodeListId = CodeListIds.CpvCodes
                                   }

                                 }
                             },
                             new TenderingCriterionPropertyGroup()
                               {
                                 _cardinality= CardinalityMetadata.OneOrMore,
                                 Id = new CriteriaTaxonomyIdentifier("c0cd9c1c-e90a-4ff9-bce3-ac0fe31abf16"),
                                 PropertyGroupTypeCode = PropertyGroupTypeCode.OnAlways,
                                 TenderingCriterionProperties = new[]
                                 {

                                   new TenderingCriterionProperty()
                                   {
                                     _cardinality= CardinalityMetadata.ExactlyOne,
                                     Id = EuComGrowId.Random(),
                                     TypeCode = CriterionElementType.Question,
                                     Description = "common.startDateEndDate.description",
                                     ValueDataTypeCode = ResponseDataTypeCode.Period,
                                   },
                                   new TenderingCriterionProperty()
                                   {
                                     _cardinality= CardinalityMetadata.ExactlyOne,
                                     Id = EuComGrowId.Random(),
                                     TypeCode = CriterionElementType.Question,
                                     Description = "common.amount.description",
                                     ValueDataTypeCode = ResponseDataTypeCode.Amount,
                                   }
                                 }
                               },
                             CriterionHelper.IsThisInformationAvailableElectronically
                         }
                    }
                }
            },
        };
        public TenderingCriterion[] SetupOfEconomicOperator => new[]
        {
             new TenderingCriterion()
             {
                 CriterionTypeCode =
                   new CriterionTypeCode("CRITERION.SELECTION.ECONOMIC_FINANCIAL_STANDING.TURNOVER.SET_UP"),
                 Name = "setupOfEconomicOperator.question.name",
                 Description = new[] {"setupOfEconomicOperator.question.description"},
                 Id = new CriteriaTaxonomyIdentifier("77f481ce-ffb6-483f-8e2b-c78db5e68292"),
                 Legislations = new Legislation[] { },
                 TenderingCriterionPropertyGroups = new[]
                 {
                    new TenderingCriterionPropertyGroup()
                    {
                        _cardinality = CardinalityMetadata.ExactlyOne,
                        Id = new CriteriaTaxonomyIdentifier("e9aa7763-c167-4352-8060-1a3d7d3e2662"),
                        PropertyGroupTypeCode = PropertyGroupTypeCode.OnAlways,
                        TenderingCriterionProperties = new[]
                        {
                          new TenderingCriterionProperty()
                          {
                            _cardinality = CardinalityMetadata.ExactlyOne,
                            Id = EuComGrowId.Random(),
                            TypeCode = CriterionElementType.Question,
                            Description = "common.pleaseSpecify.description",
                            ValueDataTypeCode = ResponseDataTypeCode.Date
                          }
                        },
                        SubsidiaryTenderingCriterionPropertyGroups = new TenderingCriterionPropertyGroup[]
                        {
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
                                            Description = "common.evidenceSupplied",
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
        };
        public TenderingCriterion[] FinancialRatios
        {
            get
            {
                return new[]
                {
              new TenderingCriterion()
              {
                CriterionTypeCode =
                  new CriterionTypeCode("CRITERION.SELECTION.ECONOMIC_FINANCIAL_STANDING.FINANCIAL_RATIO"),
                Name = "financialRatios.question.name",
                Description = new[] {"financialRatios.question.description"},
                Id = new CriteriaTaxonomyIdentifier("e4d37adc-08cd-4f4d-a8d8-32b62b0a1f46"),
                Legislations = new Legislation[] { },
                TenderingCriterionPropertyGroups = new[]
                {
                  new TenderingCriterionPropertyGroup()
                  {
                    _cardinality = CardinalityMetadata.OneOrMore,
                    Id = new CriteriaTaxonomyIdentifier("cc1da737-6c4e-4f4e-821d-c260029058f6"),
                    PropertyGroupTypeCode = PropertyGroupTypeCode.OnAlways,
                    TenderingCriterionProperties = new[]
                    {
                      new TenderingCriterionProperty()
                      {
                        _cardinality = CardinalityMetadata.ExactlyOne,
                        Id = EuComGrowId.Random(),
                        TypeCode = CriterionElementType.Requirement,
                        Description = "financialRatios.selectPeriods.description",
                        ValueDataTypeCode = ResponseDataTypeCode.Period
                      }
                    },
                    SubsidiaryTenderingCriterionPropertyGroups = new TenderingCriterionPropertyGroup[]
                    {
                      new TenderingCriterionPropertyGroup()
                      {
                        _cardinality = CardinalityMetadata.OneOrMore,
                        Id = new CriteriaTaxonomyIdentifier("ee486082-93fa-4c17-8920-fdf01b890bd1"),
                        PropertyGroupTypeCode = PropertyGroupTypeCode.OnAlways,
                        TenderingCriterionProperties = new[]
                        {
                          new TenderingCriterionProperty()
                          {
                            _cardinality = CardinalityMetadata.ExactlyOne,
                            Id = EuComGrowId.Random(),
                            TypeCode = CriterionElementType.Requirement,
                            Description = "financialRatios.ratioType.description",
                            ValueDataTypeCode = ResponseDataTypeCode.Code,
                            CodeListId = CodeListIds.FinancialRatioType
                          },
                          new TenderingCriterionProperty()
                          {
                            _cardinality = CardinalityMetadata.ExactlyOne,
                            Id = EuComGrowId.Random(),
                            TypeCode = CriterionElementType.Requirement,
                            Description = "financialRatios.definition.description",
                            ValueDataTypeCode = ResponseDataTypeCode.Description
                          },
                          new TenderingCriterionProperty()
                          {
                            _cardinality = CardinalityMetadata.ExactlyOne,
                            Id = EuComGrowId.Random(),
                            TypeCode = CriterionElementType.Requirement,
                            Description = "common.minimumRequirement.description",
                            ValueDataTypeCode = ResponseDataTypeCode.Quantity
                          }
                        }
                      },
                      new TenderingCriterionPropertyGroup()
                      {
                        _cardinality = CardinalityMetadata.ExactlyOne,
                        Id = new CriteriaTaxonomyIdentifier("e9aa7763-c167-4352-8060-1a3d7d3e2662"),
                        PropertyGroupTypeCode = PropertyGroupTypeCode.OnAlways,
                        TenderingCriterionProperties = new[]
                        {
                          new TenderingCriterionProperty()
                          {
                            _cardinality = CardinalityMetadata.ExactlyOne,
                            Id = EuComGrowId.Random(),
                            TypeCode = CriterionElementType.Question,
                            Description = "financialRatios.pleaseProvideYourRatio.description",
                            ValueDataTypeCode = ResponseDataTypeCode.Quantity
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
                                Description = "common.evidenceSupplied",
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
            };
            }
        }
        public TenderingCriterion[] ProfessionalRiskInsurance => new[]
        {
            new TenderingCriterion()
            {
                 CriterionTypeCode =
                   new CriterionTypeCode("CRITERION.SELECTION.ECONOMIC_FINANCIAL_STANDING.RISK_INDEMNITY_INSURANCE"),
                 Name = "professionalRiskInsurance.question.name",
                 Description = new[] {"professionalRiskInsurance.question.description"},
                 Id = new CriteriaTaxonomyIdentifier("7604bd40-4462-4086-8763-a50da51a869c"),
                 Legislations = new Legislation[] { },
                 TenderingCriterionPropertyGroups = new[]
                 {
                     new TenderingCriterionPropertyGroup()
                     {
                        _cardinality = CardinalityMetadata.OneOrMore,
                        Id = new CriteriaTaxonomyIdentifier("83e3dcc4-c9b3-47e5-9fb8-ffd8386679f1"),
                        PropertyGroupTypeCode = PropertyGroupTypeCode.OnAlways,
                        TenderingCriterionProperties = new[]
                        {
                          new TenderingCriterionProperty()
                          {
                            _cardinality = CardinalityMetadata.ExactlyOne,
                            Id = EuComGrowId.Random(),
                            TypeCode = CriterionElementType.Caption,
                            Description = "common.lotsTheRequirementAppliesTo.description",
                            ValueDataTypeCode = ResponseDataTypeCode.None
                          }
                        },
                        SubsidiaryTenderingCriterionPropertyGroups = new TenderingCriterionPropertyGroup[]
                        {
                            new TenderingCriterionPropertyGroup()
                            {
                                _cardinality = CardinalityMetadata.OneOrMore,
                                Id = new CriteriaTaxonomyIdentifier("cc1da737-6c4e-4f4e-821d-c260029058f6"),
                                PropertyGroupTypeCode = PropertyGroupTypeCode.OnAlways,
                                TenderingCriterionProperties = new[]
                                {
                                  new TenderingCriterionProperty()
                                  {
                                    _cardinality = CardinalityMetadata.ZeroOrMore,
                                    Id = EuComGrowId.Random(),
                                    TypeCode = CriterionElementType.Requirement,
                                    Description = "common.lotID.description",
                                    ValueDataTypeCode = ResponseDataTypeCode.LotIdentifier
                                  }
                                },
                                SubsidiaryTenderingCriterionPropertyGroups = new TenderingCriterionPropertyGroup[]
                                {
                                    new TenderingCriterionPropertyGroup()
                                    {
                                        _cardinality = CardinalityMetadata.OneOrMore,
                                        Id = new CriteriaTaxonomyIdentifier("6fc3a90b-0759-4517-af64-ce7d6eb4bf24"),
                                        PropertyGroupTypeCode = PropertyGroupTypeCode.OnAlways,
                                        TenderingCriterionProperties = new[]
                                        {
                                          new TenderingCriterionProperty()
                                          {
                                            _cardinality = CardinalityMetadata.ExactlyOne,
                                            Id = EuComGrowId.Random(),
                                            TypeCode = CriterionElementType.Requirement,
                                            Description = "professionalRiskInsurance.typeOfInsurance.description",
                                            ValueDataTypeCode = ResponseDataTypeCode.Description
                                          },
                                          new TenderingCriterionProperty()
                                          {
                                            _cardinality = CardinalityMetadata.ExactlyOne,
                                            Id = EuComGrowId.Random(),
                                            TypeCode = CriterionElementType.Requirement,
                                            Description = "common.minimumAmount.description",
                                            ValueDataTypeCode = ResponseDataTypeCode.Amount
                                          }
                                        },
                                        SubsidiaryTenderingCriterionPropertyGroups = new TenderingCriterionPropertyGroup[]
                                        {
                                            new TenderingCriterionPropertyGroup()
                                            {
                                                _cardinality = CardinalityMetadata.ExactlyOne,
                                                Id = new CriteriaTaxonomyIdentifier("42dc8062-974d-4201-91ba-7f2ea90338fd"),
                                                PropertyGroupTypeCode = PropertyGroupTypeCode.OnAlways,
                                                TenderingCriterionProperties = new[]
                                                {
                                                  new TenderingCriterionProperty()
                                                  {
                                                    _cardinality = CardinalityMetadata.ExactlyOne,
                                                    Id = EuComGrowId.Random(),
                                                    TypeCode = CriterionElementType.Question,
                                                    Description = "common.amount.description",
                                                    ValueDataTypeCode = ResponseDataTypeCode.Amount
                                                  },
                                                  new TenderingCriterionProperty()
                                                  {
                                                    _cardinality = CardinalityMetadata.ExactlyOne,
                                                    Id = EuComGrowId.Random(),
                                                    TypeCode = CriterionElementType.Question,
                                                    Description = "professionalRiskInsurance.asAnEO.description",
                                                    ValueDataTypeCode = ResponseDataTypeCode.Indicator
                                                  },
                                                  new TenderingCriterionProperty()
                                                  {
                                                    _cardinality = CardinalityMetadata.ExactlyOne,
                                                    Id = EuComGrowId.Random(),
                                                    TypeCode = CriterionElementType.Question,
                                                    Description = "professionalRiskInsurance.iAmExempt.description",
                                                    ValueDataTypeCode = ResponseDataTypeCode.Indicator
                                                  },

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
                                                            Description = "common.evidenceSupplied",
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
                 }
            }
        };
        public TenderingCriterion[] OtherEconomicOrFinancial => new[]
        {
            new TenderingCriterion()
            {
                CriterionTypeCode =
                   new CriterionTypeCode("CRITERION.SELECTION.ECONOMIC_FINANCIAL_STANDING.OTHER_REQUIREMENTS"),
                 Name = "otherEconomicOrFinancial.question.name",
                 Description = new[] {"otherEconomicOrFinancial.question.description"},
                 Id = new CriteriaTaxonomyIdentifier("ab0e7f2e-6418-40e2-8870-6713123e41ad"),
                 Legislations = new Legislation[] { },
                 TenderingCriterionPropertyGroups = new[]
                 {
                     new TenderingCriterionPropertyGroup()
                     {
                         _cardinality = CardinalityMetadata.OneOrMore,
                         Id = new CriteriaTaxonomyIdentifier("4ddccd16-91e4-4b72-ae0f-78f2f1ab9490"),
                         PropertyGroupTypeCode = PropertyGroupTypeCode.OnAlways,
                         TenderingCriterionProperties = new[]
                         {
                           new TenderingCriterionProperty()
                           {
                             _cardinality = CardinalityMetadata.Optional,
                             Id = EuComGrowId.Random(),
                             TypeCode = CriterionElementType.Caption,
                             Description = "common.lotsTheRequirementAppliesTo.description",
                             ValueDataTypeCode = ResponseDataTypeCode.None
                           }
                         },
                         SubsidiaryTenderingCriterionPropertyGroups = new TenderingCriterionPropertyGroup[]
                         {
                             new TenderingCriterionPropertyGroup()
                             {
                                 _cardinality = CardinalityMetadata.Optional,
                                 Id = new CriteriaTaxonomyIdentifier("cc1da737-6c4e-4f4e-821d-c260029058f6"),
                                 PropertyGroupTypeCode = PropertyGroupTypeCode.OnAlways,
                                 TenderingCriterionProperties = new[]
                                 {
                                   new TenderingCriterionProperty()
                                   {
                                     _cardinality = CardinalityMetadata.Optional,
                                     Id = EuComGrowId.Random(),
                                     TypeCode = CriterionElementType.Requirement,
                                     Description = "common.lotID.description",
                                     ValueDataTypeCode = ResponseDataTypeCode.LotIdentifier
                                   }
                                 }
                             },
                             new TenderingCriterionPropertyGroup()
                             {
                                 _cardinality = CardinalityMetadata.ExactlyOne,
                                 Id = new CriteriaTaxonomyIdentifier("26ece6a2-b360-46c1-890d-8338913b8719"),
                                 PropertyGroupTypeCode = PropertyGroupTypeCode.OnAlways,
                                 TenderingCriterionProperties = new[]
                                 {
                                   new TenderingCriterionProperty()
                                   {
                                     _cardinality = CardinalityMetadata.ExactlyOne,
                                     Id = EuComGrowId.Random(),
                                     TypeCode = CriterionElementType.Requirement,
                                     Description = "otherEconomicOrFinancial.selectTheTypeOfRequirement.description",
                                     ValueDataTypeCode = ResponseDataTypeCode.CodeBoolean,
                                     CodeListId = CodeListIds.BooleanGUIControlType
                                   }
                                 },
                                 SubsidiaryTenderingCriterionPropertyGroups = new TenderingCriterionPropertyGroup[]
                                 {
                                     new TenderingCriterionPropertyGroup()
                                     {
                                         _cardinality = CardinalityMetadata.ZeroOrMore,
                                         Id = new CriteriaTaxonomyIdentifier("ca15c15f-110e-4a10-8d6e-5e41cf5f9098"),
                                         PropertyGroupTypeCode = PropertyGroupTypeCode.OnTrue,
                                         TenderingCriterionProperties = new[]
                                         {
                                           new TenderingCriterionProperty()
                                           {
                                             _cardinality = CardinalityMetadata.ExactlyOne,
                                             Id = EuComGrowId.Random(),
                                             TypeCode = CriterionElementType.Requirement,
                                             Description = "otherEconomicOrFinancial.descriptionOfTheEconomicfinancial.description",
                                             ValueDataTypeCode = ResponseDataTypeCode.Description
                                           },
                                           new TenderingCriterionProperty()
                                           {
                                             _cardinality = CardinalityMetadata.ExactlyOne,
                                             Id = EuComGrowId.Random(),
                                             TypeCode = CriterionElementType.Requirement,
                                             Description = "common.minimumAmount.description",
                                             ValueDataTypeCode = ResponseDataTypeCode.Amount
                                           },
                                           new TenderingCriterionProperty()
                                           {
                                             _cardinality = CardinalityMetadata.ExactlyOne,
                                             Id = EuComGrowId.Random(),
                                             TypeCode = CriterionElementType.Requirement,
                                             Description = "common.startDateEndDate.description",
                                             ValueDataTypeCode = ResponseDataTypeCode.Period
                                           }
                                         },
                                         SubsidiaryTenderingCriterionPropertyGroups = new TenderingCriterionPropertyGroup[]
                                         {
                                             new TenderingCriterionPropertyGroup()
                                             {
                                                 _cardinality = CardinalityMetadata.ExactlyOne,
                                                 Id = new CriteriaTaxonomyIdentifier("9b3a04ff-e36d-4d4f-b47c-82ad402b9b02"),
                                                 PropertyGroupTypeCode = PropertyGroupTypeCode.OnAlways,
                                                 TenderingCriterionProperties = new[]
                                                 {
                                                   new TenderingCriterionProperty()
                                                   {
                                                     _cardinality = CardinalityMetadata.ExactlyOne,
                                                     Id = EuComGrowId.Random(),
                                                     TypeCode = CriterionElementType.Question,
                                                     Description = "Amount",
                                                     ValueDataTypeCode = ResponseDataTypeCode.Amount
                                                   }
                                                 }

                                             }
                                         }

                                     },
                                     new TenderingCriterionPropertyGroup()
                                     {
                                         _cardinality = CardinalityMetadata.ZeroOrMore,
                                         Id = new CriteriaTaxonomyIdentifier("cc96aa19-a0be-4409-af58-ff3f3812741b"),
                                         PropertyGroupTypeCode = PropertyGroupTypeCode.OnFalse,
                                         TenderingCriterionProperties = new[]
                                         {
                                           new TenderingCriterionProperty()
                                           {
                                             _cardinality = CardinalityMetadata.ExactlyOne,
                                             Id = EuComGrowId.Random(),
                                             TypeCode = CriterionElementType.Requirement,
                                             Description = "otherEconomicOrFinancial.minimumRating.description",
                                             ValueDataTypeCode = ResponseDataTypeCode.Quantity
                                           },
                                           new TenderingCriterionProperty()
                                           {
                                             _cardinality = CardinalityMetadata.ExactlyOne,
                                             Id = EuComGrowId.Random(),
                                             TypeCode = CriterionElementType.Requirement,
                                             Description = "otherEconomicOrFinancial.ratingScheme.description",
                                             ValueDataTypeCode = ResponseDataTypeCode.Description
                                           },
                                         },
                                         SubsidiaryTenderingCriterionPropertyGroups = new TenderingCriterionPropertyGroup[]
                                         {
                                             new TenderingCriterionPropertyGroup()
                                             {
                                                 _cardinality = CardinalityMetadata.ExactlyOne,
                                                 Id = new CriteriaTaxonomyIdentifier("5fe93344-ed91-4f97-bcab-b6720a131798"),
                                                 PropertyGroupTypeCode = PropertyGroupTypeCode.OnAlways,
                                                 TenderingCriterionProperties = new[]
                                                 {
                                                   new TenderingCriterionProperty()
                                                   {
                                                     _cardinality = CardinalityMetadata.ExactlyOne,
                                                     Id = EuComGrowId.Random(),
                                                     TypeCode = CriterionElementType.Question,
                                                     Description = "otherEconomicOrFinancial.rating.description",
                                                     ValueDataTypeCode = ResponseDataTypeCode.Quantity
                                                   }
                                                 }

                                             }
                                         }
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
                                     Description = "common.lotID.description",
                                     ValueDataTypeCode = ResponseDataTypeCode.LotIdentifier
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
                                             Description = "common.evidenceSupplied",
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
        public TenderingCriterion[] References => new[]
        {
            new TenderingCriterion()
            {
                 CriterionTypeCode =
                   new CriterionTypeCode("CRITERION.SELECTION.TECHNICAL_PROFESSIONAL_ABILITY.REFERENCES.WORKS_PERFORMANCE"),
                 Name = "references.question1.name",
                 Description = new[] {"references.question1.description"},
                 Id = new CriteriaTaxonomyIdentifier("cdd3bb3e-34a5-43d5-b668-2aab86a73822"),
                 Legislations = new Legislation[] { },
                 TenderingCriterionPropertyGroups = CriterionHelper.References,
                 ApplicableContractType = ContractType.Works
            },
            new TenderingCriterion()
            {
                 CriterionTypeCode =
                   new CriterionTypeCode("CRITERION.SELECTION.TECHNICAL_PROFESSIONAL_ABILITY.REFERENCES.SUPPLIES_DELIVERY_PERFORMANCE"),
                 Name = "references.question2.name",
                 Description = new[] {"references.question2.description"},
                 Id = new CriteriaTaxonomyIdentifier("3a18a175-1863-4b1d-baef-588ce61960ca"),
                 Legislations = new Legislation[] { },
                 TenderingCriterionPropertyGroups = CriterionHelper.References,
                 ApplicableContractType = ContractType.Supplies
            },
            new TenderingCriterion()
            {
                 CriterionTypeCode =
                   new CriterionTypeCode("CRITERION.SELECTION.TECHNICAL_PROFESSIONAL_ABILITY.REFERENCES.SERVICES_DELIVERY_PERFORMANCE"),
                 Name = "references.question3.name",
                 Description = new[] {"references.question3.description"},
                 Id = new CriteriaTaxonomyIdentifier("5e506c16-26ab-4e32-bb78-b27f87dc0565"),
                 Legislations = new Legislation[] { },
                 TenderingCriterionPropertyGroups = CriterionHelper.References,
                 ApplicableContractType = ContractType.Services
            }
        };
        public TenderingCriterion[] AbilitiesPersons => new[]
       {
            new TenderingCriterion()
            {
                 CriterionTypeCode =
                   new CriterionTypeCode("CRITERION.SELECTION.TECHNICAL_PROFESSIONAL_ABILITY.TECHNICAL.TECHNICIANS_FOR_QUALITY_CONTROL"),
                 Name = "abilitiesPersons.question1.name",
                 Description = new[] {"abilitiesPersons.question1.description"},
                 Id = new CriteriaTaxonomyIdentifier("3aaca389-4a7b-406b-a4b9-080845d127e7"),
                 Legislations = new Legislation[] { },
                 TenderingCriterionPropertyGroups = CriterionHelper.AbilitiesPersons
            },
            new TenderingCriterion()
            {
                 CriterionTypeCode =
                   new CriterionTypeCode("CRITERION.SELECTION.TECHNICAL_PROFESSIONAL_ABILITY.TECHNICAL.TECHNICIANS_FOR_CARRYING_WORKS"),
                 Name = "abilitiesPersons.question2.name",
                 Description = new[] {"abilitiesPersons.question2.description"},
                 Id = new CriteriaTaxonomyIdentifier("c599c130-b29f-461e-a187-4e16c7d40db7"),
                 Legislations = new Legislation[] { },
                 TenderingCriterionPropertyGroups = CriterionHelper.AbilitiesPersons,
                 ApplicableContractType = ContractType.Works
            }
        };
        public TenderingCriterion[] AbilitiesFacilities => new[]
       {
            new TenderingCriterion()
            {
                 CriterionTypeCode =
                   new CriterionTypeCode("CRITERION.SELECTION.TECHNICAL_PROFESSIONAL_ABILITY.TECHNICAL.FACILITIES_FOR_QUALITY_ENSURING"),
                 Name = "abilitiesFacilities.question1.name",
                 Description = new[] {"abilitiesFacilities.question1.description"},
                 Id = new CriteriaTaxonomyIdentifier("4bf996d9-439c-40c6-9ab9-980a48cb55a1"),
                 Legislations = new Legislation[] { },
                 TenderingCriterionPropertyGroups = CriterionHelper.AbilitiesFacilities
            },
            new TenderingCriterion()
            {
                 CriterionTypeCode =
                   new CriterionTypeCode("CRITERION.SELECTION.TECHNICAL_PROFESSIONAL_ABILITY.TECHNICAL.FACILITIES_FOR_STUDY_RESEARCH"),
                 Name = "abilitiesFacilities.question2.name",
                 Description = new[] {"abilitiesFacilities.question2.description"},
                 Id = new CriteriaTaxonomyIdentifier("90a2e100-44cc-45d3-9970-69d6714f1596"),
                 Legislations = new Legislation[] { },
                 TenderingCriterionPropertyGroups = CriterionHelper.AbilitiesFacilities
            },
            new TenderingCriterion()
            {
                 CriterionTypeCode =
                   new CriterionTypeCode("CRITERION.SELECTION.TECHNICAL_PROFESSIONAL_ABILITY.TECHNICAL.SUPPLY_CHAIN_MANAGEMENT"),
                 Name = "abilitiesFacilities.question3.name",
                 Description = new[] {"abilitiesFacilities.question3.description"},
                 Id = new CriteriaTaxonomyIdentifier("dc12a151-7fdf-4733-a8f0-30f667292e66"),
                 Legislations = new Legislation[] { },
                 TenderingCriterionPropertyGroups = CriterionHelper.AbilitiesFacilities
            },
            new TenderingCriterion()
            {
                 CriterionTypeCode =
                   new CriterionTypeCode("CRITERION.SELECTION.TECHNICAL_PROFESSIONAL_ABILITY.TECHNICAL.ENVIRONMENTAL_MANAGEMENT_MEASURES"),
                 Name = "abilitiesFacilities.question4.name",
                 Description = new[] {"abilitiesFacilities.question4.description"},
                 Id = new CriteriaTaxonomyIdentifier("9460457e-b43d-48a9-acd1-615de6ddd33e"),
                 Legislations = new Legislation[] { },
                 TenderingCriterionPropertyGroups = CriterionHelper.AbilitiesFacilities
            },
            new TenderingCriterion()
            {
                 CriterionTypeCode =
                   new CriterionTypeCode("CRITERION.SELECTION.TECHNICAL_PROFESSIONAL_ABILITY.TECHNICAL.EQUIPMENT"),
                 Name = "abilitiesFacilities.question5.name",
                 Description = new[] {"abilitiesFacilities.question5.description"},
                 Id = new CriteriaTaxonomyIdentifier("cc18c023-211d-484d-a32e-52f3f970285f"),
                 Legislations = new Legislation[] { },
                 TenderingCriterionPropertyGroups = CriterionHelper.AbilitiesFacilities
            }
        };
        public TenderingCriterion[] AbilitiesEducation => new[]
        {
            new TenderingCriterion()
            {
                 CriterionTypeCode =
                   new CriterionTypeCode("CRITERION.SELECTION.TECHNICAL_PROFESSIONAL_ABILITY.TECHNICAL.PROFESSIONAL_QUALIFICATIONS"),
                 Name = "abilitiesEducation.question.name",
                 Description = new[] {"abilitiesEducation.question.description"},
                 Id = new CriteriaTaxonomyIdentifier("07301031-2270-41af-8e7e-66fe0c777107"),
                 Legislations = new Legislation[] { },
                 TenderingCriterionPropertyGroups = new TenderingCriterionPropertyGroup[]
                 {
                     new TenderingCriterionPropertyGroup()
                     {
                         _cardinality = CardinalityMetadata.ExactlyOne,
                         Id = new CriteriaTaxonomyIdentifier("d2cadc29-07e0-46b2-a74a-a0dc4bd2e5c2"),
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
                                 Id = new CriteriaTaxonomyIdentifier("1be6421a-0360-449e-ae7c-ce7fad73c2c2"),
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
                                         _cardinality = CardinalityMetadata.Optional,
                                         Id = new CriteriaTaxonomyIdentifier("5df40500-a9b7-4c15-8325-a9762224a3c9"),
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
                                                 Id = new CriteriaTaxonomyIdentifier("5476ec64-de1e-45d2-aaf1-a40a463ab7a9"),
                                                 PropertyGroupTypeCode = PropertyGroupTypeCode.OnAlways,
                                                 TenderingCriterionProperties = new[]
                                                 {
                                                    new TenderingCriterionProperty()
                                                    {
                                                      _cardinality = CardinalityMetadata.Optional,
                                                      Id = EuComGrowId.Random(),
                                                      Description = "common.firstName.description",
                                                      TypeCode = CriterionElementType.Question,
                                                      ValueDataTypeCode = ResponseDataTypeCode.Description
                                                    },
                                                    new TenderingCriterionProperty()
                                                    {
                                                      _cardinality = CardinalityMetadata.Optional,
                                                      Id = EuComGrowId.Random(),
                                                      Description = "common.lastName.description",
                                                      TypeCode = CriterionElementType.Question,
                                                      ValueDataTypeCode = ResponseDataTypeCode.Description
                                                    },
                                                    new TenderingCriterionProperty()
                                                    {
                                                      _cardinality = CardinalityMetadata.ExactlyOne,
                                                      Id = EuComGrowId.Random(),
                                                      Description = "abilitiesEducation.pleaseDescribeTheEducationalOrProfessionalQualification.description",
                                                      TypeCode = CriterionElementType.Question,
                                                      ValueDataTypeCode = ResponseDataTypeCode.Description
                                                    },
                                                    new TenderingCriterionProperty()
                                                    {
                                                      _cardinality = CardinalityMetadata.Optional,
                                                      Id = EuComGrowId.Random(),
                                                      Description = "abilitiesEducation.ifPossiblePleaseIndicateTheESCOIdentifier.description",
                                                      TypeCode = CriterionElementType.Question,
                                                      ValueDataTypeCode = ResponseDataTypeCode.Url
                                                    },
                                                    new TenderingCriterionProperty()
                                                    {
                                                      _cardinality = CardinalityMetadata.Optional,
                                                      Id = EuComGrowId.Random(),
                                                      Description = "abilitiesEducation.ifPpossiblePleaseDescribeTheESCOQualification.description",
                                                      TypeCode = CriterionElementType.Question,
                                                      ValueDataTypeCode = ResponseDataTypeCode.Description
                                                    },
                                                    new TenderingCriterionProperty()
                                                    {
                                                      _cardinality = CardinalityMetadata.Optional,
                                                      Id = EuComGrowId.Random(),
                                                      Description = "abilitiesEducation.qualificationName.description",
                                                      TypeCode = CriterionElementType.Question,
                                                      ValueDataTypeCode = ResponseDataTypeCode.Description
                                                    },
                                                    new TenderingCriterionProperty()
                                                    {
                                                      _cardinality = CardinalityMetadata.Optional,
                                                      Id = EuComGrowId.Random(),
                                                      Description = "abilitiesEducation.qualificationNumber.description",
                                                      TypeCode = CriterionElementType.Question,
                                                      ValueDataTypeCode = ResponseDataTypeCode.Identifier
                                                    },
                                                    new TenderingCriterionProperty()
                                                    {
                                                      _cardinality = CardinalityMetadata.Optional,
                                                      Id = EuComGrowId.Random(),
                                                      Description = "abilitiesEducation.qualificationIssuingDate.description",
                                                      TypeCode = CriterionElementType.Question,
                                                      ValueDataTypeCode = ResponseDataTypeCode.Date
                                                    },
                                                    new TenderingCriterionProperty()
                                                    {
                                                      _cardinality = CardinalityMetadata.Optional,
                                                      Id = EuComGrowId.Random(),
                                                      Description = "abilitiesEducation.qualificationIssuingBody.description",
                                                      TypeCode = CriterionElementType.Question,
                                                      ValueDataTypeCode = ResponseDataTypeCode.Description
                                                    }
                                                 },
                                                 SubsidiaryTenderingCriterionPropertyGroups = new TenderingCriterionPropertyGroup[]
                                                 {
                                                     new TenderingCriterionPropertyGroup()
                                                     {
                                                         _cardinality = CardinalityMetadata.ExactlyOne,
                                                         Id = new CriteriaTaxonomyIdentifier("9026e403-3eb6-4705-a9e9-e21a1efc867d"),
                                                         PropertyGroupTypeCode = PropertyGroupTypeCode.OnAlways,
                                                         TenderingCriterionProperties = new[]
                                                         {
                                                            new TenderingCriterionProperty()
                                                            {
                                                              _cardinality = CardinalityMetadata.ExactlyOne,
                                                              Id = EuComGrowId.Random(),
                                                              Description = "common.isThisInformationAvailableOnline.description",
                                                              TypeCode = CriterionElementType.Question,
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
                                                                     _cardinality = CardinalityMetadata.OneOrMore,
                                                                     Id = EuComGrowId.Random(),
                                                                     Description = "common.evidenceSupplied.description",
                                                                     TypeCode = CriterionElementType.Question,
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
                         }
                     }
                 }
            }
        };
        public TenderingCriterion[] AbilitiesChecks => new[]
        {
            new TenderingCriterion()
            {
                 CriterionTypeCode =
                   new CriterionTypeCode("CRITERION.SELECTION.TECHNICAL_PROFESSIONAL_ABILITY.TECHNICAL.CHECKS.ALLOWANCE_OF_CHECKS"),
                 Name = "abilitiesChecks.question.name",
                 Description = new[] {"abilitiesChecks.question.description"},
                 Id = new CriteriaTaxonomyIdentifier("c8809aa1-29b6-4f27-ae2f-27e612e394db"),
                 Legislations = new Legislation[] { },
                 TenderingCriterionPropertyGroups = new TenderingCriterionPropertyGroup[]
                 {
                     new TenderingCriterionPropertyGroup()
                     {
                         _cardinality = CardinalityMetadata.OneOrMore,
                         Id = new CriteriaTaxonomyIdentifier("10822ddd-9ba6-42d5-9339-de0845aeafc9"),
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
                                 Id = new CriteriaTaxonomyIdentifier("a3410620-8ed3-47f9-ab90-b5b1aeeff6a5"),
                                 PropertyGroupTypeCode = PropertyGroupTypeCode.OnAlways,
                                 TenderingCriterionProperties = new[]
                                 {
                                   new TenderingCriterionProperty()
                                   {
                                     _cardinality = CardinalityMetadata.ExactlyOne,
                                     Id = EuComGrowId.Random(),
                                     TypeCode = CriterionElementType.Question,
                                     Description = "abilitiesChecks.doYouAllowChecks.description",
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
                             }
                         }

                     }
                 }
            }
        };
        public TenderingCriterion[] AbilitiesStaff => new[]
        {
            new TenderingCriterion()
            {
                 CriterionTypeCode =
                   new CriterionTypeCode("CRITERION.SELECTION.TECHNICAL_PROFESSIONAL_ABILITY.MANAGEMENT.MANAGERIAL_STAFF"),
                 Name = "abilitiesStaff.question1.name",
                 Description = new[] {"abilitiesStaff.question1.description"},
                 Id = new CriteriaTaxonomyIdentifier("6346959b-e097-4ea1-89cd-d1b4c131ea4d"),
                 Legislations = new Legislation[] { },
                 TenderingCriterionPropertyGroups = CriterionHelper.AbilitiesStaff
            },
            new TenderingCriterion()
            {
                 CriterionTypeCode =
                   new CriterionTypeCode("CRITERION.SELECTION.TECHNICAL_PROFESSIONAL_ABILITY.MANAGEMENT.AVERAGE_ANNUAL_MANPOWER"),
                 Name = "abilitiesStaff.question2.name",
                 Description = new[] {"abilitiesStaff.question2.description"},
                 Id = new CriteriaTaxonomyIdentifier("1f49b3f0-d50f-43f6-8b30-4bafab108b9b"),
                 Legislations = new Legislation[] { },
                 TenderingCriterionPropertyGroups = CriterionHelper.AbilitiesStaff
            }
        };
        public TenderingCriterion[] SubcontractingProportion => new[]
        {
            new TenderingCriterion()
            {
                 CriterionTypeCode =
                   new CriterionTypeCode("CRITERION.SELECTION.TECHNICAL_PROFESSIONAL_ABILITY.MANAGEMENT.SUBCONTRACTING_PROPORTION"),
                 Name = "subcontractingProportion.question.name",
                 Description = new[] {"subcontractingProportion.question.description"},
                 Id = new CriteriaTaxonomyIdentifier("612a1625-118d-4ea4-a6db-413184e7c0a8"),
                 Legislations = new Legislation[] { },
                 TenderingCriterionPropertyGroups = new TenderingCriterionPropertyGroup[]{

                     new TenderingCriterionPropertyGroup()
                    {
                        _cardinality = CardinalityMetadata.ExactlyOne,
                        Id = new CriteriaTaxonomyIdentifier("575f7550-8a2d-4bad-b9d8-be07ab570076"),
                        PropertyGroupTypeCode = PropertyGroupTypeCode.OnAlways,
                        TenderingCriterionProperties = new[]
                        {
                          new TenderingCriterionProperty()
                          {
                            _cardinality = CardinalityMetadata.ExactlyOne,
                            Id = EuComGrowId.Random(),
                            TypeCode = CriterionElementType.Question,
                            Description = "common.pleaseSpecify.description",
                            ValueDataTypeCode = ResponseDataTypeCode.Description
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
                 }
            }
        };
        public TenderingCriterion[] SamplesCertificates => new[]
        {
            new TenderingCriterion()
            {
                 CriterionTypeCode =
                   new CriterionTypeCode("CRITERION.SELECTION.TECHNICAL_PROFESSIONAL_ABILITY.MANAGEMENT.ARTEFACTS.NO_AUTHENTICATED_ARTEFACTS"),
                 Name = "samplesCertificates.question1.name",
                 Description = new[] {"samplesCertificates.question1.description"},
                 Id = new CriteriaTaxonomyIdentifier("bdf0601d-2480-4250-b870-658d0ee95be6"),
                 Legislations = new Legislation[] { },
                 TenderingCriterionPropertyGroups = CriterionHelper.SamplesCertificates,
                 ApplicableContractType = ContractType.Supplies
            },
            new TenderingCriterion()
            {
                 CriterionTypeCode =
                   new CriterionTypeCode("CRITERION.SELECTION.TECHNICAL_PROFESSIONAL_ABILITY.MANAGEMENT.ARTEFACTS.AUTHENTICATED_ARTEFACTS"),
                 Name = "samplesCertificates.question2.name",
                 Description = new[] {"samplesCertificates.question2.description"},
                 Id = new CriteriaTaxonomyIdentifier("7662b7a9-bcb8-4763-a0a7-7505d8e8470d"),
                 Legislations = new Legislation[] { },
                 TenderingCriterionPropertyGroups = CriterionHelper.SamplesCertificates,
                 ApplicableContractType = ContractType.Supplies
            }

        };
        public TenderingCriterion[] QualityAssurance => new[]
        {
            new TenderingCriterion()
            {
                 CriterionTypeCode =
                   new CriterionTypeCode("CRITERION.SELECTION.TECHNICAL_PROFESSIONAL_ABILITY.CERTIFICATES.QUALITY_ASSURANCE.QA_INSTITUTES_CERTIFICATE"),
                 Name = "qualityAssurance.question1.name",
                 Description = new[] {"qualityAssurance.question1.description"},
                 Id = new CriteriaTaxonomyIdentifier("a7669d7d-9297-43e1-9d10-691a1660187c"),
                 Legislations = new Legislation[] { },
                 TenderingCriterionPropertyGroups = CriterionHelper.QualityAssurance,
                 ApplicableContractType = ContractType.Supplies
            },
            new TenderingCriterion()
            {
                 CriterionTypeCode =
                   new CriterionTypeCode("CRITERION.SELECTION.TECHNICAL_PROFESSIONAL_ABILITY.CERTIFICATES.QUALITY_ASSURANCE.QA_INDEPENDENT_CERTIFICATE"),
                 Name = "qualityAssurance.question2.name",
                 Description = new[] {"qualityAssurance.question2.description"},
                 Id = new CriteriaTaxonomyIdentifier("d726bac9-e153-4e75-bfca-c5385587766d"),
                 Legislations = new Legislation[] { },
                 TenderingCriterionPropertyGroups = CriterionHelper.QualityAssurance
            },
            new TenderingCriterion()
            {
                 CriterionTypeCode =
                   new CriterionTypeCode("CRITERION.SELECTION.TECHNICAL_PROFESSIONAL_ABILITY.CERTIFICATES.ENVIRONMENTAL_MANAGEMENT.ENV_INDEPENDENT_CERTIFICATE"),
                 Name = "qualityAssurance.question3.name",
                 Description = new[] {"qualityAssurance.question3.description"},
                 Id = new CriteriaTaxonomyIdentifier("8ed65e48-fd0d-444f-97bd-4f58da632999"),
                 Legislations = new Legislation[] { },
                 TenderingCriterionPropertyGroups = CriterionHelper.QualityAssurance
            }
        };

    };
}