import assign from 'lodash.assign'

interface RequiredArgsPeriod {
}

export class Period {
  public constructor(init?:Partial<Period> & RequiredArgsPeriod) {
    assign(this, init)
  }
  public startDate?: Date
  public endDate?: Date
  
}
