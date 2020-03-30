


import assign from 'lodash.assign'

export class TimeType {
    public constructor(init?:Partial<TimeType>) {
        assign(this, init)
    } 
    
    
    hour: number = 0
    minute: number = 0
    second: number = 0
}