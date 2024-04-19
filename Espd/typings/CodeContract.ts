import assign from 'lodash.assign'

interface RequiredArgsCodeContract {
}

export class CodeContract {
  public constructor(init?:Partial<CodeContract> & RequiredArgsCodeContract) {
    assign(this, init)
  }
  public code?: string
  public name?: string
  
}
