using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using Hilma.Espd.EDM.CriterionModel.Identifiers;
using Hilma.UBL.CommonAggregateComponents;

namespace Hilma.Espd.EDM.CriterionModel
{
    public class SelectionCriteriaSpecification : IEnumerable<TenderingCriterion>
    {
        public IEnumerable<TenderingCriterion> AllCriteria => new[]
        {
            Suitability
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
      new TenderingCriterion()
      {
        CriterionTypeCode = new CriterionTypeCode("CRITERION.SELECTION.SUITABILITY.PROFESSIONAL_REGISTER_ENROLMENT"),
        Name = "suitability.enrolmentInRelevantProfessionalRegister.name",
        Description = new[] {"suitability.enrolmentInRelevantProfessionalRegister.description"},
        Id = new CriteriaTaxonomyIdentifier("6ee55a59-6adb-4c3a-b89f-e62a7ad7be7f"),
        Legislations = new Legislation[] { },
        TenderingCriterionPropertyGroups =  CriterionHelper.SuitabilityRegisterQuestionsGroups
      },
      new TenderingCriterion()
      {
        CriterionTypeCode = new CriterionTypeCode("CRITERION.SELECTION.SUITABILITY.TRADE_REGISTER_ENROLMENT"),
        Name = "suitability.tradeRegisterEnrolment.name",
        Description = new[] {"suitability.tradeRegisterEnrolment.description"},
        Id = new CriteriaTaxonomyIdentifier("87b3fa26-3549-4f92-b8e0-3fd8f04bf5c7"),
        Legislations = new Legislation[] { },
        TenderingCriterionPropertyGroups = CriterionHelper.SuitabilityRegisterQuestionsGroups
      },
      new TenderingCriterion()
      {
        CriterionTypeCode = new CriterionTypeCode("CRITERION.SELECTION.SUITABILITY.AUTHORISATION"),
        Name = "suitability.authorisationForParticularOrganisationNeeded.name",
        Description = new[] {"suitability.authorisationForParticularOrganisationNeeded.description"},
        Id = new CriteriaTaxonomyIdentifier("9eeb6d5c-0eb8-48e8-a4c5-5087a7c095a4"),
        Legislations = new Legislation[] { },
        TenderingCriterionPropertyGroups = CriterionHelper.SuitabilityRegisterQuestionsGroups
      },
      new TenderingCriterion()
      {
        CriterionTypeCode = new CriterionTypeCode("CRITERION.SELECTION.SUITABILITY.MEMBERSHIP"),
        Name = "suitability.authorisationForParticularOrganisationNeeded.name",
        Description = new[] {"suitability.authorisationForParticularOrganisationNeeded.description"},
        Id = new CriteriaTaxonomyIdentifier("73f10e36-ed7a-412e-995c-aa76463e3776"),
        Legislations = new Legislation[] { },
        TenderingCriterionPropertyGroups = CriterionHelper.SuitabilityRegisterQuestionsGroups
      },

    };

