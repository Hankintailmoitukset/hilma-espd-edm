



import assign from 'lodash.assign'

export class Contact { 
    public constructor(init?:Partial<Contact>) {
        assign(this, init)
    } 
    
    
    name?: string
    telephone?: string
    telefax?: string
    electronicMail?: string
}