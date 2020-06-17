using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Hilma.UBL.CommonAggregateComponents;

namespace Hilma.Espd.EDM.CriterionModels.v2_1_0
{
  
  /// <summary>
  /// ESPD EDM Version 2.1.0 specification
  /// </summary>
  public class CriterionSpecification : IEnumerable<TenderingCriterion>
  {

    public ExclusionGroundsSpecification ExclusionGrounds { get; } = new ExclusionGroundsSpecification();

    public SelectionCriteriaSpecification SelectionCriteria { get; } = new SelectionCriteriaSpecification();

    public OtherCriteriaSpecification OtherCriteria { get; } = new OtherCriteriaSpecification();

    public IEnumerable<TenderingCriterion> AllCriteria => new[]
    {
      ExclusionGrounds.AllCriteria,
      SelectionCriteria.AllCriteria,
      OtherCriteria.AllCriteria

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

   


