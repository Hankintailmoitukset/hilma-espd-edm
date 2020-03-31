


import { CodeType } from './CodeType'
import { MeasureType } from './MeasureType'

import assign from 'lodash.assign'

export class LocationCoordinateType { 
    public constructor(init?:Partial<LocationCoordinateType>) {
        assign(this, init)
    } 
    
    
    coordinateSystemCode: CodeType = new CodeType()
    latitudeDegreesMeasure: MeasureType = new MeasureType()
    latitudeMinutesMeasure: MeasureType = new MeasureType()
    latitudeDirectionCode: CodeType = new CodeType()
    longitudeDegreesMeasure: MeasureType = new MeasureType()
    longitudeMinutesMeasure: MeasureType = new MeasureType()
    longitudeDirectionCode: CodeType = new CodeType()
    altitudeMeasure: MeasureType = new MeasureType()
}