import { IdentifierType } from './IdentifierType'
import { CodeType } from './CodeType'
import { AmountType } from './AmountType'
import { Period } from './Period'
import { Evidence } from './Evidence'
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
    expectedValueNumeric?: number | null
    expectedDescription?: string
    maximumAmount?: AmountType
    minimumAmount?: AmountType
    maximumValueNumeric?: number | null
    minimumValueNumeric?: number | null
    translationTypeCode?: string
    certificationLevelDescription?: string[]
    copyQualityTypeCode?: CodeType
    applicablePeriod?: Period
    templateEvidence?: Evidence[]
    codeListId?: string
}
