using Hilma.UBL.UnqualifiedDataTypes;

namespace Hilma.Espd.EDM.CriterionModels.v2_1_1.Identifiers
{
  public class EuComGrowCodeType : CodeType
  {
    public EuComGrowCodeType()
    {
    }

    public EuComGrowCodeType(string value) : base(value)
    {
      ListAgencyID = "EU-COM-GROW";
      ListVersionID = "2.1.1";

    }
  }
}