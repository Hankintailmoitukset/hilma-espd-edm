import assign from 'lodash.assign'

interface RequiredArgsAmountType {
}

export class AmountType {
  public constructor(init?:Partial<AmountType> & RequiredArgsAmountType) {
    assign(this, init)
  }
  public value?: number
  
  public currencyID?: string
  public currencyCodeListVersionID?: string
  
}
