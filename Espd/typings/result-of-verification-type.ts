/**
 * This is a TypeGen auto-generated file.
 * Any changes made to this file can be lost when this file is regenerated.
 */

import { IdentifierType } from "./identifier-type";
import { CodeType } from "./code-type";
import { DateType } from "./date-type";
import { TimeType } from "./time-type";
import { TextType } from "./text-type";
import { PartyType } from "./party-type";

export class ResultOfVerificationType {
    validatorID: IdentifierType;
    validationResultCode: CodeType;
    validationDate: DateType;
    validationTime: TimeType;
    validateProcess: TextType;
    validateTool: TextType;
    validateToolVersion: TextType;
    signatoryParty: PartyType;
}
