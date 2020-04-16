


import { IdentifierType } from './IdentifierType'

import assign from 'lodash.assign'

export class CountryType { 
    public constructor(init?:Partial<CountryType>) {
        assign(this, init)
    } 
    
    
    identificationCode?: IdentifierType
    name?: string
}