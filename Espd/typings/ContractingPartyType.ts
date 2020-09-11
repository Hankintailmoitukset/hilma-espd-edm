


import { CodeType } from './CodeType'

import assign from 'lodash.assign'

export class ContractingPartyType { 
    public constructor(init?:Partial<ContractingPartyType>) {
        assign(this, init)
    } 
    
    
    partyTypeCode?: CodeType
    partyType?: string
}
