/**
 * This is a TypeGen auto-generated file.
 * Any changes made to this file can be lost when this file is regenerated.
 */

import { DateType } from "./date-type";
import { TimeType } from "./time-type";
import { MeasureType } from "./measure-type";
import { CodeType } from "./code-type";
import { TextType } from "./text-type";

export class PeriodType {
    startDate: DateType;
    startTime: TimeType;
    endDate: DateType;
    endTime: TimeType;
    durationMeasure: MeasureType;
    descriptionCode: CodeType[];
    descriptions: TextType[];
}
