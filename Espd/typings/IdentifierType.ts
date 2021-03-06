﻿



import assign from 'lodash.assign'

export class IdentifierType { 
    public constructor(init?:Partial<IdentifierType>) {
        assign(this, init)
    } 
    
    value?: string
    
    schemeID?: string
    schemeName?: string
    schemeAgencyID?: string
    schemeAgencyName?: string
    schemeVersionID?: string
    schemeDataURI?: string
    schemeURI?: string
}
