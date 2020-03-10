using System.ComponentModel.DataAnnotations;
using UBL.PrimitiveTypes;

namespace UBL.CommonAggregateComponents
{
  public class ContractingParty
  {
    public string BuyerProfileUri { get; set; }

    public ContractingPartyType ContractingPartyType { get; set; }

    [Required]
    public Party Party { get; set; }
  }

  public class Party
  {
    public NormalizedString[] Name { get; set; }

  }

  public class ProcurementProject
  {
    
  }

  public class ProcurementProjectLot
  {

  }
}