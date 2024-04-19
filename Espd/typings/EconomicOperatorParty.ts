import { QualifyingParty } from './QualifyingParty'
import { EconomicOperatorRole } from './EconomicOperatorRole'
import { Party } from './Party'
import assign from 'lodash.assign'

interface RequiredArgsEconomicOperatorParty {
}

export class EconomicOperatorParty {
  public constructor(init?:Partial<EconomicOperatorParty> & RequiredArgsEconomicOperatorParty) {
    assign(this, init)
  }
  public qualifyingParty?: QualifyingParty
  public economicOperatorRole?: EconomicOperatorRole
  public party?: Party
  
}
