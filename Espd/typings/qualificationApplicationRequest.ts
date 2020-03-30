import assign from 'lodash.assign'

export class QualificationApplicationRequest {
    public constructor(init?:Partial<QualificationApplicationRequest>) {
        assign(this, init)
    }
    
    
    ublExtensions: UBLExtensionType[] = []
    ulbVersionID: IdentifierType | undefined
    customizationID: IdentifierType | undefined
    profileID: IdentifierType | undefined
    profileExecutionID: IdentifierType | undefined
    id: IdentifierType | undefined
    copyIndicator: boolean = false
    uuid: IdentifierType | undefined
    contractFolderID: IdentifierType | undefined
    issueDate: DateType | undefined
    issueTime: TimeType | undefined
    versionID: IdentifierType | undefined
    previousVersionID: IdentifierType | undefined
    procedureCode: CodeType | undefined
    qualificationApplicationTypeCode: CodeType | undefined
    weightScoringMethodologyNote: TextType[] = []
    weightingTypeCode: CodeType | undefined
    contractingParty: ContractingParty | undefined
    procurementProject: ProcurementProject | undefined
    procurementProjectLots: ProcurementProjectLot[] = []
    tenderingCriteria: TenderingCriterion[] = []
    additionalDocumentReferences: AdditionalDocumentReference[] = []
}