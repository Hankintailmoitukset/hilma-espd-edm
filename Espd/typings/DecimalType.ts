import assign from 'lodash.assign'

interface RequiredArgsDecimalType {
}

export class DecimalType {
  public constructor(init?:Partial<DecimalType> & RequiredArgsDecimalType) {
    assign(this, init)
  }
  public value?: number
  
}
