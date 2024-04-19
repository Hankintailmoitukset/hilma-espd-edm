import { IdentifierType } from './IdentifierType'
import { CodeType } from './CodeType'
import { DateType } from './DateType'
import { TimeType } from './TimeType'
import { Party } from './Party'
import assign from 'lodash.assign'

interface RequiredArgsResultOfVerification {
}

export class ResultOfVerification {
  public constructor(init?:Partial<ResultOfVerification> & RequiredArgsResultOfVerification) {
    assign(this, init)
  }
  public validatorID?: IdentifierType
  public validationResultCode?: CodeType
  public validationDate?: DateType
  public validationTime?: TimeType
  public validateProcess?: string
  public validateTool?: string
  public validateToolVersion?: string
  public signatoryParty?: Party
  
}
