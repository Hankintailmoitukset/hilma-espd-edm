


import { UBLExtensionType } from './UBLExtensionType'
import { IdentifierType } from './IdentifierType'
import { DateType } from './DateType'
import { TimeType } from './TimeType'
import { CodeType } from './CodeType'
import { TextType } from './TextType'
import { ContractingParty } from './ContractingParty'
import { ProcurementProject } from './ProcurementProject'
import { ProcurementProjectLot } from './ProcurementProjectLot'
import { TenderingCriterion } from './TenderingCriterion'
import { AdditionalDocumentReference } from './AdditionalDocumentReference'

import assign from 'lodash.assign'

export class QualificationApplicationRequest { 
    public constructor(init?:Partial<QualificationApplicationRequest>) {
        assign(this, init)
    } 
    
    
    ublExtensions: UBLExtensionType[] = []
    ulbVersionID: IdentifierType = new IdentifierType()
    customizationID: IdentifierType = new IdentifierType()
    profileID: IdentifierType = new IdentifierType()
    profileExecutionID: IdentifierType = new IdentifierType()
    id: IdentifierType = new IdentifierType()
    copyIndicator: boolean = false
    uuid: IdentifierType = new IdentifierType()
    contractFolderID: IdentifierType = new IdentifierType()
    issueDate: DateType = new DateType()
    issueTime: TimeType = new TimeType()
    versionID: IdentifierType = new IdentifierType()
    previousVersionID: IdentifierType = new IdentifierType()
    procedureCode: CodeType = new CodeType()
    qualificationApplicationTypeCode: CodeType = new CodeType()
    weightScoringMethodologyNote: TextType[] = []
    weightingTypeCode: CodeType = new CodeType()
    contractingParty: ContractingParty = new ContractingParty()
    procurementProject: ProcurementProject = new ProcurementProject()
    procurementProjectLots: ProcurementProjectLot[] = []
    tenderingCriteria: TenderingCriterion[] = []
    additionalDocumentReferences: AdditionalDocumentReference[] = []
}