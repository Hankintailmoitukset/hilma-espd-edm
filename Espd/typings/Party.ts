


import { CodeType } from './CodeType'
import { PartyIdentification } from './PartyIdentification'
import { IdentifierType } from './IdentifierType'
import { PartyName } from './PartyName'
import { Address } from './Address'
import { Contact } from './Contact'
import { Person } from './Person'
import { ServiceProviderParty } from './ServiceProviderParty'
import { PowerOfAttorney } from './PowerOfAttorney'

import assign from 'lodash.assign'

export class Party { 
    public constructor(init?:Partial<Party>) {
        assign(this, init)
    } 
    
    
    industryClassificationCode?: CodeType
    partyIdentification?: PartyIdentification
    websiteURI?: IdentifierType
    endpointID?: IdentifierType
    partyName?: PartyName
    postalAddress?: Address
    contact?: Contact
    person?: Person
    serviceProviderParty?: ServiceProviderParty
    powerOfAttorneys?: PowerOfAttorney[]
    agentParty?: Party
}
