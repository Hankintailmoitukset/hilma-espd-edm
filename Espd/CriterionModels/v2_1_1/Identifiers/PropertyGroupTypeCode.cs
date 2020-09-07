using Hilma.UBL.UnqualifiedDataTypes;

namespace Hilma.Espd.EDM.CriterionModels.v2_1_1.Identifiers
{
    public class PropertyGroupTypeCode : CodeType {
        public PropertyGroupTypeCode( string code ) : base ( code ) {
            ListID = "PropertyGroupType";
            ListAgencyID = "EU-COM-GROW";
            ListVersionID = "2.1.1";
        }

        public static PropertyGroupTypeCode OnAlways => new PropertyGroupTypeCode("ON*");

        /// <summary>
        /// Visible when parent indicator value is false
        /// </summary>
        public static CodeType OnTrue => new PropertyGroupTypeCode("ONTRUE");

        /// <summary>
        /// Visible when parent indicator value is false
        /// </summary>
        public static CodeType OnFalse => new PropertyGroupTypeCode("ONFALSE");

        public static CodeType Empty => new PropertyGroupTypeCode(string.Empty);
    }
}