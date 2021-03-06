﻿namespace Hilma.Espd.EDM.CriterionModels.v2_1_1.Identifiers
{
  public class ProfileExecutionId : EuComGrowId
  {
    public static readonly ProfileExecutionId Espd2_0_0Regulated = new ProfileExecutionId("ESPD-EDMv2.0.0-REGULATED");
    public static readonly ProfileExecutionId Espd2_0_0SelfContained = new ProfileExecutionId("ESPD-EDMv2.0.0-SELFCONTAINED");
    public static readonly ProfileExecutionId Espd2_1_0Regulated = new ProfileExecutionId("ESPD-EDMv2.1.0-REGULATED");
    public static readonly ProfileExecutionId Espd2_1_0SelfContained = new ProfileExecutionId("ESPD-EDMv2.1.0-SELFCONTAINED");
    
    public static readonly ProfileExecutionId Espd2_1_1Basic = new ProfileExecutionId("ESPD-EDMv2.1.1-BASIC");
    public static readonly ProfileExecutionId Espd2_1_1Extended = new ProfileExecutionId("ESPD-EDMv2.1.1-EXTENDED");
    

    public ProfileExecutionId(string id) : base(id)
    {
    }
  }
}
