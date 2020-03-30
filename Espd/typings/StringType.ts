


import assign from 'lodash.assign'

export class StringType {
    public constructor(init?:Partial<StringType>) {
        assign(this, init)
    }
    
    
    value: string = ''
}
 
