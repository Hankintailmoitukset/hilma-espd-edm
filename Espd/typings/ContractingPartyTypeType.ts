

import { CodeType } from './CodeType'
import { TextType } from './TextType'

import assign from 'lodash.assign'

export class ContractingPartyTypeType {
    public constructor(init?:Partial<ContractingPartyTypeType>) {
        assign(this, init)
    } 
    
    
    partyTypeCode: CodeType = new CodeType()
    partyType: TextType = new TextType()
}