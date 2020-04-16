using Hilma.UBL.UnqualifiedDataTypes;

namespace Hilma.Espd.EDM.CriterionModel.Identifiers
{
  public class ResponseDataTypeCode : CodeType
  {
    public ResponseDataTypeCode(string code): base(code)
    {
      ListID = "ResponseDataType";
      ListAgencyID = "EU-COM-GROW";
      ListVersionID = "2.1.0";
    }
  }
}