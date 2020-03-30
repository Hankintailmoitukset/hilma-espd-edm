

import { TextType } from './TextType'

import assign from 'lodash.assign'

export class ContractingActivityType {
    public constructor(init?:Partial<ContractingActivityType>) {
        assign(this, init)
    }
    
    
    activityTypeCode: CodeType | undefined
    activityType: TextType = new TextType()
}
 
