

import { IdentifierType } from './IdentifierType'
import { NameType } from './NameType'
import { TextType } from './TextType'
import { CodeType } from './CodeType'
import { TenderingCriterionProperty } from './TenderingCriterionProperty'
import { TenderingCriterionPropertyGroup } from './TenderingCriterionPropertyGroup'

import assign from 'lodash.assign'

export class TenderingCriterionPropertyGroup {
    public constructor(init?:Partial<TenderingCriterionPropertyGroup>) {
        assign(this, init)
    } 
    
    
    id: IdentifierType = new IdentifierType()
    name: NameType[] = []
    description: TextType[] = []
    propertyGroupTypeCode: CodeType = new CodeType()
    fulfilmentIndicatorTypeCode: CodeType = new CodeType()
    tenderingCriterionProperties: TenderingCriterionProperty[] = []
    subsidiaryTenderingCriterionPropertyGroups: TenderingCriterionPropertyGroup[] = []
}