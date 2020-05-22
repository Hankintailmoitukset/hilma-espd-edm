



import assign from 'lodash.assign'

export class PeriodType { 
    public constructor(init?:Partial<PeriodType>) {
        assign(this, init)
    } 
    
    
    startDate?: Date
    endDate?: Date
}