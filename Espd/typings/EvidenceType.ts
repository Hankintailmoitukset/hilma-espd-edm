

import { IdentifierType } from './IdentifierType'
import { CodeType } from './CodeType'
import { NameType } from './NameType'
import { TextType } from './TextType'
import { PartyType } from './PartyType'
import { DocumentReferenceType } from './DocumentReferenceType'
import { LanguageType } from './LanguageType'

import assign from 'lodash.assign'

export class EvidenceType {
    public constructor(init?:Partial<EvidenceType>) {
        assign(this, init)
    } 
    
    
    id: IdentifierType = new IdentifierType()
    evidenceTypeCode: CodeType = new CodeType()
    name: NameType = new NameType()
    description: TextType[] = []
    candidateStatement: TextType[] = []
    confidentialityLevelCode: CodeType = new CodeType()
    evidenceIssuingParty: PartyType = new PartyType()
    documentReference: DocumentReferenceType[] = []
    language: LanguageType = new LanguageType()
}