using System.ComponentModel.DataAnnotations;
using Hilma.UBL.Attributes;

namespace Hilma.UBL.CommonAggregateComponents
{
  /// <summary>
  /// The name of the contracting body as it is registered.
  /// </summary>
  [Contract]
  public class PartyNameType
  {
    /// <summary>
    /// Mandatory. Use the official name of the contracting body. The PartyName class has an associated basic element "cbc:Name". See XML example below.
    /// </summary>
    /// <remarks>Mandatory. Use the official name of the contracting body.</remarks>
    [Required]
    public string Name { get; set; }

  }
}