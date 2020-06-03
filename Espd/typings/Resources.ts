import { CodeListContract } from './CodeListContract';
import financialRatioTypesData from './financialRatioType.json'
import booleanGUIControlTypesData from './booleanGUIControlType.json'
import criterionSpecificationData from './criterionSpecification.json'
import currencyCodeListData from './currencyCode.json'
import translationsDefaultData from './translations.default.json'
import { TenderingCriterion } from './TenderingCriterion';

export class Resources {
  public static financialRatioTypes: CodeListContract = financialRatioTypesData
  public static booleanGUIControlTypes: CodeListContract = booleanGUIControlTypesData
  public static currencyCode: CodeListContract = currencyCodeListData
  public static criterionSpecification: TenderingCriterion[] = criterionSpecificationData
  public static translationsDefault: any = translationsDefaultData
}