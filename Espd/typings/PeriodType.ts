


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
    
    
    startDate?: DateType
    startTime?: TimeType
    endDate?: DateType
    endTime?: TimeType
    durationMeasure?: MeasureType
    descriptionCode?: CodeType[]
    descriptions?: TextType[]
}