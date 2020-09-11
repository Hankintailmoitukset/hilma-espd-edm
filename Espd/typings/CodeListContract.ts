


import { CodeContract } from './CodeContract'

import assign from 'lodash.assign'

export class CodeListContract { 
    public constructor(init?:Partial<CodeListContract>) {
        assign(this, init)
    } 
    
    
    shortName?: string
    longName?: string
    codes?: CodeContract[]
    agencyId?: string
    version?: string
}
