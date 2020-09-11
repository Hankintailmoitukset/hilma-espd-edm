



import assign from 'lodash.assign'

export class QuantityType { 
    public constructor(init?:Partial<QuantityType>) {
        assign(this, init)
    } 
    
    value?: number
    
    unitCode?: string
    unitCodeListID?: string
    unitCodeListAgencyName?: string
}
