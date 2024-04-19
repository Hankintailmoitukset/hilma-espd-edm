import assign from 'lodash.assign'

export class TimeType { 
    public constructor(init?:Partial<TimeType>) {
        assign(this, init)
    } 
    
    
    hour?: number
    minute?: number
    second?: number
}
