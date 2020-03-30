import assign from 'lodash.assign'

export class ProcurementProject {
    public constructor(init?:Partial<ProcurementProject>) {
        assign(this, init)
    }
    
    
    name: TextType | undefined
    description: TextType | undefined
    procurementTypeCode: CodeType | undefined
    mainCommodityClassifications: CommodityClassificationType[] = []
}