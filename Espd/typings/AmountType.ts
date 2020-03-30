import assign from 'lodash.assign'

export class AmountType {
    public constructor(init?:Partial<AmountType>) {
        assign(this, init)
    }
    
    
    currencyID: string = ''
    currencyCodeListVersionID: string = ''
}