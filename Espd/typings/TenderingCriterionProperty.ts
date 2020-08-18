


import { IdentifierType } from './IdentifierType'
import { CodeType } from './CodeType'
import { AmountType } from './AmountType'
import { PeriodType } from './PeriodType'
import { EvidenceType } from './EvidenceType'

import assign from 'lodash.assign'

export class TenderingCriterionProperty { 
    public constructor(init?:Partial<TenderingCriterionProperty>) {
        assign(this, init)
    } 
    
    
    _cardinality?: string
    id?: IdentifierType
    name?: string
    description?: string
    typeCode?: CodeType
    valueDataTypeCode?: CodeType
    valueUnitCode?: CodeType
    valueCurrencyCode?: CodeType
    expectedAmount?: AmountType
    expectedID?: IdentifierType
    expectedCode?: CodeType
    expectedValueNumeric?: number
    expectedDescription?: string
    maximumAmount?: AmountType
    minimumAmount?: AmountType
    maximumValueNumeric?: number
    minimumValueNumeric?: number
    translationTypeCode?: string
    certificationLevelDescription?: string[]
    copyQualityTypeCode?: CodeType
    applicablePeriod?: PeriodType
    templateEvidence?: EvidenceType[]
    codeListId?: string
}