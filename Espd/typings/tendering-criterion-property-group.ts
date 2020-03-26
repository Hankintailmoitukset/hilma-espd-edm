/**
 * This is a TypeGen auto-generated file.
 * Any changes made to this file can be lost when this file is regenerated.
 */

import { IdentifierType } from "./identifier-type";
import { NameType } from "./name-type";
import { TextType } from "./text-type";
import { CodeType } from "./code-type";
import { TenderingCriterionProperty } from "./tendering-criterion-property";

export class TenderingCriterionPropertyGroup {
    id: IdentifierType;
    name: NameType[];
    description: TextType[];
    propertyGroupTypeCode: CodeType;
    fulfilmentIndicatorTypeCode: CodeType;
    tenderingCriterionProperties: TenderingCriterionProperty[];
    subsidiaryTenderingCriterionPropertyGroups: TenderingCriterionPropertyGroup[];
}
