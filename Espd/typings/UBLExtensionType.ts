


import { IdentifierType } from './IdentifierType'
import { NameType } from './NameType'
import { CodeType } from './CodeType'
import { TextType } from './TextType'

import assign from 'lodash.assign'

export class UBLExtensionType { 
    public constructor(init?:Partial<UBLExtensionType>) {
        assign(this, init)
    } 
    
    
    id?: IdentifierType
    name?: NameType
    extensionAgencyID?: IdentifierType
    extensionAgencyName?: NameType
    extensionVersionID?: IdentifierType
    extensionAgencyURI?: IdentifierType
    extensionReasonCode?: CodeType
    extensionReason?: TextType
    extensionContent?: any
}