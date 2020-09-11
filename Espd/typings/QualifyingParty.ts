


import { QuantityType } from './QuantityType'
import { BusinessClassificationScheme } from './BusinessClassificationScheme'
import { CompletedTask } from './CompletedTask'
import { PartyIdentification } from './PartyIdentification'

import assign from 'lodash.assign'

export class QualifyingParty { 
    public constructor(init?:Partial<QualifyingParty>) {
        assign(this, init)
    } 
    
    
    employeeQuantity?: QuantityType
    businessClassificationScheme?: BusinessClassificationScheme
    financialCapability?: FinancialCapability
    completedTask?: CompletedTask
    id?: PartyIdentification
}
