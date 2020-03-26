using Hilma.UBL.UnqualifiedDataTypes;

namespace Hilma.Espd.EDM.CriterionModel.Identifiers
{
    public class PropertyGroupTypeCode : CodeType {
        public PropertyGroupTypeCode( string code ) : base ( code ) {
            this.ListID = "PropertyGroupType";
            this.ListAgencyID = "EU-COM-GROW";
            this.ListVersionID = "2.1.0";
        }
    }
}