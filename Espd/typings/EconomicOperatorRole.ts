


import { CodeType } from './CodeType'

import assign from 'lodash.assign'

export class EconomicOperatorRole { 
    public constructor(init?:Partial<EconomicOperatorRole>) {
        assign(this, init)
    } 
    
    
    roleCode?: CodeType
    roleDescription?: string[]
}