


import { IdentifierType } from './IdentifierType'
import { CodeType } from './CodeType'
import { DateType } from './DateType'
import { TimeType } from './TimeType'
import { AttachmentType } from './AttachmentType'

import assign from 'lodash.assign'

export class AdditionalDocumentReference { 
    public constructor(init?:Partial<AdditionalDocumentReference>) {
        assign(this, init)
    } 
    
    
    id?: IdentifierType
    uuid?: IdentifierType
    documentTypeCode?: CodeType
    documentType?: CodeType
    issueDate?: DateType
    issueTime?: TimeType
    attachment?: AttachmentType
}