import { QuantityType } from './QuantityType'
import { BusinessClassificationScheme } from './BusinessClassificationScheme'
import { FinancialCapability } from './FinancialCapability'
import { CompletedTask } from './CompletedTask'
import { Party } from './Party'
import assign from 'lodash.assign'

interface RequiredArgsQualifyingParty {
}

export class QualifyingParty {
  public constructor(init?:Partial<QualifyingParty> & RequiredArgsQualifyingParty) {
    assign(this, init)
  }
  public employeeQuantity?: QuantityType
  public businessClassificationScheme?: BusinessClassificationScheme
  public financialCapability?: FinancialCapability
  public completedTask?: CompletedTask
  public party?: Party
  
}
