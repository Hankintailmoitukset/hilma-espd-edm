import { IdentifierType } from './IdentifierType'
import { Party } from './Party'
import assign from 'lodash.assign'

export class ContractingParty { 
    public constructor(init?:Partial<ContractingParty>) {
        assign(this, init)
    } 
    
    
    buyerProfileUri?: IdentifierType
    party?: Party
}
