



import assign from 'lodash.assign'

export class DateTimeType { 
    public constructor(init?:Partial<DateTimeType>) {
        assign(this, init)
    } 
    
    
    value: Date | undefined
}