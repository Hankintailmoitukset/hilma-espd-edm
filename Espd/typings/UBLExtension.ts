import { IdentifierType } from './IdentifierType'
import { CodeType } from './CodeType'
import assign from 'lodash.assign'

interface RequiredArgsUBLExtension {
}

export class UBLExtension {
  public constructor(init?:Partial<UBLExtension> & RequiredArgsUBLExtension) {
    assign(this, init)
  }
  public id?: IdentifierType
  public name?: string
  public extensionAgencyID?: IdentifierType
  public extensionAgencyName?: string
  public extensionVersionID?: IdentifierType
  public extensionAgencyURI?: IdentifierType
  public extensionReasonCode?: CodeType
  public extensionReason?: string
  public extensionContent?: any
  
}
