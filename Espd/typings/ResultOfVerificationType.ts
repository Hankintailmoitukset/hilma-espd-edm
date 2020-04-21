


import { IdentifierType } from './IdentifierType'
import { CodeType } from './CodeType'
import { DateType } from './DateType'
import { TimeType } from './TimeType'
import { PartyType } from './PartyType'

import assign from 'lodash.assign'

export class ResultOfVerificationType { 
    public constructor(init?:Partial<ResultOfVerificationType>) {
        assign(this, init)
    } 
    
    
    validatorID?: IdentifierType
    validationResultCode?: CodeType
    validationDate?: DateType
    validationTime?: TimeType
    validateProcess?: string
    validateTool?: string
    validateToolVersion?: string
    signatoryParty?: PartyType
}