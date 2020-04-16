


import { CodeType } from './CodeType'

import assign from 'lodash.assign'

export class ContractingPartyTypeType { 
    public constructor(init?:Partial<ContractingPartyTypeType>) {
        assign(this, init)
    } 
    
    
    partyTypeCode?: CodeType
    partyType?: string
}