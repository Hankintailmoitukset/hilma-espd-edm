


import { IdentifierType } from './IdentifierType'
import { CodeType } from './CodeType'
import { PeriodType } from './PeriodType'
import { EvidenceType } from './EvidenceType'
import { ResponseValue } from './ResponseValue'


import assign from 'lodash.assign'

export class TenderingCriterionResponse { 
    public constructor(init?:Partial<TenderingCriterionResponse>) {
        assign(this, init)
    } 
    
    
    id?: IdentifierType
    validatedCriterionPropertyID?: IdentifierType
    confidentialityLevelCode?: CodeType
    responseValue?: ResponseValue[]
    applicablePeriod?: PeriodType
    evidenceSupplied?: EvidenceType
}