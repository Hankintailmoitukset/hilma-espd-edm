
import assign from 'lodash.assign'
import { AmountType } from './AmountType'

export class FinancialCapability { 
    public constructor(init?:Partial<FinancialCapability>) {
        assign(this, init)
    } 
    
    
    valueAmount?: AmountType
}
