import assign from 'lodash.assign'

interface RequiredArgsCompletedTask {
}

export class CompletedTask {
  public constructor(init?:Partial<CompletedTask> & RequiredArgsCompletedTask) {
    assign(this, init)
  }
  public description?: string
  
}
