namespace Hilma.Espd.EDM.CriterionModels.v2_1_0.Identifiers
{
  public class ProfileExecutionId : EuComGrowId
  {
    public static readonly ProfileExecutionId Espd2_0_0Regulated = new ProfileExecutionId("ESPD-EDMv2.0.0-REGULATED");
    public static readonly ProfileExecutionId Espd2_0_0SelfContained = new ProfileExecutionId("ESPD-EDMv2.0.0-SELFCONTAINED");
    public static readonly ProfileExecutionId Espd2_1_0Regulated = new ProfileExecutionId("ESPD-EDMv2.1.0-REGULATED");
    public static readonly ProfileExecutionId Espd2_1_0SelfContained = new ProfileExecutionId("ESPD-EDMv2.1.0-SELFCONTAINED");
    
    public ProfileExecutionId(string id) : base(id)
    {
      SchemeID = "ProfileExecutionID";
    }
  }
}
