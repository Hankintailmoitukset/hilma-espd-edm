import { IdentifierType } from './IdentifierType'
import assign from 'lodash.assign'

interface RequiredArgsProcurementProjectLot {
  id: IdentifierType
}

export class ProcurementProjectLot {
  public constructor(init?:Partial<ProcurementProjectLot> & RequiredArgsProcurementProjectLot) {
    assign(this, init)
  }
  public id!: IdentifierType
  
}
