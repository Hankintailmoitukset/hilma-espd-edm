import assign from 'lodash.assign'

export class DocumentReferenceType {
    public constructor(init?:Partial<DocumentReferenceType>) {
        assign(this, init)
    }
    
    
    id: IdentifierType | undefined
    copyIndicator: boolean = false
    uuid: IdentifierType | undefined
    issueDate: DateType | undefined
    issueTime: TimeType | undefined
    documentTypeCode: CodeType | undefined
    documentType: TextType | undefined
    xPath: TextType[] = []
    languageID: IdentifierType | undefined
    localeCode: CodeType | undefined
    versionID: IdentifierType | undefined
    documentStatusCode: CodeType | undefined
    documentDescription: TextType[] = []
    attachment: AttachmentType | undefined
    validityPeriod: PeriodType | undefined
    issuerParty: PartyType | undefined
    resultOfVerification: ResultOfVerificationType | undefined
}