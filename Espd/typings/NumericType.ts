



import assign from 'lodash.assign'

export class NumericType { 
    public constructor(init?:Partial<NumericType>) {
        assign(this, init)
    } 
    
    value?: number
    
}