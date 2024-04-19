import assign from 'lodash.assign'

interface RequiredArgsIdentifierType {
}

export class IdentifierType {
  public constructor(init?:Partial<IdentifierType> & RequiredArgsIdentifierType) {
    assign(this, init)
  }
  public value!: string
  
  public schemeID?: string
  public schemeName?: string
  public schemeAgencyID?: string
  public schemeAgencyName?: string
  public schemeVersionID?: string
  public schemeDataURI?: string
  public schemeURI?: string
  
}
