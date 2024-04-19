import assign from 'lodash.assign'

interface RequiredArgsCodeType {
}

export class CodeType {
  public constructor(init?:Partial<CodeType> & RequiredArgsCodeType) {
    assign(this, init)
  }
  public listID?: string
  public listName?: string
  public listAgencyID?: string
  public listAgencyName?: string
  public listVersionID?: string
  public listURI?: string
  public listSchemeURI?: string
  public name?: string
  public languageID?: string
  public value?: string
  
}
