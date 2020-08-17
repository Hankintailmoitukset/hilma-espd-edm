



import assign from 'lodash.assign'

export class PartyName { 
    public constructor(init?:Partial<PartyName>) {
        assign(this, init)
    } 
    
    
    name?: string
}