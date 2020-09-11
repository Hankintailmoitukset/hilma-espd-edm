



import assign from 'lodash.assign'

export class MeasureType { 
    public constructor(init?:Partial<MeasureType>) {
        assign(this, init)
    } 
    
    value?: number
    
    unitCode?: string
    unitCodeListID?: string
    unitCodeListAgencyName?: string
}
