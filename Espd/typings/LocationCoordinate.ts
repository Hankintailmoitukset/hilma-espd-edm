import { CodeType } from './CodeType'
import { MeasureType } from './MeasureType'
import assign from 'lodash.assign'

export class LocationCoordinate { 
    public constructor(init?:Partial<LocationCoordinate>) {
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
