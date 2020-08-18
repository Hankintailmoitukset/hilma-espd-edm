


import { IdentifierType } from './IdentifierType'
import { CodeType } from './CodeType'
import { Party } from './Party'
import { DocumentReference } from './DocumentReference'
import { Language } from './Language'

import assign from 'lodash.assign'

export class Evidence { 
    public constructor(init?:Partial<Evidence>) {
        assign(this, init)
    } 
    
    
    id?: IdentifierType
    evidenceTypeCode?: CodeType
    name?: string
    description?: string[]
    candidateStatement?: string[]
    confidentialityLevelCode?: CodeType
    evidenceIssuingParty?: Party
    documentReference?: DocumentReference[]
    language?: Language
}