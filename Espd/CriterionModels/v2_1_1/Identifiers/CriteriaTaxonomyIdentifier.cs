namespace Hilma.Espd.EDM.CriterionModels.v2_1_1.Identifiers
{
   
    public class CriteriaTaxonomyIdentifier : EuComGrowId {
    public CriteriaTaxonomyIdentifier( string identifier ) : base( identifier ) {
        SchemeName = "CriteriaTaxonomy";
        SchemeVersionID = "2.1.1";
    }
  }
}