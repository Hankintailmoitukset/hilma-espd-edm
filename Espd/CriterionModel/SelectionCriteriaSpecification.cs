﻿using System.Collections;
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
      Suitability,
      GeneralTurnover,
      SpecificTurnover,
      AverageTurnover
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
        Id = new CriteriaTaxonomyIdentifier("63adb07d-db1b-4ef0-a14e-a99785cf8cf6"),
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

  }
}