import { IdentifierType } from './IdentifierType'
import { DateType } from './DateType'
import { TimeType } from './TimeType'
import { CodeType } from './CodeType'
import { Attachment } from './Attachment'
import { Period } from './Period'
import { Party } from './Party'
import { ResultOfVerification } from './ResultOfVerification'
import assign from 'lodash.assign'

interface RequiredArgsDocumentReference {
}

export class DocumentReference {
  public constructor(init?:Partial<DocumentReference> & RequiredArgsDocumentReference) {
    assign(this, init)
  }
  public id?: IdentifierType
  public copyIndicator?: boolean
  public uuid?: IdentifierType
  public issueDate?: DateType
  public issueTime?: TimeType
  public documentTypeCode?: CodeType
  public documentType?: string
  public xPath?: string[]
  public languageID?: IdentifierType
  public localeCode?: CodeType
  public versionID?: IdentifierType
  public documentStatusCode?: CodeType
  public documentDescription?: string[]
  public attachment?: Attachment
  public validityPeriod?: Period
  public issuerParty?: Party
  public resultOfVerification?: ResultOfVerification
  
}
