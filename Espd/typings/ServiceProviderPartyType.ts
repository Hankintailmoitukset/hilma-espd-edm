


import { IdentifierType } from './IdentifierType'
import { CodeType } from './CodeType'
import { PartyType } from './PartyType'

import assign from 'lodash.assign'

export class ServiceProviderPartyType { 
    public constructor(init?:Partial<ServiceProviderPartyType>) {
        assign(this, init)
    } 
    
    
    id?: IdentifierType
    serviceProviderTypeCode?: CodeType
    serviceType?: string[]
    party?: PartyType
}