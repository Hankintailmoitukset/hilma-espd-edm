import { IdentifierType } from './IdentifierType'
import assign from 'lodash.assign'

interface RequiredArgsEvidenceSupplied {
}

export class EvidenceSupplied {
  public constructor(init?:Partial<EvidenceSupplied> & RequiredArgsEvidenceSupplied) {
    assign(this, init)
  }
  public id?: IdentifierType
  
}
