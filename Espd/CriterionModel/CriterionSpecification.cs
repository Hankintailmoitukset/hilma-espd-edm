using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Hilma.UBL.CommonAggregateComponents;

namespace Hilma.Espd.EDM.CriterionModel
{
  public class CriterionSpecification : IEnumerable<TenderingCriterion>
  {
    public ExclusionGroundsSpecification ExclusionGrounds { get; set; } = new ExclusionGroundsSpecification();

    public SelectionCriteriaSpecification SelectionCriteria { get; set; } = new SelectionCriteriaSpecification();

    public IEnumerable<TenderingCriterion> AllCriteria => new[]
    {
      ExclusionGrounds.AllCriteria,
      SelectionCriteria.AllCriteria

    }.SelectMany(c => c);

    public IEnumerator<TenderingCriterion> GetEnumerator()
    {
      return AllCriteria.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
      return AllCriteria.GetEnumerator();
    }
  }
}

   


