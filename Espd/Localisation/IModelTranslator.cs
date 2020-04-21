using Hilma.UBL.CommonAggregateComponents;

namespace Hilma.Espd.EDM.Localisation
{
  public interface IModelTranslator
  {
    TenderingCriterion TranslateCriterion(TenderingCriterion tenderingCriterion);

  }
}