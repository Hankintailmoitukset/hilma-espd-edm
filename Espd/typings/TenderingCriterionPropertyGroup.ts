


import { IdentifierType } from './IdentifierType'
import { NameType } from './NameType'
import { TextType } from './TextType'
import { CodeType } from './CodeType'
import { TenderingCriterionProperty } from './TenderingCriterionProperty'

import assign from 'lodash.assign'

export class TenderingCriterionPropertyGroup { 
    public constructor(init?:Partial<TenderingCriterionPropertyGroup>) {
        assign(this, init)
    } 
    
    
    id?: IdentifierType
    name?: NameType
    description?: TextType[]
    propertyGroupTypeCode?: CodeType
    fulfilmentIndicatorTypeCode?: CodeType
    tenderingCriterionProperties?: TenderingCriterionProperty[]
    subsidiaryTenderingCriterionPropertyGroups?: TenderingCriterionPropertyGroup[]
}