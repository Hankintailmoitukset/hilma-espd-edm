/**
 * This is a TypeGen auto-generated file.
 * Any changes made to this file can be lost when this file is regenerated.
 */

import { UBLExtensionType } from "./ubl-extension-type";
import { IdentifierType } from "./identifier-type";
import { DateType } from "./date-type";
import { TimeType } from "./time-type";
import { CodeType } from "./code-type";
import { TextType } from "./text-type";
import { ContractingParty } from "./contracting-party";
import { ProcurementProject } from "./procurement-project";
import { ProcurementProjectLot } from "./procurement-project-lot";
import { TenderingCriterion } from "./tendering-criterion";
import { AdditionalDocumentReference } from "./additional-document-reference";

export class QualificationApplicationRequest {
    uBLExtensions: UBLExtensionType[];
    uLBVersionID: IdentifierType = {"SchemeID":null,"SchemeName":null,"SchemeAgencyID":"OASIS-UBL-TC","SchemeAgencyName":null,"SchemeVersionID":null,"SchemeDataURI":null,"SchemeURI":null,"Value":"2.2"};
    customizationID: IdentifierType = {"SchemeID":null,"SchemeName":null,"SchemeAgencyID":"CEN-BII","SchemeAgencyName":null,"SchemeVersionID":null,"SchemeDataURI":null,"SchemeURI":null,"Value":"urn:www.cenbii.eu:transaction:biitrdm070:ver3.0"};
    profileID: IdentifierType = {"SchemeID":null,"SchemeName":null,"SchemeAgencyID":"CEN-BII","SchemeAgencyName":null,"SchemeVersionID":null,"SchemeDataURI":null,"SchemeURI":null,"Value":"41"};
    profileExecutionID: IdentifierType;
    iD: IdentifierType;
    copyIndicator: boolean;
    uUID: IdentifierType;
    contractFolderID: IdentifierType;
    issueDate: DateType;
    issueTime: TimeType;
    versionID: IdentifierType;
    previousVersionID: IdentifierType;
    procedureCode: CodeType;
    qualificationApplicationTypeCode: CodeType;
    weightScoringMethodologyNote: TextType[];
    weightingTypeCode: CodeType;
    contractingParty: ContractingParty;
    procurementProject: ProcurementProject;
    procurementProjectLots: ProcurementProjectLot[];
    tenderingCriteria: TenderingCriterion[];
    additionalDocumentReferences: AdditionalDocumentReference[];
}
