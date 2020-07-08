


import { QualifyingParty } from './QualifyingParty'
import { EconomicOperatorRole } from './EconomicOperatorRole'
import { PartyType } from './PartyType'

import assign from 'lodash.assign'

export class EconomicOperatorParty { 
    public constructor(init?:Partial<EconomicOperatorParty>) {
        assign(this, init)
    } 
    
    
    qualifyingParty?: QualifyingParty
    economicOperatorRole?: EconomicOperatorRole
    party?: PartyType
}