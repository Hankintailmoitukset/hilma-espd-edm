/**
 * This is a TypeGen auto-generated file.
 * Any changes made to this file can be lost when this file is regenerated.
 */

import { IdentifierType } from "./identifier-type";
import { NameType } from "./name-type";
import { TextType } from "./text-type";
import { CodeType } from "./code-type";
import { NumericType } from "./numeric-type";
import { PeriodType } from "./period-type";
import { EvidenceType } from "./evidence-type";

export class TenderingCriterionProperty {
    id: IdentifierType;
    name: NameType;
    description: TextType;
    typeCode: CodeType;
    valueDataTypeCode: CodeType;
    valueUnitCode: CodeType;
    valueCurrencyCode: CodeType;
    expectedAmount: number;
    expectedID: IdentifierType;
    expectedCode: CodeType;
    expectedValueNumeric: NumericType;
    expectedDescription: string;
    maximumAmount: string;
    minimumAmount: string;
    maximumValueNumeric: NumericType;
    minimumValueNumeric: NumericType;
    translationTypeCode: string;
    certificationLevelDescription: TextType[];
    copyQualityTypeCode: CodeType;
    applicablePeriod: PeriodType[];
    templateEvidence: EvidenceType[];
}
