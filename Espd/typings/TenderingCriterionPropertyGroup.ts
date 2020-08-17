


import { IdentifierType } from './IdentifierType'
import { CodeType } from './CodeType'
import { TenderingCriterionProperty } from './TenderingCriterionProperty'

import assign from 'lodash.assign'

export class TenderingCriterionPropertyGroup { 
    public constructor(init?:Partial<TenderingCriterionPropertyGroup>) {
        assign(this, init)
    } 
    
    
    _cardinality?: string
    _maxOccurrence?: number
    id?: IdentifierType
    description?: string[]
    propertyGroupTypeCode?: CodeType
    fulfilmentIndicatorTypeCode?: CodeType
    tenderingCriterionProperties?: TenderingCriterionProperty[]
    subsidiaryTenderingCriterionPropertyGroups?: TenderingCriterionPropertyGroup[]
}