using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Xml.Linq;
using Hilma.UBL.Attributes;
using Hilma.UBL.Serializers;
using Hilma.UBL.UnqualifiedDataTypes;

namespace Hilma.UBL.CommonAggregateComponents
{
  [Contract]
  public class TenderingCriterionProperty
  {
    /// <summary>
    /// Metadata: Cardinality of the element. 
    /// </summary>
    /// <example>"1" specifies that the element is required and repeated only once </example>
    /// <example>"0..1" specifies that the element is optional and repeated only once </example>
    /// <example>"0..n" specifies that the element is optional and repeated zero to n times</example>
    /// <example>"1..n" specifies that the element is required and repeated one to n times</example>
    public string _cardinality { get; set; } = CardinalityMetadata.ExactlyOne;
    
    /// <summary>
    /// Identifies one specific property.
    /// </summary>
    /// <remarks>
    /// Rule: Property identifiers must use UUID numbers (version 4) automatically generated. The responses of the economic operator (in the ESPD Response document) will refer to this UUID to link the response with one, and only one, criterion property. See the section about the ESPD Response for examples.
    /// </remarks>
    [Required]
    public IdentifierType ID { get; set; } 
    /// <summary>
    /// The name of the criterion property.
    /// </summary>
    public string Name { get; set; }
    /// <summary>
    /// The text of the caption, requirement or question.
    /// </summary>
    /// <remarks>
    /// Rule: None.
    /// </remarks>
    [Required]
    public string Description { get; set; }

    /// <summary>
    /// The type of property. Used to verify that structure of the property is correct.
    /// </summary>
    /// <remarks>
    /// Rule: Compulsory use of the Code List 'CriterionElementType'. Possible types are 'CAPTION, REQUIREMENT and QUESTION'. If the type is CAPTION or REQUIREMENT no answer is expected from the economic operator and therefore the cbc:ValueDataTypeCode must be set to NONE. Otherwise this value must be set to one of the values defined in the Code List 'ResponseDataType'
    /// </remarks>
    [Required]
    public CodeType TypeCode { get; set; }
    /// <summary>
    /// The type of answer expected by the contracting authority in the case of a poperty of type QUESTION.
    /// </summary>
    /// <remarks>
    /// Rule: Compulsory use of the Code List “ResponseDataType”. Verify that the value is different to NONE for properties of type QUESTION.
    /// </remarks>
    [Required]
    public CodeType ValueDataTypeCode { get; set; }
    /// <summary>
    /// The unit of measure of the numeric value as a quantity or measure in the expected response from the economic operator.
    /// </summary>
    /// <remarks>
    /// Rule: Verify that the value of cac:TypeCode is set to QUESTION and that the cac:ValueTypeCode is different to NONE.
    /// </remarks>
    public CodeType ValueUnitCode { get; set; }
    /// <summary>
    /// The currency of the numeric value as an amount in the expected response from the economic operator.
    /// </summary>
    /// <remarks>
    /// Rule: Verify that the value of cac:TypeCode is set to QUESTION and that the cac:ValueTypeCode is different to NONE.
    /// </remarks>
    public CodeType ValueCurrencyCode { get; set; }
    /// <summary>
    /// The expected amount that the responder has to provide in the criterion response.
    /// </summary>
    public AmountType ExpectedAmount { get; set; }
    /// <summary>
    /// The expected identifier that the economic operator has to provide in the criterion response.
    /// </summary>
    /// <remarks>
    /// Rule: Verify that the value of cac:TypeCode is set to QUESTION and that the cac:ValueTypeCode is different to NONE.
    /// </remarks>
    public IdentifierType ExpectedID { get; set; }
    /// <summary>
    /// The expected code that the economic operator has to provide in the Criterion response.
    /// </summary>
    /// <remarks>
    /// Rule: Verify that the value of cac:TypeCode is set to QUESTION and that the cac:ValueTypeCode is different to NONE.
    /// </remarks>
    public CodeType ExpectedCode { get; set; }
    /// <summary>
    /// The expected value that the economic operator has to provide in the Criterion response.
    /// </summary>
    /// <remarks>
    /// Rule: Verify that the value of cac:TypeCode is set to QUESTION and that the cac:ValueTypeCode is different to NONE.
    /// </remarks>
    public decimal? ExpectedValueNumeric { get; set; }
    /// <summary>
    /// The description of the of the expected
    /// </summary>
    public string ExpectedDescription { get; set; }
    /// <summary>
    /// The maximum amount the response must have.
    /// </summary>
    public AmountType MaximumAmount { get; set; }
    /// <summary>
    /// The minimum amount the response must have.
    /// </summary>
    public AmountType MinimumAmount { get; set; }
    /// <summary>
    /// The maximum value the response must have.
    /// </summary>
    /// <remarks>
    /// Rule: Verify that the value of cac:TypeCode is set to QUESTION and that the cac:ValueTypeCode is different to NONE.
    /// </remarks>
    public decimal? MaximumValueNumeric { get; set; }
    /// <summary>
    /// The minimum value the response must have.
    /// </summary>
    /// <remarks>
    /// Rule: Verify that the value of cac:TypeCode is set to QUESTION and that the cac:ValueTypeCode is different to NONE.
    /// </remarks>
    public decimal? MinimumValueNumeric { get; set; }
    /// <summary>
    /// The type of Translation that the requirement shall be translated for example certified translation
    /// </summary>
    public string TranslationTypeCode { get; set; }
    /// <summary>
    /// The description of the level of the expected certification.
    /// </summary>
    /// <remarks>
    /// Rule: Verify that the value of cac:TypeCode is set to QUESTION and that the cac:ValueTypeCode is different to NONE.
    /// </remarks>
    public string[] CertificationLevelDescription { get; set; }
    /// <summary>
    /// The type of Copy quality, expressed as a code.
    /// </summary>
    public CodeType CopyQualityTypeCode { get; set; }
    /// <summary>
    /// The period to which this criterion property shall apply.
    /// </summary>
    /// <remarks>
    /// Rule: The ESPD-EDM does only expect start date and end date.
    /// </remarks>
    public PeriodType ApplicablePeriod { get; set; }
    /// <summary>
    /// A pointer to one or more evidences that support the veracity of this criterion.
    /// </summary>
    public EvidenceType[] TemplateEvidence { get; set; }

