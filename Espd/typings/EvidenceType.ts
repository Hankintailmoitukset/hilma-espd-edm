


import { IdentifierType } from './IdentifierType'
import { CodeType } from './CodeType'
import { Party } from './Party'
import { DocumentReferenceType } from './DocumentReferenceType'
import { Language } from './Language'

import assign from 'lodash.assign'

export class EvidenceType { 
    public constructor(init?:Partial<EvidenceType>) {
        assign(this, init)
    } 
    
    
    id?: IdentifierType
    evidenceTypeCode?: CodeType
    name?: string
    description?: string[]
    candidateStatement?: string[]
    confidentialityLevelCode?: CodeType
    evidenceIssuingParty?: Party
    documentReference?: DocumentReferenceType[]
    language?: Language
}