import assign from 'lodash.assign'

interface RequiredArgsStringType {
  value: string
}

export class StringType {
  public constructor(init?:Partial<StringType> & RequiredArgsStringType) {
    assign(this, init)
  }
  public value!: string
  
}
