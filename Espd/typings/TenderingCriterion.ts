


import { IdentifierType } from './IdentifierType'
import { CodeType } from './CodeType'
import { Legislation } from './Legislation'
import { TenderingCriterionPropertyGroup } from './TenderingCriterionPropertyGroup'

import assign from 'lodash.assign'

export class TenderingCriterion { 
    public constructor(init?:Partial<TenderingCriterion>) {
        assign(this, init)
    } 
    
    
    id?: IdentifierType
    criterionTypeCode?: CodeType
    name?: string
    description?: string[]
    weightNumeric?: number
    evaluationMethodTypeCode?: CodeType
    weightingConsiderationDescription?: string
    subTenderingTenderingCriteria?: TenderingCriterion[]
    legislations?: Legislation[]
    tenderingCriterionPropertyGroups?: TenderingCriterionPropertyGroup[]
    fulfilmentIndicatorType?: boolean
    fulfilmentIndicatorTypeCodeType?: string
}