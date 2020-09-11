


import { IdentifierType } from './IdentifierType'
import { CodeType } from './CodeType'
import { Legislation } from './Legislation'
import { TenderingCriterionPropertyGroup } from './TenderingCriterionPropertyGroup'
import { ContractType } from './ContractType'

import assign from 'lodash.assign'

export class TenderingCriterion { 
    public constructor(init?:Partial<TenderingCriterion>) {
        assign(this, init)
    } 
    
    
    _mandatory?: boolean
    id?: IdentifierType
    criterionTypeCode?: CodeType
    name?: string
    description?: string[]
    weightNumeric?: number
    evaluationMethodTypeCode?: CodeType
    weightingConsiderationDescription?: string
    subTenderingCriteria?: TenderingCriterion[]
    legislations?: Legislation[]
    tenderingCriterionPropertyGroups?: TenderingCriterionPropertyGroup[]
    fulfilmentIndicator?: boolean
    fulfilmentIndicatorTypeCode?: string
    applicableContractType?: ContractType
}
