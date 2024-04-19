import { CodeType } from './CodeType'
import { MeasureType } from './MeasureType'
import assign from 'lodash.assign'

interface RequiredArgsLocationCoordinate {
}

export class LocationCoordinate {
  public constructor(init?:Partial<LocationCoordinate> & RequiredArgsLocationCoordinate) {
    assign(this, init)
  }
  public coordinateSystemCode?: CodeType
  public latitudeDegreesMeasure?: MeasureType
  public latitudeMinutesMeasure?: MeasureType
  public latitudeDirectionCode?: CodeType
  public longitudeDegreesMeasure?: MeasureType
  public longitudeMinutesMeasure?: MeasureType
  public longitudeDirectionCode?: CodeType
  public altitudeMeasure?: MeasureType
  
}
