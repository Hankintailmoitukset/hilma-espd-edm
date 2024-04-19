import { IdentifierType } from './IdentifierType'
import { ClassificationCategory } from './ClassificationCategory'
import assign from 'lodash.assign'

interface RequiredArgsBusinessClassificationScheme {
}

export class BusinessClassificationScheme {
  public constructor(init?:Partial<BusinessClassificationScheme> & RequiredArgsBusinessClassificationScheme) {
    assign(this, init)
  }
  public id?: IdentifierType
  public description?: string[]
  public classificationCategory?: ClassificationCategory
  
}
