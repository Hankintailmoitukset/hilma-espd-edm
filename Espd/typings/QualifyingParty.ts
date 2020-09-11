


import { QuantityType } from './QuantityType'
import { BusinessClassificationScheme } from './BusinessClassificationScheme'
import { CompletedTask } from './CompletedTask'
import { Party } from './Party'

import assign from 'lodash.assign'
import { FinancialCapability } from './FinancialCapability';

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
