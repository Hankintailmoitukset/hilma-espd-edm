import assign from 'lodash.assign'

interface RequiredArgsMeasureType {
  unitCode: string
}

export class MeasureType {
  public constructor(init?:Partial<MeasureType> & RequiredArgsMeasureType) {
    assign(this, init)
  }
  public value?: number
  
  public unitCode!: string
  public unitCodeListID?: string
  public unitCodeListAgencyName?: string
  
}
