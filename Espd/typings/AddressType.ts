

import { IdentifierType } from './IdentifierType'
import { TextType } from './TextType'
import { NameType } from './NameType'
import { CountryType } from './CountryType'
import { LocationCoordinateType } from './LocationCoordinateType'
import { ContactType } from './ContactType'

import assign from 'lodash.assign'

export class AddressType {
    public constructor(init?:Partial<AddressType>) {
        assign(this, init)
    }
    
    
    id: IdentifierType = new IdentifierType()
    addressTypeCode: CodeType | undefined
    addressFormatCode: CodeType | undefined
    postbox: TextType = new TextType()
    floor: TextType = new TextType()
    room: TextType = new TextType()
    streetName: NameType = new NameType()
    additionalStreetName: NameType = new NameType()
    blockName: NameType = new NameType()
    buildingName: NameType = new NameType()
    buildingNumber: TextType = new TextType()
    inhouseMail: TextType = new TextType()
    department: TextType = new TextType()
    markAttention: TextType = new TextType()
    markCare: TextType = new TextType()
    plotIdentification: TextType = new TextType()
    citySubdivisionName: NameType = new NameType()
    cityName: NameType = new NameType()
    postalZone: TextType = new TextType()
    countrySubentity: TextType = new TextType()
    countrySubentityCode: CodeType | undefined
    region: TextType = new TextType()
    district: TextType = new TextType()
    timezoneOffset: TextType = new TextType()
    addressLines: TextType[] = []
    country: CountryType = new CountryType()
    locationCoordinates: LocationCoordinateType[] = []
    contact: ContactType = new ContactType()
}
 
