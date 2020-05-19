using Hilma.UBL.UnqualifiedDataTypes;

namespace Hilma.Espd.EDM.CriterionModels.v2_1_0.Identifiers
{
  public class ResponseDataTypeCode : CodeType
  {
    public ResponseDataTypeCode(string code): base(code)
    {
      ListID = "ResponseDataType";
      ListAgencyID = "EU-COM-GROW";
      ListVersionID = "2.1.0";
    }

    /// <summary>
    /// Indicator type
    /// </summary>
    public static CodeType Indicator => new ResponseDataTypeCode("INDICATOR");

    /// <summary>
    /// Description value data type
    /// </summary>
    public static CodeType Description => new ResponseDataTypeCode("DESCRIPTION");

    /// <summary>
    /// None type
    /// </summary>
    public static CodeType None => new ResponseDataTypeCode("NONE");

    /// <summary>
    /// Lot identifier
    /// </summary>
    public static CodeType LotIdentifier => new ResponseDataTypeCode("LOT_IDENTIFIER");

    /// <summary>
    /// Url
    /// </summary>
    public static CodeType Url => new ResponseDataTypeCode("URL");

    /// <summary>
    /// Period
    /// </summary>
    public static CodeType Period => new ResponseDataTypeCode("PERIOD");
    
    /// <summary>
    /// Evidence identifier
    /// </summary>
    public static CodeType EvidenceIdentifier => new ResponseDataTypeCode("EVIDENCE_IDENTIFIER");

    /// <summary>
    /// Identifier
    /// </summary>
    public static CodeType Identifier => new ResponseDataTypeCode("IDENTIFIER");

    /// <summary>
    /// Country code
    /// </summary>
    public static CodeType CountryCode => new ResponseDataTypeCode("CODE_COUNTRY");

    /// <summary>
    /// Amount
    /// </summary>
    public static CodeType Amount => new ResponseDataTypeCode("AMOUNT");


    /// <summary>
    /// Date
    /// </summary>
    public static CodeType Date => new ResponseDataTypeCode("DATE");
  }
}