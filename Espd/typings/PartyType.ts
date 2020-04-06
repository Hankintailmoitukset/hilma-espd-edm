


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
    
    
    partyIdentification?: PartyIdentificationType[]
    websiteURI?: IdentifierType
    endpointID?: IdentifierType
    partyName?: PartyNameType
    postalAddress?: AddressType
    contact?: ContactType
    serviceProviderParty?: ServiceProviderPartyType
}