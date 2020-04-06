



import assign from 'lodash.assign'

export class AmountType { 
    public constructor(init?:Partial<AmountType>) {
        assign(this, init)
    } 
    
    value?: number
    
    currencyID?: string
    currencyCodeListVersionID?: string
}