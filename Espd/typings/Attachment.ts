import { ExternalReference } from './ExternalReference'
import assign from 'lodash.assign'

export class Attachment { 
    public constructor(init?:Partial<Attachment>) {
        assign(this, init)
    } 
    
    
    embeddedDocumentBinaryObject?: number[]
    embeddedDocument?: string
    externalReference?: ExternalReference
}
