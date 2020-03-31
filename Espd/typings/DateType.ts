



import assign from 'lodash.assign'

export class DateType { 
    public constructor(init?:Partial<DateType>) {
        assign(this, init)
    } 
    
    
    value: Date | undefined
}