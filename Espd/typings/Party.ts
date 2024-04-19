import { CodeType } from './CodeType'
import { PartyIdentification } from './PartyIdentification'
import { IdentifierType } from './IdentifierType'
import { PartyName } from './PartyName'
import { Address } from './Address'
import { Contact } from './Contact'
import { Person } from './Person'
import { ServiceProviderParty } from './ServiceProviderParty'
import { PowerOfAttorney } from './PowerOfAttorney'
import assign from 'lodash.assign'

interface RequiredArgsParty {
}

export class Party {
  public constructor(init?:Partial<Party> & RequiredArgsParty) {
    assign(this, init)
  }
  public industryClassificationCode?: CodeType
  public partyIdentification?: PartyIdentification
  public websiteURI?: IdentifierType
  public endpointID?: IdentifierType
  public partyName?: PartyName
  public postalAddress?: Address
  public contact?: Contact
  public person?: Person
  public serviceProviderParty?: ServiceProviderParty
  public powerOfAttorneys?: PowerOfAttorney[]
  public agentParty?: Party
  
}
