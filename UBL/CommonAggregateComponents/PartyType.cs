using System.ComponentModel.DataAnnotations;
using Hilma.UBL.UnqualifiedDataTypes;

namespace Hilma.UBL.CommonAggregateComponents
{
  public class PartyType
  {
    /// <summary>
    /// The national identifier of a contracting body as it is legally registered (e.g. VAT identification).
    /// </summary>
    /// <remarks>More than one identifier can be specified. When possible use the VAT identification of the contracting body (see the VIES platform for a EU cross-border national VAT number verification system). The code list EOIDType may be used to indicate the type of identifier used as a value of the schemeID attribute, e.g. schemeID="VAT").</remarks>
    public PartyIdentificationType[] PartyIdentification { get; set; }

    /// <summary>
    /// The website of the contracting body.
    /// </summary>
    /// <remarks>For online services (e.g. Web Services, REST services, etc. use the component EndPointID.</remarks>
    public IdentifierType WebsiteURI { get; set; }

    /// <summary>
    /// Electronic address of the contracting body.
    /// </summary>
    /// <remarks>
    /// Use it for online services (e.g. Web Services, REST services, Delivery ID, ftp, etc. For the official web site of the Party use always the cac:Party/cbc:WebsiteURI). An end-point identifier MUST have a scheme identifier attribute (e.g.eSENSParty Identifier Scheme).
    /// Should be considered for all actors (contracting authority, service provider, economic operator) as an eDeliveryID.
    /// </remarks>
    public IdentifierType EndpointID { get; set; }

    /// <summary>
    /// Mandatory. The PartyName class has an associated basic element "cbc:Name". See XML example below.
    /// </summary>
    [Required]
    public PartyNameType PartyName { get; set; }

    /// <summary>
    /// Contracting body address information.
    /// </summary>
    [Required]
    public AddressType PostalAddress { get; set; }

    /// <summary>
    /// The primary contact for this party.
    /// </summary>
    public ContactType Contact { get; set; }

    /// <summary>
    /// The ESPD request may contain information of identification regarding an ESPD service provider: Name, Party Identification, Endpoint ID.
    /// </summary>
    public ServiceProviderPartyType ServiceProviderParty { get; set; }

  }
}