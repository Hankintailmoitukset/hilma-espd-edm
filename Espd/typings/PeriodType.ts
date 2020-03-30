

import { DateType } from './DateType'
import { TimeType } from './TimeType'
import { MeasureType } from './MeasureType'
import { CodeType } from './CodeType'
import { TextType } from './TextType'

import assign from 'lodash.assign'

export class PeriodType {
    public constructor(init?:Partial<PeriodType>) {
        assign(this, init)
    } 
    
    
    startDate: DateType = new DateType()
    startTime: TimeType = new TimeType()
    endDate: DateType = new DateType()
    endTime: TimeType = new TimeType()
    durationMeasure: MeasureType = new MeasureType()
    descriptionCode: CodeType[] = []
    descriptions: TextType[] = []
}