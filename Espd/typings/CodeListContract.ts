import { CodeContract } from './CodeContract'
import assign from 'lodash.assign'

interface RequiredArgsCodeListContract {
}

export class CodeListContract {
  public constructor(init?:Partial<CodeListContract> & RequiredArgsCodeListContract) {
    assign(this, init)
  }
  public shortName?: string
  public longName?: string
  public codes?: CodeContract[]
  public agencyId?: string
  public version?: string
  
}
