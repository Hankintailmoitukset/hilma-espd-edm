import { IdentifierType } from './IdentifierType'
import { CodeType } from './CodeType'
import { Country } from './Country'
import { LocationCoordinate } from './LocationCoordinate'
import assign from 'lodash.assign'

interface RequiredArgsAddress {
  country: Country
}

export class Address {
  public constructor(init?:Partial<Address> & RequiredArgsAddress) {
    assign(this, init)
  }
  public id?: IdentifierType
  public addressTypeCode?: CodeType
  public addressFormatCode?: CodeType
  public postbox?: string
  public floor?: string
  public room?: string
  public streetName?: string
  public additionalStreetName?: string
  public blockName?: string
  public buildingName?: string
  public buildingNumber?: string
  public inhouseMail?: string
  public department?: string
  public markAttention?: string
  public markCare?: string
  public plotIdentification?: string
  public citySubdivisionName?: string
  public cityName?: string
  public postalZone?: string
  public countrySubentity?: string
  public countrySubentityCode?: CodeType
  public region?: string
  public district?: string
  public timezoneOffset?: string
  public addressLines?: string[]
  public country!: Country
  public locationCoordinates?: LocationCoordinate[]
  
}
