import { IdentifierType } from './IdentifierType'
import { ClassificationCategory } from './ClassificationCategory'
import assign from 'lodash.assign'

export class BusinessClassificationScheme { 
    public constructor(init?:Partial<BusinessClassificationScheme>) {
        assign(this, init)
    } 
    
    
    id?: IdentifierType
    description?: string[]
    classificationCategory?: ClassificationCategory
}
