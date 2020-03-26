using Hilma.UBL.UnqualifiedDataTypes;

namespace Espd.CriterionModel.Identifiers
{
    public class CriterionTypeCode : CodeType {
        public CriterionTypeCode( string code ) : base ( code ) {
            this.ListID = "CriteriaTypeCode";
            this.ListAgencyID = "EU-COM-GROW";
            this.ListVersionID = "2.1.0";
        }
    }
}