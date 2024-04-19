import { CodeType } from './CodeType'
import assign from 'lodash.assign'

export class ClassificationCategory { 
    public constructor(init?:Partial<ClassificationCategory>) {
        assign(this, init)
    } 
    
    
    name?: string
    codeValue?: CodeType
    description?: string[]
    categorizesClassificationCategories?: ClassificationCategory[]
}
