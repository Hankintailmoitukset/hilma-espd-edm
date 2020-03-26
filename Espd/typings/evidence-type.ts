/**
 * This is a TypeGen auto-generated file.
 * Any changes made to this file can be lost when this file is regenerated.
 */

import { IdentifierType } from "./identifier-type";
import { CodeType } from "./code-type";
import { NameType } from "./name-type";
import { TextType } from "./text-type";
import { PartyType } from "./party-type";
import { DocumentReferenceType } from "./document-reference-type";
import { LanguageType } from "./language-type";

export class EvidenceType {
    iD: IdentifierType;
    evidenceTypeCode: CodeType;
    name: NameType;
    description: TextType[];
    candidateStatement: TextType[];
    confidentialityLevelCode: CodeType;
    evidenceIssuingParty: PartyType;
    documentReference: DocumentReferenceType[];
    language: LanguageType;
}
