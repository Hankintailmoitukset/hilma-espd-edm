


import { Party } from './Party'

import assign from 'lodash.assign'

export class PowerOfAttorney { 
    public constructor(init?:Partial<PowerOfAttorney>) {
        assign(this, init)
    } 
    
    
    agentParty?: Party
    description?: string[]
}
