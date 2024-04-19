import { IdentifierType } from './IdentifierType'
import { Language } from './Language'
import { Address } from './Address'
import assign from 'lodash.assign'

interface RequiredArgsLegislation {
  title: string
}

export class Legislation {
  public constructor(init?:Partial<Legislation> & RequiredArgsLegislation) {
    assign(this, init)
  }
  public id?: IdentifierType
  public title!: string
  public description?: string
  public jurisdictionLevel?: string
  public article?: string
  public uri?: IdentifierType
  public languages?: Language[]
  public jurisdictionRegionAddress?: Address
  
}
