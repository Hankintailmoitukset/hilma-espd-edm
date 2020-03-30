import assign from 'lodash.assign'

export class PeriodType {
    public constructor(init?:Partial<PeriodType>) {
        assign(this, init)
    }
    
    
    startDate: DateType | undefined
    startTime: TimeType | undefined
    endDate: DateType | undefined
    endTime: TimeType | undefined
    durationMeasure: MeasureType | undefined
    descriptionCode: CodeType[] = []
    descriptions: TextType[] = []
}