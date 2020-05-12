using Hilma.Espd.EDM.CriterionModels.v2_1_0.Identifiers;
using Hilma.UBL.CommonAggregateComponents;

namespace Hilma.Espd.EDM.Utilities
{
  public class LegislationFactory
  {
      /// <summary>
      /// Directive 2014/24/EU on public procurement
      /// </summary>
      public const string EuEuratom2018Directive = "32018R1046";

      /// <summary>
      /// Directive (EU, Euratom) N:o 2018/1046
      /// </summary>
      public const string EuPublicProcurements2014Directive = "32014L0024";

      /// <summary>
      /// Directive 2014/25/EU on procurement by entities operating in the water, energy, transport and postal services sectors.
      /// </summary>
      public const string EuUtilitiesProcurements2014Directive = "32014L0025";

      /// <summary>
      /// Directive 2014/23/EU Concession notices
      /// </summary>
      public const string EuConcessionProcurement2014Directive = "32014L0023";

      /// <summary>
      /// Directive 2009/81/EC Defence contracts
      /// </summary>
      public const string EuDefenceProcurements2009Directive = "32009L0081";

      public Legislation CreateFromDirective( string directive )
      {
        switch (directive)
        {
          case EuPublicProcurements2014Directive:
            
            return new Legislation()
            {
              ID = new EuComGrowId("4ea7a10a-643e-4022-b67e-e06573b28ff5"),
              Titles = new[] { "DIRECTIVE 2014/24/EU OF THE EUROPEAN PARLIAMENT AND OF THE COUNCIL of 26 February 2014 on public procurement and repealing Directive 2004/18/EC" },
              Descriptions = new []
              {
                "DIRECTIVE 2014/24/EU OF THE EUROPEAN PARLIAMENT AND OF THE COUNCIL of 26 February 2014 on public procurement and repealing Directive 2004/18/EC"
              },
              JurisdictionLevels = new []{ "EU_DIRECTIVE"},
              Articles = new [] {"57(1)" },
              


            break;
        }  



      }


  }
}