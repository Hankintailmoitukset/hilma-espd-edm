/**
 * This is a TypeGen auto-generated file.
 * Any changes made to this file can be lost when this file is regenerated.
 */

import { IdentifierType } from "./identifier-type";
import { NameType } from "./name-type";
import { CodeType } from "./code-type";
import { TextType } from "./text-type";

export class UBLExtensionType {
    iD: IdentifierType;
    name: NameType;
    extensionAgencyID: IdentifierType;
    extensionAgencyName: NameType;
    extensionVersionID: IdentifierType;
    extensionAgencyURI: IdentifierType;
    extensionReasonCode: CodeType;
    extensionReason: TextType;
    extensionContent: Object;
}
