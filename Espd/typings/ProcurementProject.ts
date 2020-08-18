


import { CodeType } from './CodeType'
import { CommodityClassification } from './CommodityClassification'

import assign from 'lodash.assign'

export class ProcurementProject { 
    public constructor(init?:Partial<ProcurementProject>) {
        assign(this, init)
    } 
    
    
    name?: string
    description?: string
    procurementTypeCode?: CodeType
    mainCommodityClassifications?: CommodityClassification[]
}