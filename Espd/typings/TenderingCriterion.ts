

import { IdentifierType } from './IdentifierType'
import { CodeType } from './CodeType'
import { NameType } from './NameType'
import { TextType } from './TextType'
import { DecimalType } from './DecimalType'
import { TenderingCriterion } from './TenderingCriterion'
import { Legislation } from './Legislation'
import { TenderingCriterionPropertyGroup } from './TenderingCriterionPropertyGroup'
import { NormalizedString } from './NormalizedString'

import assign from 'lodash.assign'

export class TenderingCriterion {
    public constructor(init?:Partial<TenderingCriterion>) {
        assign(this, init)
    } 
    
    
    id: IdentifierType = new IdentifierType()
    criterionTypeCode: CodeType = new CodeType()
    name: NameType = new NameType()
    description: TextType[] = []
    weightNumeric: DecimalType = new DecimalType()
    evaluationMethodTypeCode: CodeType = new CodeType()
    weightingConsiderationDescription: TextType = new TextType()
    subTenderingTenderingCriteria: TenderingCriterion[] = []
    legislations: Legislation[] = []
    tenderingCriterionPropertyGroups: TenderingCriterionPropertyGroup[] = []
    fulfilmentIndicatorType: boolean = false
    fulfilmentIndicatorTypeCodeType: NormalizedString = new NormalizedString()
}