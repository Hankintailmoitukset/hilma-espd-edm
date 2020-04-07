


import { IdentifierType } from './IdentifierType'
import { CodeType } from './CodeType'

import assign from 'lodash.assign'

export class LanguageType { 
    public constructor(init?:Partial<LanguageType>) {
        assign(this, init)
    } 
    
    
    id?: IdentifierType
    name?: string
    localeCode?: CodeType
}