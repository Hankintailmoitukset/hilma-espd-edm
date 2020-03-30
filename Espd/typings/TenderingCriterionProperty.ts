

import { IdentifierType } from './IdentifierType'
import { NameType } from './NameType'
import { TextType } from './TextType'
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
    typeCode: CodeType | undefined
    valueDataTypeCode: CodeType | undefined
    valueUnitCode: CodeType | undefined
    valueCurrencyCode: CodeType | undefined
    expectedAmount: number | null = null
    expectedID: IdentifierType = new IdentifierType()
    expectedCode: CodeType | undefined
    expectedValueNumeric: NumericType = new NumericType()
    expectedDescription: string = ''
    maximumAmount: string = ''
    minimumAmount: string = ''
    maximumValueNumeric: NumericType = new NumericType()
    minimumValueNumeric: NumericType = new NumericType()
    translationTypeCode: string = ''
    certificationLevelDescription: TextType[] = []
    copyQualityTypeCode: CodeType | undefined
    applicablePeriod: PeriodType[] = []
    templateEvidence: EvidenceType[] = []
}
 
