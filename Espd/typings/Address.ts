


import { IdentifierType } from './IdentifierType'
import { CodeType } from './CodeType'
import { Country } from './Country'
import { LocationCoordinate } from './LocationCoordinate'
import { Contact } from './Contact'

import assign from 'lodash.assign'

export class Address { 
    public constructor(init?:Partial<Address>) {
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
    country?: Country
    locationCoordinates?: LocationCoordinate[]
    contact?: Contact
}
