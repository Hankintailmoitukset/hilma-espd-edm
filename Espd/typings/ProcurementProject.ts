

import { TextType } from './TextType'
import { CodeType } from './CodeType'
import { CommodityClassificationType } from './CommodityClassificationType'

import assign from 'lodash.assign'

export class ProcurementProject {
    public constructor(init?:Partial<ProcurementProject>) {
        assign(this, init)
    } 
    
    
    name: TextType = new TextType()
    description: TextType = new TextType()
    procurementTypeCode: CodeType = new CodeType()
    mainCommodityClassifications: CommodityClassificationType[] = []
}