


import { IdentifierType } from './IdentifierType'
import { LanguageType } from './LanguageType'
import { AddressType } from './AddressType'

import assign from 'lodash.assign'

export class Legislation { 
    public constructor(init?:Partial<Legislation>) {
        assign(this, init)
    } 
    
    
    id?: IdentifierType
    titles?: string[]
    descriptions?: string[]
    jurisdictionLevels?: string[]
    articles?: string[]
    urIs?: IdentifierType[]
    languages?: LanguageType[]
    jurisdictionRegionAddresses?: AddressType[]
}