import { IdentifierType } from './IdentifierType'
import { CodeType } from './CodeType'
import { ResponseValue } from './ResponseValue'
import { Period } from './Period'
import { EvidenceSupplied } from './EvidenceSupplied'
import assign from 'lodash.assign'

interface RequiredArgsTenderingCriterionResponse {
  validatedCriterionPropertyID: IdentifierType
}

export class TenderingCriterionResponse {
  public constructor(init?:Partial<TenderingCriterionResponse> & RequiredArgsTenderingCriterionResponse) {
    assign(this, init)
  }
  public id?: IdentifierType
  public validatedCriterionPropertyID!: IdentifierType
  public confidentialityLevelCode?: CodeType
  public responseValue?: ResponseValue[]
  public applicablePeriod?: Period
  public evidenceSupplied?: EvidenceSupplied
  
}
