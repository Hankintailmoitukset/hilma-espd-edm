import { IdentifierType } from './IdentifierType'
import { DateType } from './DateType'
import { TimeType } from './TimeType'
import { CodeType } from './CodeType'
import { ContractingParty } from './ContractingParty'
import { EconomicOperatorParty } from './EconomicOperatorParty'
import { ProcurementProject } from './ProcurementProject'
import { ProcurementProjectLot } from './ProcurementProjectLot'
import { TenderingCriterion } from './TenderingCriterion'
import { TenderingCriterionResponse } from './TenderingCriterionResponse'
import { AdditionalDocumentReference } from './AdditionalDocumentReference'
import { Evidence } from './Evidence'
import assign from 'lodash.assign'

interface RequiredArgsQualificationApplicationResponse {
  ublVersionID: IdentifierType
  customizationID: IdentifierType
  profileID: IdentifierType
  id: IdentifierType
  uuid: IdentifierType
  contractFolderID: IdentifierType
  issueDate: DateType
  qualificationApplicationTypeCode: CodeType
  contractingParty: ContractingParty
  procurementProject: ProcurementProject
  procurementProjectLots: ProcurementProjectLot[]
  tenderingCriteria: TenderingCriterion[]
}

export class QualificationApplicationResponse {
  public constructor(init?:Partial<QualificationApplicationResponse> & RequiredArgsQualificationApplicationResponse) {
    assign(this, init)
  }
  public ublVersionID!: IdentifierType
  public customizationID!: IdentifierType
  public profileID!: IdentifierType
  public id!: IdentifierType
  public copyIndicator?: boolean | null
  public uuid!: IdentifierType
  public contractFolderID!: IdentifierType
  public issueDate!: DateType
  public issueTime?: TimeType
  public economicOperatorGroupName?: CodeType
  public versionID?: IdentifierType
  public previousVersionID?: IdentifierType
  public procedureCode?: CodeType
  public qualificationApplicationTypeCode!: CodeType
  public weightScoringMethodologyNote?: string[]
  public weightingTypeCode?: CodeType
  public contractingParty!: ContractingParty
  public economicOperatorParty?: EconomicOperatorParty
  public procurementProject!: ProcurementProject
  public procurementProjectLots!: ProcurementProjectLot[]
  public tenderingCriteria!: TenderingCriterion[]
  public tenderingCriterionResponses?: TenderingCriterionResponse[]
  public additionalDocumentReferences?: AdditionalDocumentReference[]
  public evidences?: Evidence[]
  
}
