


import assign from 'lodash.assign'

export class TextType {
    public constructor(init?:Partial<TextType>) {
        assign(this, init)
    } 
    
    value: string = ''
    
}