


import { PartyIdentification } from './PartyIdentification'
import { IdentifierType } from './IdentifierType'
import { PartyName } from './PartyName'
import { AddressType } from './AddressType'
import { Contact } from './Contact'
import { ServiceProviderPartyType } from './ServiceProviderPartyType'

import assign from 'lodash.assign'

export class Party { 
    public constructor(init?:Partial<Party>) {
        assign(this, init)
    } 
    
    
    partyIdentification?: PartyIdentification[]
    websiteURI?: IdentifierType
    endpointID?: IdentifierType
    partyName?: PartyName
    postalAddress?: AddressType
    contact?: Contact
    serviceProviderParty?: ServiceProviderPartyType
}