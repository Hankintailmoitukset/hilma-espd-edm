



import assign from 'lodash.assign'

export class DecimalType { 
    public constructor(init?:Partial<DecimalType>) {
        assign(this, init)
    } 
    
    
    value?: number
}