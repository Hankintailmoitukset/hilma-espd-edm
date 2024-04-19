import assign from 'lodash.assign'

interface RequiredArgsDateType {
}

export class DateType {
  public constructor(init?:Partial<DateType> & RequiredArgsDateType) {
    assign(this, init)
  }
  public value?: Date
  
}
