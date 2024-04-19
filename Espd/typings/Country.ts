import { CodeType } from './CodeType'
import assign from 'lodash.assign'

interface RequiredArgsCountry {
  identificationCode: CodeType
}

export class Country {
  public constructor(init?:Partial<Country> & RequiredArgsCountry) {
    assign(this, init)
  }
  public identificationCode!: CodeType
  public name?: string
  
}
