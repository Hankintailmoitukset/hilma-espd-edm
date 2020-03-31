


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
    
    
    id: IdentifierType = new IdentifierType()
    name: NameType = new NameType()
    description: TextType = new TextType()
    typeCode: CodeType = new CodeType()
    valueDataTypeCode: CodeType = new CodeType()
    valueUnitCode: CodeType = new CodeType()
    valueCurrencyCode: CodeType = new CodeType()
    expectedAmount: number | null = null
    expectedID: IdentifierType = new IdentifierType()
    expectedCode: CodeType = new CodeType()
    expectedValueNumeric: NumericType = new NumericType()
    expectedDescription: string = ''
    maximumAmount: string = ''
    minimumAmount: string = ''
    maximumValueNumeric: NumericType = new NumericType()
    minimumValueNumeric: NumericType = new NumericType()
    translationTypeCode: string = ''
    certificationLevelDescription: TextType[] = []
    copyQualityTypeCode: CodeType = new CodeType()
    applicablePeriod: PeriodType[] = []
    templateEvidence: EvidenceType[] = []
}