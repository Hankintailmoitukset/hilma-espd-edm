import assign from 'lodash.assign'

interface RequiredArgsQuantityType {
}

export class QuantityType {
  public constructor(init?:Partial<QuantityType> & RequiredArgsQuantityType) {
    assign(this, init)
  }
  public value?: number
  
  public unitCode?: string
  public unitCodeListID?: string
  public unitCodeListAgencyName?: string
  
}
