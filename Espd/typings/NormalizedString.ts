import assign from 'lodash.assign'

interface RequiredArgsNormalizedString {
  value: string
}

export class NormalizedString {
  public constructor(init?:Partial<NormalizedString> & RequiredArgsNormalizedString) {
    assign(this, init)
  }
  public value!: string
  
}
