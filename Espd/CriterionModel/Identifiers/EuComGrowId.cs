using Hilma.UBL.UnqualifiedDataTypes;

namespace Hilma.Espd.EDM.CriterionModel.Identifiers
{
  public class EuComGrowId : IdentifierType
  {
    public EuComGrowId(string value) : base(value)
    {
      SchemeAgencyID = "EU-COM-GROW";
    }
  }
}