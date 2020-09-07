namespace Hilma.Espd.EDM.CriterionModels.v2_1_1.Identifiers
{
  public class QualificationApplicationType : EuComGrowCodeType
  {
    public static readonly QualificationApplicationType Regulated = new QualificationApplicationType("REQULATED");
    public static readonly QualificationApplicationType SelfContained = new QualificationApplicationType("SELFCONTAINED");
    public static readonly QualificationApplicationType Basic = new QualificationApplicationType("BASIC");
    public static readonly QualificationApplicationType Extended = new QualificationApplicationType("EXTENDED");

    public QualificationApplicationType() 
    {
    }

    public QualificationApplicationType(string value) : base(value)
    {
      ListID = "QualificationApplicationType";
    }
  }
}