import { CodeType } from './CodeType'
import assign from 'lodash.assign'

interface RequiredArgsCommodityClassification {
}

export class CommodityClassification {
  public constructor(init?:Partial<CommodityClassification> & RequiredArgsCommodityClassification) {
    assign(this, init)
  }
  public itemClassificationCode?: CodeType
  
}
