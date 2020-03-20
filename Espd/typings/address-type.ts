/**
 * This is a TypeGen auto-generated file.
 * Any changes made to this file can be lost when this file is regenerated.
 */

import { IdentifierType } from "./identifier-type";
import { CodeType } from "./code-type";
import { TextType } from "./text-type";
import { NameType } from "./name-type";
import { CountryType } from "./country-type";
import { LocationCoordinateType } from "./location-coordinate-type";
import { ContactType } from "./contact-type";

export class AddressType {
    iD: IdentifierType;
    addressTypeCode: CodeType;
    addressFormatCode: CodeType;
    postbox: TextType;
    floor: TextType;
    room: TextType;
    streetName: NameType;
    additionalStreetName: NameType;
    blockName: NameType;
    buildingName: NameType;
    buildingNumber: TextType;
    inhouseMail: TextType;
    department: TextType;
    markAttention: TextType;
    markCare: TextType;
    plotIdentification: TextType;
    citySubdivisionName: NameType;
    cityName: NameType;
    postalZone: TextType;
    countrySubentity: TextType;
    countrySubentityCode: CodeType;
    region: TextType;
    district: TextType;
    timezoneOffset: TextType;
    addressLines: TextType[];
    country: CountryType;
    locationCoordinates: LocationCoordinateType[];
    contact: ContactType;
}
