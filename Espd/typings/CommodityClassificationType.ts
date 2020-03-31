


import { CodeType } from './CodeType'

import assign from 'lodash.assign'

export class CommodityClassificationType { 
    public constructor(init?:Partial<CommodityClassificationType>) {
        assign(this, init)
    } 
    
    
    itemClassificationCode: CodeType = new CodeType()
}