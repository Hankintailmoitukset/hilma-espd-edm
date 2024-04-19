import { IdentifierType } from './IdentifierType'
import { AmountType } from './AmountType'
import { CodeType } from './CodeType'
import { DateType } from './DateType'
import { TimeType } from './TimeType'
import { MeasureType } from './MeasureType'
import { QuantityType } from './QuantityType'
import assign from 'lodash.assign'

export class ResponseValue { 
    public constructor(init?:Partial<ResponseValue>) {
        assign(this, init)
    } 
    
    
    id?: IdentifierType
    description?: string[]
    responseAmount?: AmountType
    responseCode?: CodeType
    responseDate?: DateType
    responseTime?: TimeType
    responseID?: IdentifierType
    responseIndicator?: boolean
    responseMeasure?: MeasureType
    responseNumeric?: number | null
    responseQuantity?: QuantityType
    responseURI?: IdentifierType
}
