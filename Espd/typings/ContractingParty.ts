import { IdentifierType } from './IdentifierType'
import { Party } from './Party'
import assign from 'lodash.assign'

interface RequiredArgsContractingParty {
}

export class ContractingParty {
  public constructor(init?:Partial<ContractingParty> & RequiredArgsContractingParty) {
    assign(this, init)
  }
  public buyerProfileUri?: IdentifierType
  public party?: Party
  
}
