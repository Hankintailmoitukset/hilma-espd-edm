import assign from 'lodash.assign'

export class MeasureType {
    public constructor(init?:Partial<MeasureType>) {
        assign(this, init)
    }
    
    
    unitCode: string = ''
    unitCodeListID: string = ''
    unitCodeListAgencyName: string = ''
}