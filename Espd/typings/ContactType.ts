



import assign from 'lodash.assign'

export class ContactType { 
    public constructor(init?:Partial<ContactType>) {
        assign(this, init)
    } 
    
    
    name?: string
    telephone?: string
    telefax?: string
    electronicMail?: string
}