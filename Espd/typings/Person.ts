


import { DateType } from './DateType'
import { Contact } from './Contact'
import { Address } from './Address'

import assign from 'lodash.assign'

export class Person { 
    public constructor(init?:Partial<Person>) {
        assign(this, init)
    } 
    
    
    firstName?: string
    lastName?: string
    birthDate?: DateType
    birthPlaceName?: string
    contact?: Contact
    residenceAddress?: Address
}
