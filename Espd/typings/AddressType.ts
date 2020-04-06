


import { IdentifierType } from './IdentifierType'
import { CodeType } from './CodeType'
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
    
    
    id?: IdentifierType
    addressTypeCode?: CodeType
    addressFormatCode?: CodeType
    postbox?: TextType
    floor?: TextType
    room?: TextType
    streetName?: NameType
    additionalStreetName?: NameType
    blockName?: NameType
    buildingName?: NameType
    buildingNumber?: TextType
    inhouseMail?: TextType
    department?: TextType
    markAttention?: TextType
    markCare?: TextType
    plotIdentification?: TextType
    citySubdivisionName?: NameType
    cityName?: NameType
    postalZone?: TextType
    countrySubentity?: TextType
    countrySubentityCode?: CodeType
    region?: TextType
    district?: TextType
    timezoneOffset?: TextType
    addressLines?: TextType[]
    country?: CountryType
    locationCoordinates?: LocationCoordinateType[]
    contact?: ContactType
}