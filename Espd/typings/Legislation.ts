


import { IdentifierType } from './IdentifierType'
import { Language } from './Language'
import { AddressType } from './AddressType'

import assign from 'lodash.assign'

export class Legislation { 
    public constructor(init?:Partial<Legislation>) {
        assign(this, init)
    } 
    
    
    id?: IdentifierType
    title?: string
    description?: string
    jurisdictionLevel?: string
    article?: string
    uri?: IdentifierType
    languages?: Language[]
    jurisdictionRegionAddress?: AddressType
}