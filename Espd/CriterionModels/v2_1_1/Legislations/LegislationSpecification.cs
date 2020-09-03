using System;
using Hilma.Espd.EDM.CriterionModels.v2_1_1.Identifiers;
using Hilma.UBL.CommonAggregateComponents;
using Hilma.UBL.UnqualifiedDataTypes;

namespace Hilma.Espd.EDM.CriterionModels.v2_1_1.Legislations
{
  public class LegislationSpecification
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

    public Legislation EuPublicProcurements2014 => new Legislation()
    {
      ID = new EuComGrowId("4ea7a10a-643e-4022-b67e-e06573b28ff5"),
      Title =
        "DIRECTIVE 2014/24/EU OF THE EUROPEAN PARLIAMENT AND OF THE COUNCIL of 26 February 2014 on public procurement and repealing Directive 2004/18/EC",
      Description =
        "DIRECTIVE 2014/24/EU OF THE EUROPEAN PARLIAMENT AND OF THE COUNCIL of 26 February 2014 on public procurement and repealing Directive 2004/18/EC",
      JurisdictionLevel = "EU_DIRECTIVE",
      Article = "XX",
      URI = new IdentifierType("https://eur-lex.europa.eu/legal-content/EN/TXT/?uri=CELEX%3A32014L0024")
    };

    public Legislation EuUtilitiesProcurements2014 => new Legislation()
    {
      ID = new EuComGrowId("4ea7a10a-643e-4022-b67e-e06573b28ff5"),
      Title =
        "Directive 2014/25/EU of the European Parliament and of the Council of 26 February 2014 on procurement by entities operating in the water, energy, transport and postal services sectors and repealing Directive 2004/17/EC Text with EEA relevance",
      Description =
        "Directive 2014/25/EU of the European Parliament and of the Council of 26 February 2014 on procurement by entities operating in the water, energy, transport and postal services sectors and repealing Directive 2004/17/EC Text with EEA relevance",
      JurisdictionLevel =
        "EU_DIRECTIVE",
      Article = "57(1)",
      URI =
        new IdentifierType("https://eur-lex.europa.eu/legal-content/EN/TXT/?uri=CELEX%3A32014L0025")
    };

    public Legislation EuConcessionProcurement2014 => new Legislation()
    {
      ID = new EuComGrowId("4ea7a10a-643e-4022-b67e-e06573b28ff5"),
      Title =
        "Directive 2014/23/EU of the European Parliament and of the Council of 26 February 2014 on the award of concession contracts Text with EEA relevance",
      Description =
        "Directive 2014/23/EU of the European Parliament and of the Council of 26 February 2014 on the award of concession contracts Text with EEA relevance",
      JurisdictionLevel =
        "EU_DIRECTIVE",
      Article = "XX",
      URI = new IdentifierType("https://eur-lex.europa.eu/legal-content/EN/TXT/?uri=CELEX%3A32014L0023")
    };

    public Legislation EuEuratom2018 => new Legislation()
    {
      ID = new EuComGrowId("4ea7a10a-643e-4022-b67e-e06573b28ff5"),
      Title =
        "Regulation (EU, Euratom) 2018/1046 of the European Parliament and of the Council of 18 July 2018 on the financial rules applicable to the general budget of the Union, amending Regulations (EU) No 1296/2013, (EU) No 1301/2013, (EU) No 1303/2013, (EU) No 1304/2013, (EU) No 1309/2013, (EU) No 1316/2013, (EU) No 223/2014, (EU) No 283/2014, and Decision No 541/2014/EU and repealing Regulation (EU, Euratom) No 966/2012",
      Description =
        "Regulation (EU, Euratom) 2018/1046 of the European Parliament and of the Council of 18 July 2018 on the financial rules applicable to the general budget of the Union, amending Regulations (EU) No 1296/2013, (EU) No 1301/2013, (EU) No 1303/2013, (EU) No 1304/2013, (EU) No 1309/2013, (EU) No 1316/2013, (EU) No 223/2014, (EU) No 283/2014, and Decision No 541/2014/EU and repealing Regulation (EU, Euratom) No 966/2012",
      JurisdictionLevel =
        "EU_DIRECTIVE",
      Article = "XX",
      URI = new IdentifierType("https://eur-lex.europa.eu/legal-content/EN/TXT/?uri=CELEX:32018R1046")
    };

    public Legislation EuDefenceProcurements2009 => new Legislation()
    {
      ID = new EuComGrowId("4ea7a10a-643e-4022-b67e-e06573b28ff5"),
      Title =
        "Directive 2009/81/EC of the European Parliament and of the Council of 13 July 2009 on the coordination of procedures for the award of certain works contracts, supply contracts and service contracts by contracting authorities or entities in the fields of defence and security, and amending Directives 2004/17/EC and 2004/18/EC (Text with EEA relevance)",
      Description =
        "Directive 2009/81/EC of the European Parliament and of the Council of 13 July 2009 on the coordination of procedures for the award of certain works contracts, supply contracts and service contracts by contracting authorities or entities in the fields of defence and security, and amending Directives 2004/17/EC and 2004/18/EC (Text with EEA relevance)",
      JurisdictionLevel =
        "EU_DIRECTIVE",
      Article = "XX",
      URI =
        new IdentifierType("https://eur-lex.europa.eu/legal-content/EN/TXT/?uri=CELEX:32018R1046")
    };

    public Legislation CreateFromDirective(string directive)
    {
      switch (directive)
      {
        case EuPublicProcurements2014Directive:
          return EuPublicProcurements2014;
        case EuUtilitiesProcurements2014Directive:
          return EuUtilitiesProcurements2014;
        case EuConcessionProcurement2014Directive:
          return EuConcessionProcurement2014;
        case EuEuratom2018Directive:
          return EuEuratom2018;
        case EuDefenceProcurements2009Directive:
          return EuDefenceProcurements2009;
      }

      throw new ArgumentOutOfRangeException($"Invalid directive: {directive}");
    }
  }
}