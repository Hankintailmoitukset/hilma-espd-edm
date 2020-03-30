﻿import assign from 'lodash.assign'

export class QuantityType {
    public constructor(init?:Partial<QuantityType>) {
        assign(this, init)
    }
    
    
    unitCode: string = ''
    unitCodeListID: string = ''
    unitCodeListAgencyName: string = ''
}