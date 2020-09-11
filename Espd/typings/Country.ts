


import { CodeType } from './CodeType'

import assign from 'lodash.assign'

export class Country { 
    public constructor(init?:Partial<Country>) {
        assign(this, init)
    } 
    
    
    identificationCode?: CodeType
    name?: string
}
