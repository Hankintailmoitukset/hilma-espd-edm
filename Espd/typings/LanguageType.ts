


import { IdentifierType } from './IdentifierType'
import { NameType } from './NameType'
import { CodeType } from './CodeType'

import assign from 'lodash.assign'

export class LanguageType { 
    public constructor(init?:Partial<LanguageType>) {
        assign(this, init)
    } 
    
    
    id?: IdentifierType
    name?: NameType
    localeCode?: CodeType
}