


import { IdentifierType } from './IdentifierType'
import { CodeType } from './CodeType'
import { NameType } from './NameType'
import { TextType } from './TextType'
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
    name?: NameType
    description?: TextType[]
    weightNumeric?: DecimalType
    evaluationMethodTypeCode?: CodeType
    weightingConsiderationDescription?: TextType
    subTenderingTenderingCriteria?: TenderingCriterion[]
    legislations?: Legislation[]
    tenderingCriterionPropertyGroups?: TenderingCriterionPropertyGroup[]
    fulfilmentIndicatorType?: boolean
    fulfilmentIndicatorTypeCodeType?: NormalizedString
}