


import { IdentifierType } from './IdentifierType'
import { CodeType } from './CodeType'
import { DateType } from './DateType'
import { TimeType } from './TimeType'
import { TextType } from './TextType'
import { PartyType } from './PartyType'

import assign from 'lodash.assign'

export class ResultOfVerificationType { 
    public constructor(init?:Partial<ResultOfVerificationType>) {
        assign(this, init)
    } 
    
    
    validatorID: IdentifierType = new IdentifierType()
    validationResultCode: CodeType = new CodeType()
    validationDate: DateType = new DateType()
    validationTime: TimeType = new TimeType()
    validateProcess: TextType = new TextType()
    validateTool: TextType = new TextType()
    validateToolVersion: TextType = new TextType()
    signatoryParty: PartyType = new PartyType()
}