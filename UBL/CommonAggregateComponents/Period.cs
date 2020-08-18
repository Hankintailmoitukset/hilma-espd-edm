using System;
using System.Xml.Linq;
using Hilma.UBL.Attributes;
using Hilma.UBL.Serializers;
using Hilma.UBL.UnqualifiedDataTypes;

namespace Hilma.UBL.CommonAggregateComponents
{
  [Contract]
  public class Period
  {
    public DateTime StartDate { get; set; }

    public DateTime EndDate { get; set; }

    public XElement Serialize(string name)
    {
      return new XElement(UblNames.Cac + name, 
        StartDate.SerializeAsDate(nameof(StartDate)),
        EndDate.SerializeAsDate(nameof(EndDate)));
    }
  }

}