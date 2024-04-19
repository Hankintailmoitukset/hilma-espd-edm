import { IdentifierType } from './IdentifierType'
import { DateType } from './DateType'
import { TimeType } from './TimeType'
import { CodeType } from './CodeType'
import assign from 'lodash.assign'

interface RequiredArgsExternalReference {
}

export class ExternalReference {
  public constructor(init?:Partial<ExternalReference> & RequiredArgsExternalReference) {
    assign(this, init)
  }
  public uri?: IdentifierType
  public documentHash?: string
  public hashAlgorithmMethod?: string
  public expiryDate?: DateType
  public expiryTime?: TimeType
  public mimeCode?: CodeType
  public formatCode?: CodeType
  public encodingCode?: CodeType
  public characterSetCode?: CodeType
  public fileName?: string
  public description?: string[]
  
}
