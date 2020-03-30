import assign from 'lodash.assign'

export class LocationCoordinateType {
    public constructor(init?:Partial<LocationCoordinateType>) {
        assign(this, init)
    }
    
    
    coordinateSystemCode: CodeType | undefined
    latitudeDegreesMeasure: MeasureType | undefined
    latitudeMinutesMeasure: MeasureType | undefined
    latitudeDirectionCode: CodeType | undefined
    longitudeDegreesMeasure: MeasureType | undefined
    longitudeMinutesMeasure: MeasureType | undefined
    longitudeDirectionCode: CodeType | undefined
    altitudeMeasure: MeasureType | undefined
}