/**
 * This is a TypeGen auto-generated file.
 * Any changes made to this file can be lost when this file is regenerated.
 */

import { PartyIdentificationType } from "./party-identification-type";
import { IdentifierType } from "./identifier-type";
import { PartyNameType } from "./party-name-type";
import { AddressType } from "./address-type";
import { ContactType } from "./contact-type";
import { ServiceProviderPartyType } from "./service-provider-party-type";

export class PartyType {
    partyIdentification: PartyIdentificationType[];
    websiteURI: IdentifierType;
    endpointID: IdentifierType;
    partyName: PartyNameType;
    postalAddress: AddressType;
    contact: ContactType;
    serviceProviderParty: ServiceProviderPartyType;
}
