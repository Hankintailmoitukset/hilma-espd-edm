

import { PartyIdentificationType } from './PartyIdentificationType'
import { IdentifierType } from './IdentifierType'
import { PartyNameType } from './PartyNameType'
import { AddressType } from './AddressType'
import { ContactType } from './ContactType'
import { ServiceProviderPartyType } from './ServiceProviderPartyType'

import assign from 'lodash.assign'

export class PartyType {
    public constructor(init?:Partial<PartyType>) {
        assign(this, init)
    } 
    
    
    partyIdentification: PartyIdentificationType[] = []
    websiteURI: IdentifierType = new IdentifierType()
    endpointID: IdentifierType = new IdentifierType()
    partyName: PartyNameType = new PartyNameType()
    postalAddress: AddressType = new AddressType()
    contact: ContactType = new ContactType()
    serviceProviderParty: ServiceProviderPartyType = new ServiceProviderPartyType()
}