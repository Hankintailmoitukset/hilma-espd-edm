using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Xml.Linq;
using Hilma.UBL.Attributes;
using Hilma.UBL.Serializers;
using Hilma.UBL.UnqualifiedDataTypes;

namespace Hilma.UBL.CommonAggregateComponents
{
  [Contract]
  public class Party
  {
    /// <summary>
    /// The national identifier of a contracting body as it is legally registered (e.g. VAT identification).
    /// </summary>
    /// <remarks>More than one identifier can be specified. When possible use the VAT identification of the contracting body (see the VIES platform for a EU cross-border national VAT number verification system). The code list EOIDType may be used to indicate the type of identifier used as a value of the schemeID attribute, e.g. schemeID="VAT").</remarks>
    public PartyIdentification[] PartyIdentification { get; set; }

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
    public PartyName PartyName { get; set; }

    /// <summary>
    /// Contracting body address information.
    /// </summary>
    public Address PostalAddress { get; set; }

    /// <summary>
    /// The primary contact for this party.
    /// </summary>
    public Contact Contact { get; set; }

    /// <summary>
    /// The ESPD request may contain information of identification regarding an ESPD service provider: Name, Party Identification, Endpoint ID.
    /// </summary>
    public ServiceProviderParty ServiceProviderParty { get; set; }

    public XElement Serialize( string name = null )
    {
      return new XElement(UblNames.Cac + (name ?? nameof(Party)),
        WebsiteURI?.Serialize(nameof(WebsiteURI)),
        EndpointID?.Serialize(nameof(EndpointID)),
        PartyIdentification?.Select( pi => pi.Serialize()),
        PartyName?.Serialize(),
        PostalAddress?.Serialize(nameof(PostalAddress)),
        Contact?.Serialize()
      );
    }
  }
}