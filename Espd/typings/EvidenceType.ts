


import { IdentifierType } from './IdentifierType'
import { CodeType } from './CodeType'
import { PartyType } from './PartyType'
import { DocumentReferenceType } from './DocumentReferenceType'
import { LanguageType } from './LanguageType'

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
    evidenceIssuingParty?: PartyType
    documentReference?: DocumentReferenceType[]
    language?: LanguageType
}