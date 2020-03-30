

import { IdentifierType } from './IdentifierType'
import { NameType } from './NameType'
import { CodeType } from './CodeType'
import { TextType } from './TextType'

import assign from 'lodash.assign'

export class UBLExtensionType {
    public constructor(init?:Partial<UBLExtensionType>) {
        assign(this, init)
    } 
    
    
    id: IdentifierType = new IdentifierType()
    name: NameType = new NameType()
    extensionAgencyID: IdentifierType = new IdentifierType()
    extensionAgencyName: NameType = new NameType()
    extensionVersionID: IdentifierType = new IdentifierType()
    extensionAgencyURI: IdentifierType = new IdentifierType()
    extensionReasonCode: CodeType = new CodeType()
    extensionReason: TextType = new TextType()
    extensionContent: any | undefined
}