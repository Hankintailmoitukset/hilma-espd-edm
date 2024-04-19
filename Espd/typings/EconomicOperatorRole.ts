import { CodeType } from './CodeType'
import assign from 'lodash.assign'

interface RequiredArgsEconomicOperatorRole {
}

export class EconomicOperatorRole {
  public constructor(init?:Partial<EconomicOperatorRole> & RequiredArgsEconomicOperatorRole) {
    assign(this, init)
  }
  public roleCode?: CodeType
  public roleDescription?: string[]
  
}
