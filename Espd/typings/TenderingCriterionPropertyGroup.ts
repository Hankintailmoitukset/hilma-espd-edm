import { IdentifierType } from './IdentifierType'
import { CodeType } from './CodeType'
import { TenderingCriterionProperty } from './TenderingCriterionProperty'
import assign from 'lodash.assign'

interface RequiredArgsTenderingCriterionPropertyGroup {
  propertyGroupTypeCode: CodeType
  tenderingCriterionProperties: TenderingCriterionProperty[]
}

export class TenderingCriterionPropertyGroup {
  public constructor(init?:Partial<TenderingCriterionPropertyGroup> & RequiredArgsTenderingCriterionPropertyGroup) {
    assign(this, init)
  }
  public _cardinality?: string
  public _maxOccurrence?: number | null
  public id?: IdentifierType
  public description?: string[]
  public propertyGroupTypeCode!: CodeType
  public fulfilmentIndicatorTypeCode?: CodeType
  public tenderingCriterionProperties!: TenderingCriterionProperty[]
  public subsidiaryTenderingCriterionPropertyGroups?: TenderingCriterionPropertyGroup[]
  
}
