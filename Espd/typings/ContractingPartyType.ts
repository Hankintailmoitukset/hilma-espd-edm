import { CodeType } from './CodeType'
import assign from 'lodash.assign'

interface RequiredArgsContractingPartyType {
}

export class ContractingPartyType {
  public constructor(init?:Partial<ContractingPartyType> & RequiredArgsContractingPartyType) {
    assign(this, init)
  }
  public partyTypeCode?: CodeType
  public partyType?: string
  
}
