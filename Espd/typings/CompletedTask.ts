import assign from 'lodash.assign'

export class CompletedTask { 
    public constructor(init?:Partial<CompletedTask>) {
        assign(this, init)
    } 
    
    
    description?: string
}
