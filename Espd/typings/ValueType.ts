



import assign from 'lodash.assign'

export class ValueType { 
    public constructor(init?:Partial<ValueType>) {
        assign(this, init)
    } 
    
    
}