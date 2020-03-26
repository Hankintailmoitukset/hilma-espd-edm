/**
 * This is a TypeGen auto-generated file.
 * Any changes made to this file can be lost when this file is regenerated.
 */

import { IdentifierType } from "./identifier-type";
import { DateType } from "./date-type";
import { TimeType } from "./time-type";
import { CodeType } from "./code-type";
import { TextType } from "./text-type";
import { AttachmentType } from "./attachment-type";
import { PeriodType } from "./period-type";
import { PartyType } from "./party-type";
import { ResultOfVerificationType } from "./result-of-verification-type";

export class DocumentReferenceType {
    iD: IdentifierType;
    copyIndicator: boolean;
    uUID: IdentifierType;
    issueDate: DateType;
    issueTime: TimeType;
    documentTypeCode: CodeType;
    documentType: TextType;
    xPath: TextType[];
    languageID: IdentifierType;
    localeCode: CodeType;
    versionID: IdentifierType;
    documentStatusCode: CodeType;
    documentDescription: TextType[];
    attachment: AttachmentType;
    validityPeriod: PeriodType;
    issuerParty: PartyType;
    resultOfVerification: ResultOfVerificationType;
}
