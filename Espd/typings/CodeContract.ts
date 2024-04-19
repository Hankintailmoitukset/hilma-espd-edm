import assign from 'lodash.assign'

export class CodeContract { 
    public constructor(init?:Partial<CodeContract>) {
        assign(this, init)
    } 
    
    
    code?: string
    name?: string
}
