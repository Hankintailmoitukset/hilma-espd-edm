


import { QuantityType } from './QuantityType'
import { BusinessClassificationScheme } from './BusinessClassificationScheme'
import { CompletedTask } from './CompletedTask'
import { Party } from './Party'
import { FinancialCapability } from './FinancialCapability'

import assign from 'lodash.assign'

export class QualifyingParty { 
    public constructor(init?:Partial<QualifyingParty>) {
        assign(this, init)
    } 
    
    employeeQuantity?: QuantityType
    businessClassificationScheme?: BusinessClassificationScheme
    financialCapability?: FinancialCapability
    completedTask?: CompletedTask
    party?: Party
}
