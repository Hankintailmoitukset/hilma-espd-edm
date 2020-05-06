


import { CodeType } from './CodeType'

import assign from 'lodash.assign'

export class CountryType { 
    public constructor(init?:Partial<CountryType>) {
        assign(this, init)
    } 
    
    
    identificationCode?: CodeType
    name?: string
}