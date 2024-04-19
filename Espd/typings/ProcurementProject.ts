import { CodeType } from './CodeType'
import { CommodityClassification } from './CommodityClassification'
import assign from 'lodash.assign'

interface RequiredArgsProcurementProject {
}

export class ProcurementProject {
  public constructor(init?:Partial<ProcurementProject> & RequiredArgsProcurementProject) {
    assign(this, init)
  }
  public name?: string
  public description?: string
  public procurementTypeCode?: CodeType
  public mainCommodityClassifications?: CommodityClassification[]
  
}