    /// <summary>
    /// Additional property to define code list id for ValueDataType "CODE"
    /// </summary>
    public string CodeListId { get; set; }

    public XElement Serialize()
    {
      return new XElement( UblNames.Cac + nameof(TenderingCriterionProperty),
        ID?.Serialize(nameof(ID)),
        Name.Serialize(nameof(Name)),
        Description.Serialize(nameof(Description)),
        TypeCode?.Serialize(nameof(TypeCode)),
        ValueDataTypeCode?.Serialize(nameof(ValueDataTypeCode)),
        ValueUnitCode?.Serialize(nameof(ValueUnitCode)),
        ValueCurrencyCode?.Serialize(nameof(ValueCurrencyCode)),
        ExpectedAmount?.Serialize(nameof(ExpectedAmount)),
        ExpectedID?.Serialize(nameof(ExpectedID)),
        ExpectedCode?.Serialize(nameof(ExpectedCode)),
        ExpectedValueNumeric.Serialize(nameof(ExpectedValueNumeric)),
        ExpectedDescription.Serialize(nameof(ExpectedDescription)),
        MaximumAmount?.Serialize(nameof(MaximumAmount)),
        MinimumAmount?.Serialize(nameof(MinimumAmount)),
        MaximumValueNumeric.Serialize(nameof(MaximumValueNumeric)),
        MinimumValueNumeric.Serialize(nameof(MinimumValueNumeric)),
        TranslationTypeCode?.Serialize(nameof(TranslationTypeCode)),
        CertificationLevelDescription?.Serialize(nameof(CertificationLevelDescription)),
        CopyQualityTypeCode?.Serialize(nameof(CopyQualityTypeCode)),
        ApplicablePeriod?.Serialize(nameof(ApplicablePeriod)),
        TemplateEvidence?.Select( e => e.Serialize(nameof(TemplateEvidence)))
      );
    }

  }

}