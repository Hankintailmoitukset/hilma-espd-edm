import { ExternalReference } from './ExternalReference'
import assign from 'lodash.assign'

interface RequiredArgsAttachment {
}

export class Attachment {
  public constructor(init?:Partial<Attachment> & RequiredArgsAttachment) {
    assign(this, init)
  }
  public embeddedDocumentBinaryObject?: number[]
  public embeddedDocument?: string
  public externalReference?: ExternalReference
  
}
