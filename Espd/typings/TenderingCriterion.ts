import { TenderingCriterion } from './TenderingCriterion'

import assign from 'lodash.assign'

export class TenderingCriterion {
    public constructor(init?:Partial<TenderingCriterion>) {
        assign(this, init)
    }
    
    
    id: IdentifierType | undefined
    criterionTypeCode: CodeType | undefined
    name: NameType | undefined
    description: TextType[] = []
    weightNumeric: DecimalType | undefined
    evaluationMethodTypeCode: CodeType | undefined
    weightingConsiderationDescription: TextType | undefined
    subTenderingTenderingCriteria: TenderingCriterion[] = []
    legislations: Legislation[] = []
    tenderingCriterionPropertyGroups: TenderingCriterionPropertyGroup[] = []
    fulfilmentIndicatorType: boolean = false
    fulfilmentIndicatorTypeCodeType: NormalizedString | undefined
}