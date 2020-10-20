using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;
using Hilma.UBL.Attributes;
using Hilma.UBL.Serializers;
using Hilma.UBL.UnqualifiedDataTypes;

namespace Hilma.UBL.CommonAggregateComponents
{
  /// <summary>
  /// Service providers are officially recognised organisations that can supply ESPD Request documents (on behalf of the contracting body) with pre-filled information about the contracting body and additional information (e.g. liability statements, see tbr070-012)
  /// 
  /// The ESPD allows the provision of data about the service provider who produced the ESPD Request document (and equally for the ESPD Response document, on behalf of the economic operator).
  /// </summary>
  [Contract]
  public class ServiceProviderParty
  {
    public IdentifierType ID { get; set; }

    /// <summary>
    /// Optional
    /// </summary>
    public CodeType ServiceProviderTypeCode { get; set; }

    /// <summary>
    /// Optional
    /// </summary>
    public string[] ServiceType { get; set; }

    /// <summary>
    /// Main information about the service provider.
    /// </summary>
    [Required]
    public Party Party { get; set; }

    public XElement Serialize()
    { 
      return new XElement(UblNames.Cac + nameof(ServiceProviderParty),
          ID.Serialize(nameof(ID)),
          ServiceProviderTypeCode.Serialize(nameof(ServiceProviderTypeCode)),
          ServiceType.Serialize(nameof(ServiceType)),
          Party?.Serialize(nameof(Party))
        );
    }
  }
}