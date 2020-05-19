


import { IdentifierType } from './IdentifierType'
import { CodeType } from './CodeType'
import { NumericType } from './NumericType'
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
    value?: any
    typeCode?: CodeType
    valueDataTypeCode?: CodeType
    valueUnitCode?: CodeType
    valueCurrencyCode?: CodeType
    expectedAmount?: number
    expectedID?: IdentifierType
    expectedCode?: CodeType
    expectedValueNumeric?: NumericType
    expectedDescription?: string
    maximumAmount?: string
    minimumAmount?: string
    maximumValueNumeric?: NumericType
    minimumValueNumeric?: NumericType
    translationTypeCode?: string
    certificationLevelDescription?: string[]
    copyQualityTypeCode?: CodeType
    applicablePeriod?: PeriodType[]
    templateEvidence?: EvidenceType[]
}