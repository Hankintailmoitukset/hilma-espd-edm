using Hilma.UBL.UnqualifiedDataTypes;

namespace Hilma.Espd.EDM.CriterionModels.v2_1_0.Identifiers
{
     public class CriterionElementType : CodeType {
        public static CriterionElementType Requirement => Requirement;
        public static CriterionElementType Question => new CriterionElementType("QUESTION");
       
        public static CriterionElementType Caption => new CriterionElementType("CAPTION");

        public CriterionElementType( string code ) : base ( code ) {
            ListID = "CriterionElementType";
            ListAgencyID = "EU-COM-GROW";
            ListVersionID = "2.1.0";
        }
    }
}
