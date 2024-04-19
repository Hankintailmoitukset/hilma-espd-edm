import { IdentifierType } from './IdentifierType'
import { AmountType } from './AmountType'
import { CodeType } from './CodeType'
import { DateType } from './DateType'
import { TimeType } from './TimeType'
import { MeasureType } from './MeasureType'
import { QuantityType } from './QuantityType'
import assign from 'lodash.assign'

interface RequiredArgsResponseValue {
}

export class ResponseValue {
  public constructor(init?:Partial<ResponseValue> & RequiredArgsResponseValue) {
    assign(this, init)
  }
  public id?: IdentifierType
  public description?: string[]
  public responseAmount?: AmountType
  public responseCode?: CodeType
  public responseDate?: DateType
  public responseTime?: TimeType
  public responseID?: IdentifierType
  public responseIndicator?: boolean
  public responseMeasure?: MeasureType
  public responseNumeric?: number | null
  public responseQuantity?: QuantityType
  public responseURI?: IdentifierType
  
}
