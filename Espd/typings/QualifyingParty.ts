


import { QuantityType } from './QuantityType'
import { BusinessClassificationScheme } from './BusinessClassificationScheme'
import { AmountType } from './AmountType'
import { CompletedTask } from './CompletedTask'
import { PartyIdentificationType } from './PartyIdentificationType'

import assign from 'lodash.assign'

export class QualifyingParty { 
    public constructor(init?:Partial<QualifyingParty>) {
        assign(this, init)
    } 
    
    
    employeeQuantity?: QuantityType
    businessClassificationScheme?: BusinessClassificationScheme
    valueAmount?: AmountType
    completedTask?: CompletedTask
    id?: PartyIdentificationType
}