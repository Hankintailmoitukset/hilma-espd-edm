/**
 * This is a TypeGen auto-generated file.
 * Any changes made to this file can be lost when this file is regenerated.
 */

import { IdentifierType } from "./identifier-type";
import { TextType } from "./text-type";
import { DateType } from "./date-type";
import { TimeType } from "./time-type";
import { CodeType } from "./code-type";

export class ExternalReferenceType {
    uRI: IdentifierType;
    documentHash: TextType;
    hashAlgorithmMethod: TextType;
    expiryDate: DateType;
    expiryTime: TimeType;
    mimeCode: CodeType;
    formatCode: CodeType;
    encodingCode: CodeType;
    characterSetCode: CodeType;
    fileName: TextType;
    description: TextType[];
}
