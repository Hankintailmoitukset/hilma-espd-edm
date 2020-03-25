using System.ComponentModel.DataAnnotations;
using Hilma.UBL.UnqualifiedDataTypes;

namespace Hilma.UBL.CommonAggregateComponents
{
  /// <summary>
  /// Service providers are officially recognised organisations that can supply ESPD Request documents (on behalf of the contracting body) with pre-filled information about the contracting body and additional information (e.g. liability statements, see tbr070-012)
  /// 
  /// The ESPD allows the provision of data about the service provider who produced the ESPD Request document (and equally for the ESPD Response document, on behalf of the economic operator).
  /// </summary>
  public class ServiceProviderPartyType
  {
    public IdentifierType ID { get; set; }

    /// <summary>
    /// Optional
    /// </summary>
    public CodeType ServiceProviderTypeCode { get; set; }

    /// <summary>
    /// Optional
    /// </summary>
    public TextType[] ServiceType { get; set; }

    /// <summary>
    /// Main information about the service provider.
    /// </summary>
    [Required]
    public PartyType Party { get; set; }
  }
}