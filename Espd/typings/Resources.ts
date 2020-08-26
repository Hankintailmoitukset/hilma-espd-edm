import { CodeListContract } from './CodeListContract';
import financialRatioTypesData from './financialRatioType.json'
import booleanGUIControlTypesData from './booleanGUIControlType.json'
import criterionSpecificationData from './criterionSpecification.json'
import currencyCodeListData from './currencyCode.json'
import EORoleTypeListData from './eORoleType.json'
import EOIDTypeListData from './eOIDType.json'
import CountryCodeIdentifierData from './countryCodeIdentifier.json'
import translationsDefaultData from './translations.default.json'
import { TenderingCriterion } from './TenderingCriterion';

export class Resources {
  public static financialRatioTypes: CodeListContract = financialRatioTypesData
  public static booleanGUIControlTypes: CodeListContract = booleanGUIControlTypesData
  public static currencyCode: CodeListContract = currencyCodeListData
  public static eORoleType: CodeListContract = EORoleTypeListData
  public static eOIDType: CodeListContract = EOIDTypeListData
  public static CountryCodeIdentifier: CodeListContract = CountryCodeIdentifierData
  public static criterionSpecification: TenderingCriterion[] = criterionSpecificationData
  public static translationsDefault: any = translationsDefaultData
}