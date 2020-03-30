import { TenderingCriterionPropertyGroup } from './TenderingCriterionPropertyGroup'

import assign from 'lodash.assign'

export class TenderingCriterionPropertyGroup {
    public constructor(init?:Partial<TenderingCriterionPropertyGroup>) {
        assign(this, init)
    }
    
    
    id: IdentifierType | undefined
    name: NameType[] = []
    description: TextType[] = []
    propertyGroupTypeCode: CodeType | undefined
    fulfilmentIndicatorTypeCode: CodeType | undefined
    tenderingCriterionProperties: TenderingCriterionProperty[] = []
    subsidiaryTenderingCriterionPropertyGroups: TenderingCriterionPropertyGroup[] = []
}