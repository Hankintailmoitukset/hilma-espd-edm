import assign from 'lodash.assign'

export class ContractingParty {
    public constructor(init?:Partial<ContractingParty>) {
        assign(this, init)
    }
    
    
    buyerProfileUri: IdentifierType | undefined
    partyType: PartyType | undefined
}