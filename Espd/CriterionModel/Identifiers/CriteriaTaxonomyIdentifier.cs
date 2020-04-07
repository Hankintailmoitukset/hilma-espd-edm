namespace Hilma.Espd.EDM.CriterionModel.Identifiers
{
   
    public class CriteriaTaxonomyIdentifier : EuComGrowId {
    public CriteriaTaxonomyIdentifier( string identifier ) : base( identifier ) {
        this.SchemeName = "CriteriaTaxonomy";
        this.SchemeVersionID = "2.1.0";
    }
  }
}