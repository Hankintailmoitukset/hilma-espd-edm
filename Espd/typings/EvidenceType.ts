import assign from 'lodash.assign'

export class EvidenceType {
    public constructor(init?:Partial<EvidenceType>) {
        assign(this, init)
    }
    
    
    id: IdentifierType | undefined
    evidenceTypeCode: CodeType | undefined
    name: NameType | undefined
    description: TextType[] = []
    candidateStatement: TextType[] = []
    confidentialityLevelCode: CodeType | undefined
    evidenceIssuingParty: PartyType | undefined
    documentReference: DocumentReferenceType[] = []
    language: LanguageType | undefined
}