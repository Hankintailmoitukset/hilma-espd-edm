


import { IdentifierType } from './IdentifierType'
import { DateType } from './DateType'
import { TimeType } from './TimeType'
import { CodeType } from './CodeType'
import { ContractingParty } from './ContractingParty'
import { ProcurementProject } from './ProcurementProject'
import { ProcurementProjectLot } from './ProcurementProjectLot'
import { TenderingCriterion } from './TenderingCriterion'
import { TenderingCriterionResponse } from './TenderingCriterionResponse'
import { AdditionalDocumentReference } from './AdditionalDocumentReference'
import { EvidenceType } from './EvidenceType'

import assign from 'lodash.assign'

export class QualificationApplicationResponse { 
    public constructor(init?:Partial<QualificationApplicationResponse>) {
        assign(this, init)
    } 
    
    
    ulbVersionID?: IdentifierType
    customizationID?: IdentifierType
    profileID?: IdentifierType
    id?: IdentifierType
    copyIndicator?: boolean
    uuid?: IdentifierType
    contractFolderID?: IdentifierType
    issueDate?: DateType
    issueTime?: TimeType
    economicOperatorGroupName?: CodeType
    versionID?: IdentifierType
    previousVersionID?: IdentifierType
    procedureCode?: CodeType
    qualificationApplicationTypeCode?: CodeType
    weightScoringMethodologyNote?: string[]
    weightingTypeCode?: CodeType
    contractingParty?: ContractingParty
    economicOperatorParty?: EconomicOperatorParty
    procurementProject?: ProcurementProject
    procurementProjectLots?: ProcurementProjectLot[]
    tenderingCriteria?: TenderingCriterion[]
    tenderingCriterionResponses?: TenderingCriterionResponse[]
    additionalDocumentReferences?: AdditionalDocumentReference[]
    evidences?: EvidenceType[]
}