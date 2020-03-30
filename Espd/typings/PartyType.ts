import assign from 'lodash.assign'

export class PartyType {
    public constructor(init?:Partial<PartyType>) {
        assign(this, init)
    }
    
    
    partyIdentification: PartyIdentificationType[] = []
    websiteURI: IdentifierType | undefined
    endpointID: IdentifierType | undefined
    partyName: PartyNameType | undefined
    postalAddress: AddressType | undefined
    contact: ContactType | undefined
    serviceProviderParty: ServiceProviderPartyType | undefined
}