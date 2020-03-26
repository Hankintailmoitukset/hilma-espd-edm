/**
 * This is a TypeGen auto-generated file.
 * Any changes made to this file can be lost when this file is regenerated.
 */

import { IdentifierType } from "./identifier-type";
import { CodeType } from "./code-type";
import { NameType } from "./name-type";
import { TextType } from "./text-type";
import { DecimalType } from "./decimal-type";
import { Legislation } from "./legislation";
import { TenderingCriterionPropertyGroup } from "./tendering-criterion-property-group";
import { NormalizedString } from "./normalized-string";

export class TenderingCriterion {
    id: IdentifierType;
    criterionTypeCode: CodeType;
    name: NameType;
    description: TextType[];
    weightNumeric: DecimalType;
    evaluationMethodTypeCode: CodeType;
    weightingConsiderationDescription: TextType;
    subTenderingTenderingCriteria: TenderingCriterion[];
    legislations: Legislation[];
    tenderingCriterionPropertyGroups: TenderingCriterionPropertyGroup[] = [];
    fulfilmentIndicatorType: boolean;
    fulfilmentIndicatorTypeCodeType: NormalizedString;
}
