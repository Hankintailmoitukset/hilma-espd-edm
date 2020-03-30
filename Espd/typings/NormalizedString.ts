


import assign from 'lodash.assign'

export class NormalizedString {
    public constructor(init?:Partial<NormalizedString>) {
        assign(this, init)
    }
    
    
    value: string = ''
}
 
