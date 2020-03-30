using Hilma.UBL.CommonAggregateComponents;

namespace espd.service.Controllers
{
  public interface IModelTranslator
  {
    TenderingCriterion TranslateCriterion(TenderingCriterion tenderingCriterion);

  }
}