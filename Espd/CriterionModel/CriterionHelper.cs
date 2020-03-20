using Hilma.UBL.CommonAggregateComponents;
using Hilma.UBL.UnqualifiedDataTypes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Espd.CriterionModel
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
                               PropertyGroupTypeCode="NONE",
                               Description = new TextType[]{"[Additional information; e.g. no evidences online]" },
                           },
                           new TenderingCriterionPropertyGroup(){
                               PropertyGroupTypeCode="INDICATOR",
                               Description = new TextType[]{"Your Answer" }
                           }

                       }
                   }
               };


    };
}



