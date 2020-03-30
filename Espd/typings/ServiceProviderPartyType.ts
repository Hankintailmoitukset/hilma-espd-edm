import assign from 'lodash.assign'

export class ServiceProviderPartyType {
    public constructor(init?:Partial<ServiceProviderPartyType>) {
        assign(this, init)
    }
    
    
    id: IdentifierType | undefined
    serviceProviderTypeCode: CodeType | undefined
    serviceType: TextType[] = []
    party: PartyType | undefined
}