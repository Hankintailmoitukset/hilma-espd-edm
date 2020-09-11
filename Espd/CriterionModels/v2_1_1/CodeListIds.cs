namespace Hilma.Espd.EDM.CriterionModels.v2_1_1
{
  public class CodeListIds
  {
    public const string CpvCodes = nameof(CpvCodes);
    public const string FinancialRatioType = nameof(FinancialRatioType);
    public const string BooleanGUIControlType = nameof(BooleanGUIControlType);
    public const string CurrencyCode = nameof(CurrencyCode);
    public const string CountryCodeIdentifier = nameof(CountryCodeIdentifier);
    public const string EORoleType = nameof(EORoleType);
    public const string EOIDType = nameof(EOIDType);
    public const string EOIndustryClassificationCode = nameof(EOIndustryClassificationCode);

    public static string[] All => new[]
    {
      FinancialRatioType, 
      BooleanGUIControlType, 
      CurrencyCode,
      CountryCodeIdentifier,
      EORoleType,
      EOIDType,
      EOIndustryClassificationCode
    };
  }
}