import { CodeListContract } from './CodeListContract';
import financialRatioTypesData from './financialRatioTypes.json'
import booleanGUIControlTypesData from './booleanGUIControlTypes.json'
import criterionSpecificationData from './criterionSpecification.json'
import translationsDefaultData from './translations.default.json'
import { TenderingCriterion } from './TenderingCriterion';

export class Resources {
  public static financialRatioTypes: CodeListContract = financialRatioTypesData
  public static booleanGUIControlTypes: CodeListContract = booleanGUIControlTypesData
  public static criterionSpecification: TenderingCriterion[] = criterionSpecificationData
  public static translationsDefault: any = translationsDefaultData
}