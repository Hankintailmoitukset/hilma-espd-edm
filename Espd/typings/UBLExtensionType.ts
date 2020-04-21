


import { IdentifierType } from './IdentifierType'
import { CodeType } from './CodeType'

import assign from 'lodash.assign'

export class UBLExtensionType { 
    public constructor(init?:Partial<UBLExtensionType>) {
        assign(this, init)
    } 
    
    
    id?: IdentifierType
    name?: string
    extensionAgencyID?: IdentifierType
    extensionAgencyName?: string
    extensionVersionID?: IdentifierType
    extensionAgencyURI?: IdentifierType
    extensionReasonCode?: CodeType
    extensionReason?: string
    extensionContent?: any
}