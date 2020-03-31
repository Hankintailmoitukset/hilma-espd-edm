


import { NameType } from './NameType'

import assign from 'lodash.assign'

export class PartyNameType { 
    public constructor(init?:Partial<PartyNameType>) {
        assign(this, init)
    } 
    
    
    name: NameType = new NameType()
}