


import { PartyIdentification } from './PartyIdentification'
import { IdentifierType } from './IdentifierType'
import { PartyName } from './PartyName'
import { Address } from './Address'
import { Contact } from './Contact'
import { ServiceProviderParty } from './ServiceProviderParty'

import assign from 'lodash.assign'

export class Party { 
    public constructor(init?:Partial<Party>) {
        assign(this, init)
    } 
    
    
    partyIdentification?: PartyIdentification
    websiteURI?: IdentifierType
    endpointID?: IdentifierType
    partyName?: PartyName
    postalAddress?: Address
    contact?: Contact
    serviceProviderParty?: ServiceProviderParty
}