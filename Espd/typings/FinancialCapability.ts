import { AmountType } from './AmountType'
import assign from 'lodash.assign'

interface RequiredArgsFinancialCapability {
}

export class FinancialCapability {
  public constructor(init?:Partial<FinancialCapability> & RequiredArgsFinancialCapability) {
    assign(this, init)
  }
  public valueAmount?: AmountType
  
}
