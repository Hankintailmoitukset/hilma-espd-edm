using System;
using Hilma.UBL.UnqualifiedDataTypes;

namespace Hilma.Espd.EDM.CriterionModels.v2_1_0.Identifiers
{
  public class EuComGrowId : IdentifierType
  {
    public EuComGrowId(Guid value) : this(value.ToString("D"))
    {
    }
    public EuComGrowId(string value) : base(value)
    {
      SchemeAgencyID = "EU-COM-GROW";
      SchemeVersionID = "2.1.0";
    }

    /// <summary>
    /// Generate random UUID as identifier
    /// </summary>
    /// <returns></returns>
    public static IdentifierType Random()
    {
      return new EuComGrowId(Guid.NewGuid());
    }
  }
}