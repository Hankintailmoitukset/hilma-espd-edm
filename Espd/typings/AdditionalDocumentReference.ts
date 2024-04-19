import { IdentifierType } from './IdentifierType'
import { CodeType } from './CodeType'
import { DateType } from './DateType'
import { TimeType } from './TimeType'
import { Attachment } from './Attachment'
import assign from 'lodash.assign'

interface RequiredArgsAdditionalDocumentReference {
}

export class AdditionalDocumentReference {
  public constructor(init?:Partial<AdditionalDocumentReference> & RequiredArgsAdditionalDocumentReference) {
    assign(this, init)
  }
  public id?: IdentifierType
  public uuid?: IdentifierType
  public documentTypeCode?: CodeType
  public documentType?: CodeType
  public issueDate?: DateType
  public issueTime?: TimeType
  public attachment?: Attachment
  
}
