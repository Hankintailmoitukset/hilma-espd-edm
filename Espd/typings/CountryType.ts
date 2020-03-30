

import { IdentifierType } from './IdentifierType'
import { NameType } from './NameType'

import assign from 'lodash.assign'

export class CountryType {
    public constructor(init?:Partial<CountryType>) {
        assign(this, init)
    }
    
    
    identificationCode: IdentifierType = new IdentifierType()
    name: NameType = new NameType()
}
 
