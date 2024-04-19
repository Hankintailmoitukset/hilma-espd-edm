import { IdentifierType } from './IdentifierType'
import assign from 'lodash.assign'

interface RequiredArgsPartyIdentification {
}

export class PartyIdentification {
  public constructor(init?:Partial<PartyIdentification> & RequiredArgsPartyIdentification) {
    assign(this, init)
  }
  public id?: IdentifierType
  
}
