


import { IdentifierType } from './IdentifierType'
import { CodeType } from './CodeType'
import { Party } from './Party'

import assign from 'lodash.assign'

export class ServiceProviderParty { 
    public constructor(init?:Partial<ServiceProviderParty>) {
        assign(this, init)
    } 
    
    
    id?: IdentifierType
    serviceProviderTypeCode?: CodeType
    serviceType?: string[]
    party?: Party
}