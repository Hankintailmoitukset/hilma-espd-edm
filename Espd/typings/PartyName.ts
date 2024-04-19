import assign from 'lodash.assign'

interface RequiredArgsPartyName {
}

export class PartyName {
  public constructor(init?:Partial<PartyName> & RequiredArgsPartyName) {
    assign(this, init)
  }
  public name?: string
  
}
