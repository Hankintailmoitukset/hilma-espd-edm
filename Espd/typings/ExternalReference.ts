


import { IdentifierType } from './IdentifierType'
import { DateType } from './DateType'
import { TimeType } from './TimeType'
import { CodeType } from './CodeType'

import assign from 'lodash.assign'

export class ExternalReference { 
    public constructor(init?:Partial<ExternalReference>) {
        assign(this, init)
    } 
    
    
    uri?: IdentifierType
    documentHash?: string
    hashAlgorithmMethod?: string
    expiryDate?: DateType
    expiryTime?: TimeType
    mimeCode?: CodeType
    formatCode?: CodeType
    encodingCode?: CodeType
    characterSetCode?: CodeType
    fileName?: string
    description?: string[]
}
