namespace Hilma.Espd.EDM.CriterionModels.v2_1_0.Identifiers
{
  public class QualificationApplicationType : EuComGrowCodeType
  {
    public static readonly QualificationApplicationType Regulated = new QualificationApplicationType("REQULATED");
    public static readonly QualificationApplicationType SelfContained = new QualificationApplicationType("SELFCONTAINED");

    public QualificationApplicationType() 
    {
    }

    public QualificationApplicationType(string value) : base(value)
    {
      ListID = "QualificationApplicationType";
    }
  }
}