import { IdentifierType } from './IdentifierType'
import { CodeType } from './CodeType'
import assign from 'lodash.assign'

interface RequiredArgsLanguage {
  id: IdentifierType
}

export class Language {
  public constructor(init?:Partial<Language> & RequiredArgsLanguage) {
    assign(this, init)
  }
  public id!: IdentifierType
  public name?: string
  public localeCode?: CodeType
  
}
