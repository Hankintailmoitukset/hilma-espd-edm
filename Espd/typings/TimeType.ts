import assign from 'lodash.assign'

interface RequiredArgsTimeType {
}

export class TimeType {
  public constructor(init?:Partial<TimeType> & RequiredArgsTimeType) {
    assign(this, init)
  }
  public hour?: number
  public minute?: number
  public second?: number
  
}
