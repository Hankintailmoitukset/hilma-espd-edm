import { Party } from './Party'
import assign from 'lodash.assign'

interface RequiredArgsPowerOfAttorney {
}

export class PowerOfAttorney {
  public constructor(init?:Partial<PowerOfAttorney> & RequiredArgsPowerOfAttorney) {
    assign(this, init)
  }
  public agentParty?: Party
  public description?: string[]
  
}
