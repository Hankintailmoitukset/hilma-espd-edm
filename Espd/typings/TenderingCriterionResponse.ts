


import { IdentifierType } from './IdentifierType'
import { CodeType } from './CodeType'
import { ResponseValue } from './ResponseValue'
import { Period } from './Period'
import { EvidenceSupplied } from './EvidenceSupplied'

import assign from 'lodash.assign'

export class TenderingCriterionResponse { 
    public constructor(init?:Partial<TenderingCriterionResponse>) {
        assign(this, init)
    } 
    
    
    id?: IdentifierType
    validatedCriterionPropertyID?: IdentifierType
    confidentialityLevelCode?: CodeType
    responseValue?: ResponseValue[]
    applicablePeriod?: Period
    evidenceSupplied?: EvidenceSupplied
}
