


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
    
    
    ublExtensions?: UBLExtensionType[]
    ulbVersionID?: IdentifierType
    customizationID?: IdentifierType
    profileID?: IdentifierType
    profileExecutionID?: IdentifierType
    id?: IdentifierType
    copyIndicator?: boolean
    uuid?: IdentifierType
    contractFolderID?: IdentifierType
    issueDate?: DateType
    issueTime?: TimeType
    versionID?: IdentifierType
    previousVersionID?: IdentifierType
    procedureCode?: CodeType
    qualificationApplicationTypeCode?: CodeType
    weightScoringMethodologyNote?: TextType[]
    weightingTypeCode?: CodeType
    contractingParty?: ContractingParty
    procurementProject?: ProcurementProject
    procurementProjectLots?: ProcurementProjectLot[]
    tenderingCriteria?: TenderingCriterion[]
    additionalDocumentReferences?: AdditionalDocumentReference[]
}