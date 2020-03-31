


import { NameType } from './NameType'
import { TextType } from './TextType'

import assign from 'lodash.assign'

export class ContactType { 
    public constructor(init?:Partial<ContactType>) {
        assign(this, init)
    } 
    
    
    name?: NameType
    telephone?: TextType
    telefax?: TextType
    electronicMail?: TextType
}