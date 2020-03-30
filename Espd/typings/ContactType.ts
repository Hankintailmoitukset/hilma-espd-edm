

import { NameType } from './NameType'
import { TextType } from './TextType'

import assign from 'lodash.assign'

export class ContactType {
    public constructor(init?:Partial<ContactType>) {
        assign(this, init)
    } 
    
    
    name: NameType = new NameType()
    telephone: TextType = new TextType()
    telefax: TextType = new TextType()
    electronicMail: TextType = new TextType()
}