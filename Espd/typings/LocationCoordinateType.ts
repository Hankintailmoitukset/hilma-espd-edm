


import { CodeType } from './CodeType'
import { MeasureType } from './MeasureType'

import assign from 'lodash.assign'

export class LocationCoordinateType { 
    public constructor(init?:Partial<LocationCoordinateType>) {
        assign(this, init)
    } 
    
    
    coordinateSystemCode?: CodeType
    latitudeDegreesMeasure?: MeasureType
    latitudeMinutesMeasure?: MeasureType
    latitudeDirectionCode?: CodeType
    longitudeDegreesMeasure?: MeasureType
    longitudeMinutesMeasure?: MeasureType
    longitudeDirectionCode?: CodeType
    altitudeMeasure?: MeasureType
}