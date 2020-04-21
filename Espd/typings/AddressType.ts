


import { IdentifierType } from './IdentifierType'
import { CodeType } from './CodeType'
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
    postbox?: string
    floor?: string
    room?: string
    streetName?: string
    additionalStreetName?: string
    blockName?: string
    buildingName?: string
    buildingNumber?: string
    inhouseMail?: string
    department?: string
    markAttention?: string
    markCare?: string
    plotIdentification?: string
    citySubdivisionName?: string
    cityName?: string
    postalZone?: string
    countrySubentity?: string
    countrySubentityCode?: CodeType
    region?: string
    district?: string
    timezoneOffset?: string
    addressLines?: string[]
    country?: CountryType
    locationCoordinates?: LocationCoordinateType[]
    contact?: ContactType
}