/**
 * This is a TypeGen auto-generated file.
 * Any changes made to this file can be lost when this file is regenerated.
 */

import { TextType } from "./text-type";
import { CodeType } from "./code-type";
import { CommodityClassificationType } from "./commodity-classification-type";

export class ProcurementProject {
    name: TextType;
    description: TextType;
    procurementTypeCode: CodeType;
    mainCommodityClassifications: CommodityClassificationType[];
}
