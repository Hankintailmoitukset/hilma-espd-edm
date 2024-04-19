import assign from 'lodash.assign'

interface RequiredArgsContact {
}

export class Contact {
  public constructor(init?:Partial<Contact> & RequiredArgsContact) {
    assign(this, init)
  }
  public name?: string
  public telephone?: string
  public telefax?: string
  public electronicMail?: string
  
}
