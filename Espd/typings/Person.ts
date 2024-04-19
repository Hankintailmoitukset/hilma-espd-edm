import { DateType } from './DateType'
import { Contact } from './Contact'
import { Address } from './Address'
import assign from 'lodash.assign'

interface RequiredArgsPerson {
}

export class Person {
  public constructor(init?:Partial<Person> & RequiredArgsPerson) {
    assign(this, init)
  }
  public firstName?: string
  public familyName?: string
  public birthDate?: DateType
  public birthPlaceName?: string
  public contact?: Contact
  public residenceAddress?: Address
  
}
