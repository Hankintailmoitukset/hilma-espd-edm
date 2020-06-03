namespace Hilma.Espd.EDM.CriterionModels.v2_1_0
{
  public class CodeListIds
  {
    public const string CpvCodes = nameof(CpvCodes);
    public const string FinancialRatioType = nameof(FinancialRatioType);
    public const string BooleanGUIControlType = nameof(BooleanGUIControlType);
    public const string CurrencyCode = nameof(CurrencyCode);

    public static string[] All => new[]
    {
      FinancialRatioType, 
      BooleanGUIControlType, 
      CurrencyCode
    };

  }
}