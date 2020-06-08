using System;
using Hilma.UBL.Attributes;

namespace Hilma.UBL.CommonAggregateComponents
{
  [Contract]
  public class PeriodType
  {
    public DateTime StartDate { get; set; }

    public DateTime EndDate { get; set; }

  }

}