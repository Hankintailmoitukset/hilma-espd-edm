import assign from 'lodash.assign'

export class ResultOfVerificationType {
    public constructor(init?:Partial<ResultOfVerificationType>) {
        assign(this, init)
    }
    
    
    validatorID: IdentifierType | undefined
    validationResultCode: CodeType | undefined
    validationDate: DateType | undefined
    validationTime: TimeType | undefined
    validateProcess: TextType | undefined
    validateTool: TextType | undefined
    validateToolVersion: TextType | undefined
    signatoryParty: PartyType | undefined
}