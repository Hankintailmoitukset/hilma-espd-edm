import { CodeType } from './CodeType'
import assign from 'lodash.assign'

export class CommodityClassification { 
    public constructor(init?:Partial<CommodityClassification>) {
        assign(this, init)
    } 
    
    
    itemClassificationCode?: CodeType
}
