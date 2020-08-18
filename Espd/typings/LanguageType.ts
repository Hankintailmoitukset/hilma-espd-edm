


import { IdentifierType } from './IdentifierType'
import { CodeType } from './CodeType'

import assign from 'lodash.assign'

export class Language { 
    public constructor(init?:Partial<Language>) {
        assign(this, init)
    } 
    
    
    id?: IdentifierType
    name?: string
    localeCode?: CodeType
}