


import { ExternalReferenceType } from './ExternalReferenceType'

import assign from 'lodash.assign'

export class AttachmentType { 
    public constructor(init?:Partial<AttachmentType>) {
        assign(this, init)
    } 
    
    
    embeddedDocumentBinaryObject?: number[]
    embeddedDocument?: string
    externalReference?: ExternalReferenceType
}