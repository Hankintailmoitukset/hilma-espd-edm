


import { IdentifierType } from './IdentifierType'
import { DateType } from './DateType'
import { TimeType } from './TimeType'
import { CodeType } from './CodeType'
import { Attachment } from './Attachment'
import { Period } from './Period'
import { Party } from './Party'
import { ResultOfVerification } from './ResultOfVerification'

import assign from 'lodash.assign'

export class DocumentReference { 
    public constructor(init?:Partial<DocumentReference>) {
        assign(this, init)
    } 
    
    
    id?: IdentifierType
    copyIndicator?: boolean
    uuid?: IdentifierType
    issueDate?: DateType
    issueTime?: TimeType
    documentTypeCode?: CodeType
    documentType?: string
    xPath?: string[]
    languageID?: IdentifierType
    localeCode?: CodeType
    versionID?: IdentifierType
    documentStatusCode?: CodeType
    documentDescription?: string[]
    attachment?: Attachment
    validityPeriod?: Period
    issuerParty?: Party
    resultOfVerification?: ResultOfVerification
}