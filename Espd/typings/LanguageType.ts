

import { IdentifierType } from './IdentifierType'
import { NameType } from './NameType'

import assign from 'lodash.assign'

export class LanguageType {
    public constructor(init?:Partial<LanguageType>) {
        assign(this, init)
    }
    
    
    id: IdentifierType = new IdentifierType()
    name: NameType = new NameType()
    localeCode: CodeType | undefined
}
 
