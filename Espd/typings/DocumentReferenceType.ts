


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
    
    
    id?: IdentifierType
    copyIndicator?: boolean
    uuid?: IdentifierType
    issueDate?: DateType
    issueTime?: TimeType
    documentTypeCode?: CodeType
    documentType?: TextType
    xPath?: TextType[]
    languageID?: IdentifierType
    localeCode?: CodeType
    versionID?: IdentifierType
    documentStatusCode?: CodeType
    documentDescription?: TextType[]
    attachment?: AttachmentType
    validityPeriod?: PeriodType
    issuerParty?: PartyType
    resultOfVerification?: ResultOfVerificationType
}