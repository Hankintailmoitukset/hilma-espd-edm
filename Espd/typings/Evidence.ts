import { IdentifierType } from './IdentifierType'
import { CodeType } from './CodeType'
import { Party } from './Party'
import { DocumentReference } from './DocumentReference'
import { Language } from './Language'
import assign from 'lodash.assign'

interface RequiredArgsEvidence {
}

export class Evidence {
  public constructor(init?:Partial<Evidence> & RequiredArgsEvidence) {
    assign(this, init)
  }
  public id?: IdentifierType
  public evidenceTypeCode?: CodeType
  public name?: string
  public description?: string[]
  public candidateStatement?: string[]
  public confidentialityLevelCode?: CodeType
  public evidenceIssuingParty?: Party
  public documentReference?: DocumentReference[]
  public language?: Language
  
}
