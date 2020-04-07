


import { IdentifierType } from './IdentifierType'
import { CodeType } from './CodeType'
import { DecimalType } from './DecimalType'
import { Legislation } from './Legislation'
import { TenderingCriterionPropertyGroup } from './TenderingCriterionPropertyGroup'
import { NormalizedString } from './NormalizedString'

import assign from 'lodash.assign'

export class TenderingCriterion { 
    public constructor(init?:Partial<TenderingCriterion>) {
        assign(this, init)
    } 
    
    
    id?: IdentifierType
    criterionTypeCode?: CodeType
    name?: string
    description?: string[]
    weightNumeric?: DecimalType
    evaluationMethodTypeCode?: CodeType
    weightingConsiderationDescription?: string
    subTenderingTenderingCriteria?: TenderingCriterion[]
    legislations?: Legislation[]
    tenderingCriterionPropertyGroups?: TenderingCriterionPropertyGroup[]
    fulfilmentIndicatorType?: boolean
    fulfilmentIndicatorTypeCodeType?: NormalizedString
}