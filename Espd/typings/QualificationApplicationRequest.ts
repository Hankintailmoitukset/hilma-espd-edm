import { UBLExtension } from './UBLExtension'
import { IdentifierType } from './IdentifierType'
import { DateType } from './DateType'
import { TimeType } from './TimeType'
import { CodeType } from './CodeType'
import { ContractingParty } from './ContractingParty'
import { ProcurementProject } from './ProcurementProject'
import { ProcurementProjectLot } from './ProcurementProjectLot'
import { TenderingCriterion } from './TenderingCriterion'
import { AdditionalDocumentReference } from './AdditionalDocumentReference'
import assign from 'lodash.assign'

interface RequiredArgsQualificationApplicationRequest {
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

export class QualificationApplicationRequest {
  public constructor(init?:Partial<QualificationApplicationRequest> & RequiredArgsQualificationApplicationRequest) {
    assign(this, init)
  }
  public ublExtensions?: UBLExtension[]
  public ublVersionID!: IdentifierType
  public customizationID!: IdentifierType
  public profileID!: IdentifierType
  public profileExecutionID?: IdentifierType
  public id!: IdentifierType
  public copyIndicator?: boolean | null
  public uuid!: IdentifierType
  public contractFolderID!: IdentifierType
  public issueDate!: DateType
  public issueTime?: TimeType
  public versionID?: IdentifierType
  public previousVersionID?: IdentifierType
  public procedureCode?: CodeType
  public qualificationApplicationTypeCode!: CodeType
  public weightScoringMethodologyNote?: string[]
  public weightingTypeCode?: CodeType
  public contractingParty!: ContractingParty
  public procurementProject!: ProcurementProject
  public procurementProjectLots!: ProcurementProjectLot[]
  public tenderingCriteria!: TenderingCriterion[]
  public additionalDocumentReferences?: AdditionalDocumentReference[]
  public isProcurementDividedIntoLots?: boolean
  
}