        public TenderingCriterion[] GeneralTurnover => new[]
            {
       new TenderingCriterion()
       {
         CriterionTypeCode = new CriterionTypeCode("CRITERION.SELECTION.ECONOMIC_FINANCIAL_STANDING.TURNOVER.GENERAL_YEARLY"),
         Name = "economicFinancialStanding.generalTurnoverYearly.name",
         Description = new[] { "economicFinancialStanding.generalTurnoverYearly.description" },
         Id = new CriteriaTaxonomyIdentifier("499efc97-2ac1-4af2-9e84-323c2ca67747"),
         Legislations = new Legislation[] { },
         TenderingCriterionPropertyGroups = new []
         {
           new TenderingCriterionPropertyGroup()
           {
             Id = new CriteriaTaxonomyIdentifier("5ca58d66-3ef1-4145-957c-45d5b18a837f"),
             PropertyGroupTypeCode = new PropertyGroupTypeCode("ON*"),
             TenderingCriterionProperties = new []
             {
               new TenderingCriterionProperty()
               {
                 TypeCode = new CriterionElementType("REQUIREMENT"),
                 Description = "economicFinancialStanding.minimumRequirement.description",
                 ValueDataTypeCode = new ResponseDataTypeCode("AMOUNT")
               },
             },
             SubsidiaryTenderingCriterionPropertyGroups = new []
             {
               new TenderingCriterionPropertyGroup()
               {
                 Id = new CriteriaTaxonomyIdentifier("c0cd9c1c-e90a-4ff9-bce3-ac0fe31abf16"),
                 PropertyGroupTypeCode = new PropertyGroupTypeCode("ON*"),
                 TenderingCriterionProperties = new []
                 {
                   new TenderingCriterionProperty()
                   {
                     TypeCode = new CriterionElementType("QUESTION"),
                     Description = "common.amount.description",
                     ValueDataTypeCode = new ResponseDataTypeCode("AMOUNT"),
                   },
                   new TenderingCriterionProperty()
                   {
                     TypeCode = new CriterionElementType("QUESTION"),
                     Description = "common.startDate.description",
                     ValueDataTypeCode = new ResponseDataTypeCode("DATE"),
                   },
                   new TenderingCriterionProperty()
                   {
                     TypeCode = new CriterionElementType("QUESTION"),
                     Description = "common.endDate.description",
                     ValueDataTypeCode = new ResponseDataTypeCode("DATE")
                   },
                 }
               },


             }
           }
         }
       },
     };
        public TenderingCriterion[] AverageTurnover => new[]
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
             Id = new CriteriaTaxonomyIdentifier("5ca58d66-3ef1-4145-957c-45d5b18a837f"),
             PropertyGroupTypeCode = new PropertyGroupTypeCode("ON*"),
             TenderingCriterionProperties = new[]
             {
               new TenderingCriterionProperty()
               {
                 TypeCode = new CriterionElementType("REQUIREMENT"),
                 Description = "common.startDateEndDate.description",
                 ValueDataTypeCode = new ResponseDataTypeCode("PERIOD"),
               },
               new TenderingCriterionProperty()
               {
                 TypeCode = new CriterionElementType("REQUIREMENT"),
                 Description = "economicFinancialStanding.minimumRequirement.description",
                 ValueDataTypeCode = new ResponseDataTypeCode("AMOUNT")
               },

             },
             SubsidiaryTenderingCriterionPropertyGroups = new[]
             {
               new TenderingCriterionPropertyGroup()
               {
                 Id = new CriteriaTaxonomyIdentifier("e1886054-ada4-473c-9afc-2fde82c24cf4"),
                 PropertyGroupTypeCode = new PropertyGroupTypeCode("ON*"),
                 TenderingCriterionProperties = new[]
                 {
                   new TenderingCriterionProperty()
                   {
                     TypeCode = new CriterionElementType("QUESTION"),
                     Description = "economicFinancialStanding.averageForRequiredPeriod.description",
                     ValueDataTypeCode = new ResponseDataTypeCode("AMOUNT"),
                   },
                   new TenderingCriterionProperty()
                   {
                     TypeCode = new CriterionElementType("QUESTION"),
                     Description = "economicFinancialStanding.cpvCode.description",
                     ValueDataTypeCode = new ResponseDataTypeCode("DESCRIPTION"),
                   }
                 }
               }
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
            Name = "Specific average turnover",
            Description = new[] {"Its specific average yearly turnover in the business area covered by the contract for the number of years required in the relevant notice, the in the ESPD, the relevant notice or  or the ESPD is as follows:"},
            Id = new CriteriaTaxonomyIdentifier("d3dfb714-f558-4512-bbc5-e456fa2339de"),
            Legislations = new Legislation[] { },
            TenderingCriterionPropertyGroups = new[]
            {
                new TenderingCriterionPropertyGroup()
                {
                    _cardinality = CardinalityMetadata.ExactlyOne,
                    Id = new CriteriaTaxonomyIdentifier("6cff132b-8d15-4f79-ae37-2f9295432381"),
                    PropertyGroupTypeCode = new PropertyGroupTypeCode("ON*"),
                    TenderingCriterionProperties = new[]
                    {
                        new TenderingCriterionProperty()
                        {
                            _cardinality = CardinalityMetadata.ExactlyOne,
                          TypeCode = new CriterionElementType("REQUIREMENT"),
                          Description = "Number of fiscal years",
                          ValueDataTypeCode = new ResponseDataTypeCode("QUANTITY_INTEGER"),
                        },
                        new TenderingCriterionProperty()
                        {
                            _cardinality = CardinalityMetadata.OneOrMore,
                          TypeCode = new CriterionElementType("REQUIREMENT"),
                          Description = "Business domain description",
                          ValueDataTypeCode = new ResponseDataTypeCode("DESCRIPTION"),
                        },
                        new TenderingCriterionProperty()
                        {
                            _cardinality = CardinalityMetadata.ExactlyOne,
                          TypeCode = new CriterionElementType("REQUIREMENT"),
                          Description = "Minimum requirement",
                          ValueDataTypeCode = new ResponseDataTypeCode("AMOUNT"),
                        },
                    },
                    SubsidiaryTenderingCriterionPropertyGroups = new TenderingCriterionPropertyGroup[]
                    {
                       new TenderingCriterionPropertyGroup()
                       {
                         _cardinality = CardinalityMetadata.ExactlyOne,
                         Id = new CriteriaTaxonomyIdentifier("6d87673d-af3f-4c39-b0e4-fbef046bd435"),
                         PropertyGroupTypeCode = new PropertyGroupTypeCode("ON*"),
                         TenderingCriterionProperties = new[]
                         {
                           new TenderingCriterionProperty()
                           {
                             TypeCode = new CriterionElementType("CAPTION"),
                             Description = "CPVs:",
                             ValueDataTypeCode = new ResponseDataTypeCode("NONE")
                           },
                           new TenderingCriterionProperty()
                           {
                             _cardinality = CardinalityMetadata.OneOrMore,
                             TypeCode = new CriterionElementType("REQUIREMENT"),
                             Description = "CPV Code",
                             ValueDataTypeCode = new ResponseDataTypeCode("CODE")
                           }
                         }
                        },
                       new TenderingCriterionPropertyGroup()
                       {
                           _cardinality = CardinalityMetadata.ExactlyOne,
                           Id = new CriteriaTaxonomyIdentifier("c0cd9c1c-e90a-4ff9-bce3-ac0fe31abf16"),
                           PropertyGroupTypeCode = new PropertyGroupTypeCode("ON*"),
                           TenderingCriterionProperties = new[]
                           {
                               new TenderingCriterionProperty()
                               {
                                 _cardinality = CardinalityMetadata.ExactlyOne,
                                 TypeCode = new CriterionElementType("QUESTION"),
                                 Description = "Start date; End date",
                                 ValueDataTypeCode = new ResponseDataTypeCode("PERIOD")
                               },
                               new TenderingCriterionProperty()
                               {
                                 _cardinality = CardinalityMetadata.ExactlyOne,
                                 TypeCode = new CriterionElementType("QUESTION"),
                                 Description = "Amount",
                                 ValueDataTypeCode = new ResponseDataTypeCode("AMOUNT")
                               }
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
                                 Description = "Is this information available electronically?",
                                 ValueDataTypeCode = new ResponseDataTypeCode("INDICATOR")
                               }
                           },
                           SubsidiaryTenderingCriterionPropertyGroups = new TenderingCriterionPropertyGroup[]
                           {
                               new TenderingCriterionPropertyGroup()
                               {
                                   _cardinality = CardinalityMetadata.ZeroOrMore,
                                   Id = new CriteriaTaxonomyIdentifier("41dd2e9b-1bfd-44c7-93ee-56bd74a4334b"),
                                   PropertyGroupTypeCode = new PropertyGroupTypeCode("ON*"),
                                   TenderingCriterionProperties = new[]
                                   {
                                       new TenderingCriterionProperty()
                                       {
                                         _cardinality = CardinalityMetadata.OneOrMore,
                                         TypeCode = new CriterionElementType("QUESTION"),
                                         Description = "Evidence Supplied",
                                         ValueDataTypeCode = new ResponseDataTypeCode("EVIDENCE_IDENTIFIER")
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

        public TenderingCriterion[] SpecificTurnover => new[]
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
             Id = new CriteriaTaxonomyIdentifier("5ca58d66-3ef1-4145-957c-45d5b18a837f"),
             PropertyGroupTypeCode = new PropertyGroupTypeCode("ON*"),
             TenderingCriterionProperties = new[]
             {
               new TenderingCriterionProperty()
               {
                 TypeCode = new CriterionElementType("REQUIREMENT"),
                 Description = "economicFinancialStanding.numberOfFiscalYears.description",
                 ValueDataTypeCode = new ResponseDataTypeCode("AMOUNT")
               }

             },
             SubsidiaryTenderingCriterionPropertyGroups = new[]
             {
               new TenderingCriterionPropertyGroup()
               {
                 Id = new CriteriaTaxonomyIdentifier("6d87673d-af3f-4c39-b0e4-fbef046bd435"),
                 PropertyGroupTypeCode = new PropertyGroupTypeCode("ON*"),
                 TenderingCriterionProperties = new[]
                 {
                   new TenderingCriterionProperty()
                   {
                     TypeCode = new CriterionElementType("CAPTION"),
                     Description = "economicFinancialStanding.cpvsCaption.description",
                     ValueDataTypeCode = new ResponseDataTypeCode("NONE"),
                   },
                   new TenderingCriterionProperty()
                   {
                     TypeCode = new CriterionElementType("REQUIREMENT"),
                     Description = "economicFinancialStanding.cpvCode.description",
                     ValueDataTypeCode = new ResponseDataTypeCode("CODE"),
                   },
                   new TenderingCriterionProperty()
                   {
                     TypeCode = new CriterionElementType("REQUIREMENT"),
                     Description = "economicFinancialStanding.businessDomainDescription.description",
                     ValueDataTypeCode = new ResponseDataTypeCode("CODE"),
                   },
                   new TenderingCriterionProperty()
                   {
                     TypeCode = new CriterionElementType("QUESTION"),
                     Description = "common.minimumRequirement.description",
                     ValueDataTypeCode = new ResponseDataTypeCode("AMOUNT")
                   },
                 }
               },
               new TenderingCriterionPropertyGroup()
               {
                 Id = new CriteriaTaxonomyIdentifier("c0cd9c1c-e90a-4ff9-bce3-ac0fe31abf16"),
                 PropertyGroupTypeCode = new PropertyGroupTypeCode("ON*"),
                 TenderingCriterionProperties = new[]
                 {

                   new TenderingCriterionProperty()
                   {
                     TypeCode = new CriterionElementType("QUESTION"),
                     Description = "common.startDateEndDate.description",
                     ValueDataTypeCode = new ResponseDataTypeCode("PERIOD"),
                   },
                   new TenderingCriterionProperty()
                   {
                     TypeCode = new CriterionElementType("QUESTION"),
                     Description = "common.amount.description",
                     ValueDataTypeCode = new ResponseDataTypeCode("AMOUNT"),
                   }
                 }
               }


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
                   new CriterionTypeCode("CRITERION.SELECTION.ECONOMIC_FINANCIAL_STANDING.TURNOVER.SPECIFIC_YEARLY"),
                 Name = "Set up of economic operator",
                 Description = new[] {"In case the information concerning turnover (general or specific) is not available for the entire period required, please state the date on which the economic operator was set up or started trading:"},
                 Id = new CriteriaTaxonomyIdentifier("77f481ce-ffb6-483f-8e2b-c78db5e68292"),
                 Legislations = new Legislation[] { },
                 TenderingCriterionPropertyGroups = new[]
                 {
                    new TenderingCriterionPropertyGroup()
                    {
                        _cardinality = CardinalityMetadata.ExactlyOne,
                        Id = new CriteriaTaxonomyIdentifier("e9aa7763-c167-4352-8060-1a3d7d3e2662"),
                        PropertyGroupTypeCode = new PropertyGroupTypeCode("ON*"),
                        TenderingCriterionProperties = new[]
                        {
                          new TenderingCriterionProperty()
                          {
                            _cardinality = CardinalityMetadata.ExactlyOne,
                            TypeCode = new CriterionElementType("QUESTION"),
                            Description = "Please specify",
                            ValueDataTypeCode = new ResponseDataTypeCode("DATE")
                          }
                        },
                        SubsidiaryTenderingCriterionPropertyGroups = new TenderingCriterionPropertyGroup[]
                        {
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
                                    Description = "Is this information available electronically?",
                                    ValueDataTypeCode = new ResponseDataTypeCode("INDICATOR")
                                  }
                                },
                                SubsidiaryTenderingCriterionPropertyGroups = new TenderingCriterionPropertyGroup[]
                                {
                                    new TenderingCriterionPropertyGroup()
                                    {
                                        _cardinality = CardinalityMetadata.ZeroOrMore,
                                        Id = new CriteriaTaxonomyIdentifier("41dd2e9b-1bfd-44c7-93ee-56bd74a4334b"),
                                        PropertyGroupTypeCode = new PropertyGroupTypeCode("ONTRUE"),
                                        TenderingCriterionProperties = new[]
                                        {
                                          new TenderingCriterionProperty()
                                          {
                                            _cardinality = CardinalityMetadata.OneOrMore,
                                            TypeCode = new CriterionElementType("QUESTION"),
                                            Description = "Evidence Supplied",
                                            ValueDataTypeCode = new ResponseDataTypeCode("EVIDENCE_IDENTIFIER")
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
        public TenderingCriterion[] Financial_ratios => new[]
        {
            new TenderingCriterion()
            {
                CriterionTypeCode =
                   new CriterionTypeCode("CRITERION.SELECTION.ECONOMIC_FINANCIAL_STANDING.FINANCIAL_RATIO"),
                 Name = "Financial ratio",
                 Description = new[] {"Concerning the financial ratios  specified in the relevant notice, the in the ESPD, the relevant notice or  or the ESPD, the economic operator declares that the actual values for the required ratios are as follows:"},
                 Id = new CriteriaTaxonomyIdentifier("e4d37adc-08cd-4f4d-a8d8-32b62b0a1f46"),
                 Legislations = new Legislation[] { },
                 TenderingCriterionPropertyGroups = new[]
                 {
                    new TenderingCriterionPropertyGroup()
                    {
                        _cardinality = CardinalityMetadata.ExactlyOne,
                        Id = new CriteriaTaxonomyIdentifier("e9aa7763-c167-4352-8060-1a3d7d3e2662"),
                        PropertyGroupTypeCode = new PropertyGroupTypeCode("ON*"),
                        TenderingCriterionProperties = new[]
                        {
                          new TenderingCriterionProperty()
                          {
                            _cardinality = CardinalityMetadata.ExactlyOne,
                            TypeCode = new CriterionElementType("QUESTION"),
                            Description = "Please specify",
                            ValueDataTypeCode = new ResponseDataTypeCode("DATE")
                          }
                        }, 
                    } 
                 }
            }
        };
        public TenderingCriterion[] ProfessionalRiskInsuranse => new[]
{
            new TenderingCriterion()
            {

            }
        };
        public TenderingCriterion[] OtherEconomicOrFinancial => new[]
        {
            new TenderingCriterion()
            {

            }
        };

       
};
}