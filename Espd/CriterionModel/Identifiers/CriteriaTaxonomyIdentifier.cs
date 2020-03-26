using Hilma.UBL.UnqualifiedDataTypes;

namespace Espd.CriterionModel.Identifiers
{
    public static class SchemedTypeExtensions {

      public static void SetEuGrowScheme( this ISchemedType schemedType ) {
          schemedType.SchemeID = "EU-COM-GROW";
      }

  }

  public class CriteriaTaxonomyIdentifier : IdentifierType {
    public CriteriaTaxonomyIdentifier( string identifier ) : base( identifier ) {
        this.SetEuGrowScheme();
        this.SchemeID = "CriteriaTaxonomy";
        this.SchemeVersionID = "2.1.0";
    }
  }
}