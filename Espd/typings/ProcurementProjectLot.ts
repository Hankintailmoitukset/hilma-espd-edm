


import { IdentifierType } from './IdentifierType'

import assign from 'lodash.assign'

export class ProcurementProjectLot { 
    public constructor(init?:Partial<ProcurementProjectLot>) {
        assign(this, init)
    } 
    
    
    id?: IdentifierType
}