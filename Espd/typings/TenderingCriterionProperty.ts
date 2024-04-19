import { IdentifierType } from './IdentifierType'
import { CodeType } from './CodeType'
import { AmountType } from './AmountType'
import { Period } from './Period'
import { Evidence } from './Evidence'
import assign from 'lodash.assign'

interface RequiredArgsTenderingCriterionProperty {
  id: IdentifierType
  typeCode: CodeType
  valueDataTypeCode: CodeType
}

export class TenderingCriterionProperty {
  public constructor(init?:Partial<TenderingCriterionProperty> & RequiredArgsTenderingCriterionProperty) {
    assign(this, init)
  }
  public _cardinality?: string
  public id!: IdentifierType
  public name?: string
  public description?: string
  public typeCode!: CodeType
  public valueDataTypeCode!: CodeType
  public valueUnitCode?: CodeType
  public valueCurrencyCode?: CodeType
  public expectedAmount?: AmountType
  public expectedID?: IdentifierType
  public expectedCode?: CodeType
  public expectedValueNumeric?: number | null
  public expectedDescription?: string
  public maximumAmount?: AmountType
  public minimumAmount?: AmountType
  public maximumValueNumeric?: number | null
  public minimumValueNumeric?: number | null
  public translationTypeCode?: string
  public certificationLevelDescription?: string[]
  public copyQualityTypeCode?: CodeType
  public applicablePeriod?: Period
  public templateEvidence?: Evidence[]
  public codeListId?: string
  
}
