

import { IdentifierType } from './IdentifierType'
import { TextType } from './TextType'
import { DateType } from './DateType'
import { TimeType } from './TimeType'
import { CodeType } from './CodeType'

import assign from 'lodash.assign'

export class ExternalReferenceType {
    public constructor(init?:Partial<ExternalReferenceType>) {
        assign(this, init)
    } 
    
    
    uri: IdentifierType = new IdentifierType()
    documentHash: TextType = new TextType()
    hashAlgorithmMethod: TextType = new TextType()
    expiryDate: DateType = new DateType()
    expiryTime: TimeType = new TimeType()
    mimeCode: CodeType = new CodeType()
    formatCode: CodeType = new CodeType()
    encodingCode: CodeType = new CodeType()
    characterSetCode: CodeType = new CodeType()
    fileName: TextType = new TextType()
    description: TextType[] = []
}