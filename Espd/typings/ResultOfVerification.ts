import { IdentifierType } from './IdentifierType'
import { CodeType } from './CodeType'
import { DateType } from './DateType'
import { TimeType } from './TimeType'
import { Party } from './Party'
import assign from 'lodash.assign'

export class ResultOfVerification { 
    public constructor(init?:Partial<ResultOfVerification>) {
        assign(this, init)
    } 
    
    
    validatorID?: IdentifierType
    validationResultCode?: CodeType
    validationDate?: DateType
    validationTime?: TimeType
    validateProcess?: string
    validateTool?: string
    validateToolVersion?: string
    signatoryParty?: Party
}
