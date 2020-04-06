


import { IdentifierType } from './IdentifierType'
import { NameType } from './NameType'
import { TextType } from './TextType'
import { CodeType } from './CodeType'
import { NumericType } from './NumericType'
import { PeriodType } from './PeriodType'
import { EvidenceType } from './EvidenceType'

import assign from 'lodash.assign'

export class TenderingCriterionProperty { 
    public constructor(init?:Partial<TenderingCriterionProperty>) {
        assign(this, init)
    } 
    
    
    id?: IdentifierType
    name?: NameType
    description?: TextType
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
    certificationLevelDescription?: TextType[]
    copyQualityTypeCode?: CodeType
    applicablePeriod?: PeriodType[]
    templateEvidence?: EvidenceType[]
}