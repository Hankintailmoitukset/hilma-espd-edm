import { IdentifierType } from './IdentifierType'
import assign from 'lodash.assign'

export class PartyIdentification { 
    public constructor(init?:Partial<PartyIdentification>) {
        assign(this, init)
    } 
    
    
    id?: IdentifierType
}
