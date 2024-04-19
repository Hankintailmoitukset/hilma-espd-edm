import { IdentifierType } from './IdentifierType'
import { CodeType } from './CodeType'
import { Legislation } from './Legislation'
import { TenderingCriterionPropertyGroup } from './TenderingCriterionPropertyGroup'
import { ContractType } from './ContractType'
import assign from 'lodash.assign'

interface RequiredArgsTenderingCriterion {
  id: IdentifierType
  criterionTypeCode: CodeType
  name: string
  description: string[]
  tenderingCriterionPropertyGroups: TenderingCriterionPropertyGroup[]
}

export class TenderingCriterion {
  public constructor(init?:Partial<TenderingCriterion> & RequiredArgsTenderingCriterion) {
    assign(this, init)
  }
  public _mandatory?: boolean
  public id!: IdentifierType
  public criterionTypeCode!: CodeType
  public name!: string
  public description!: string[]
  public weightNumeric?: number | null
  public evaluationMethodTypeCode?: CodeType
  public weightingConsiderationDescription?: string
  public subTenderingCriteria?: TenderingCriterion[]
  public legislations?: Legislation[]
  public tenderingCriterionPropertyGroups!: TenderingCriterionPropertyGroup[]
  public fulfilmentIndicator?: boolean
  public fulfilmentIndicatorTypeCode?: string
  public applicableContractType?: ContractType
  
}
