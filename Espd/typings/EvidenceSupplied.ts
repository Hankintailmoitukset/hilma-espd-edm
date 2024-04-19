import { IdentifierType } from './IdentifierType'
import assign from 'lodash.assign'

export class EvidenceSupplied { 
    public constructor(init?:Partial<EvidenceSupplied>) {
        assign(this, init)
    } 
    
    
    id?: IdentifierType
}
