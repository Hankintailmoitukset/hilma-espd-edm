


import { IdentifierType } from './IdentifierType'
import { PartyType } from './PartyType'

import assign from 'lodash.assign'

export class ContractingParty { 
    public constructor(init?:Partial<ContractingParty>) {
        assign(this, init)
    } 
    
    
    buyerProfileUri?: IdentifierType
    party?: PartyType
}