


import { IdentifierType } from './IdentifierType'

import assign from 'lodash.assign'

export class PartyIdentificationType { 
    public constructor(init?:Partial<PartyIdentificationType>) {
        assign(this, init)
    } 
    
    
    id?: IdentifierType
}