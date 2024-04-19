import assign from 'lodash.assign'

export class Period { 
    public constructor(init?:Partial<Period>) {
        assign(this, init)
    } 
    
    
    startDate?: Date
    endDate?: Date
}
