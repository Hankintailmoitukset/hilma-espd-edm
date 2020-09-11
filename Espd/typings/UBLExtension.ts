


import { IdentifierType } from './IdentifierType'
import { CodeType } from './CodeType'

import assign from 'lodash.assign'

export class UBLExtension { 
    public constructor(init?:Partial<UBLExtension>) {
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
