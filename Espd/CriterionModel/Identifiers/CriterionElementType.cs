using Hilma.UBL.UnqualifiedDataTypes;

namespace Hilma.Espd.EDM.CriterionModel.Identifiers
{
    public class CriterionElementType : CodeType {
        public CriterionElementType( string code ) : base ( code ) {
            this.ListID = "CriterionElementType";
            this.ListAgencyID = "EU-COM-GROW";
            this.ListVersionID = "2.1.0";
        }
    }
}