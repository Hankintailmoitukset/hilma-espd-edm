import { IdentifierType } from './IdentifierType'
import { CodeType } from './CodeType'
import { Party } from './Party'
import assign from 'lodash.assign'

interface RequiredArgsServiceProviderParty {
  party: Party
}

export class ServiceProviderParty {
  public constructor(init?:Partial<ServiceProviderParty> & RequiredArgsServiceProviderParty) {
    assign(this, init)
  }
  public id?: IdentifierType
  public serviceProviderTypeCode?: CodeType
  public serviceType?: string[]
  public party!: Party
  
}
