using Hilma.UBL.UnqualifiedDataTypes;

namespace Hilma.Espd.EDM.CriterionModels.v2_1_0.Identifiers
{
    public class CriterionTypeCode : CodeType {
        public CriterionTypeCode( string code ) : base ( code ) {
            ListID = "CriteriaTypeCode";
            ListAgencyID = "EU-COM-GROW";
            ListVersionID = "2.1.0";
        }
    }
}