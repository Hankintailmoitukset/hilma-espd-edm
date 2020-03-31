


import { IdentifierType } from './IdentifierType'
import { DateType } from './DateType'
import { TimeType } from './TimeType'
import { CodeType } from './CodeType'
import { TextType } from './TextType'
import { AttachmentType } from './AttachmentType'
import { PeriodType } from './PeriodType'
import { PartyType } from './PartyType'
import { ResultOfVerificationType } from './ResultOfVerificationType'

import assign from 'lodash.assign'

export class DocumentReferenceType { 
    public constructor(init?:Partial<DocumentReferenceType>) {
        assign(this, init)
    } 
    
    
    id: IdentifierType = new IdentifierType()
    copyIndicator: boolean = false
    uuid: IdentifierType = new IdentifierType()
    issueDate: DateType = new DateType()
    issueTime: TimeType = new TimeType()
    documentTypeCode: CodeType = new CodeType()
    documentType: TextType = new TextType()
    xPath: TextType[] = []
    languageID: IdentifierType = new IdentifierType()
    localeCode: CodeType = new CodeType()
    versionID: IdentifierType = new IdentifierType()
    documentStatusCode: CodeType = new CodeType()
    documentDescription: TextType[] = []
    attachment: AttachmentType = new AttachmentType()
    validityPeriod: PeriodType = new PeriodType()
    issuerParty: PartyType = new PartyType()
    resultOfVerification: ResultOfVerificationType = new ResultOfVerificationType()
}