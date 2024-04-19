import { CodeType } from './CodeType'
import assign from 'lodash.assign'

interface RequiredArgsClassificationCategory {
}

export class ClassificationCategory {
  public constructor(init?:Partial<ClassificationCategory> & RequiredArgsClassificationCategory) {
    assign(this, init)
  }
  public name?: string
  public codeValue?: CodeType
  public description?: string[]
  public categorizesClassificationCategories?: ClassificationCategory[]
  
}
