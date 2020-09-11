



import assign from 'lodash.assign'

export class BusinessClassificationScheme { 
    public constructor(init?:Partial<BusinessClassificationScheme>) {
        assign(this, init)
    } 
    
    
    description?: string[]
}
