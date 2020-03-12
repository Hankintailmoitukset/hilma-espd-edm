﻿using System;
using UBL.UnqualifiedDataTypes;
using UBL.PrimitiveTypes;
using System.ComponentModel.DataAnnotations;

namespace UBL.CommonAggregateComponents
{
    public class TenderingCriterionProperty
  {
    /// <summary>
    /// Identifies one specific property.
    /// </summary>
    /// <remarks>
    /// Rule: Property identifiers must use UUID numbers (version 4) automatically generated. The responses of the economic operator (in the ESPD Response document) will refer to this UUID to link the response with one, and only one, criterion property. See the section about the ESPD Response for examples.
    /// </remarks>
    [Required]
    public IdentifierType Id { get; set; }

    public NameType Name { get; set; }

    /// <summary>
    /// The text of the caption, requirement or question.
    /// </summary>
    /// <remarks>
    /// Rule: None.
    /// </remarks>
    [Required]
    public TextType Description { get; set; }

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

    public decimal ExpectedAmount { get; set; }

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
    public NumericType ExpectedValueNumeric { get; set; }

       
    public string ExpectedDescription { get; set; }

    public string MaximumAmount { get; set; }

    public string MinimumAmount { get; set; }

    /// <summary>
    /// The maximum value the response must have.
    /// </summary>
    /// <remarks>
    /// Rule: Verify that the value of cac:TypeCode is set to QUESTION and that the cac:ValueTypeCode is different to NONE.
    /// </remarks>
    public NumericType MaximumValueNumeric { get; set; }

    /// <summary>
    /// The minimum value the response must have.
    /// </summary>
    /// <remarks>
    /// Rule: Verify that the value of cac:TypeCode is set to QUESTION and that the cac:ValueTypeCode is different to NONE.
    /// </remarks>
    public NumericType MinimumValueNumeric { get; set; }

    public string TranslationTypeCode { get; set; }

    /// <summary>
    /// The description of the level of the expected certification.
    /// </summary>
    /// <remarks>
    /// Rule: Verify that the value of cac:TypeCode is set to QUESTION and that the cac:ValueTypeCode is different to NONE.
    /// </remarks>
    public TextType[] CertificationLevelDescription { get; set; }

    public CodeType CopyQualityTypeCode { get; set; }

    /// <summary>
    /// The period to which this criterion property shall apply.
    /// </summary>
    /// <remarks>
    /// Rule: The ESPD-EDM does only expect start date and end date.
    /// </remarks>
    public PeriodType[] ApplicablePeriod { get; set; }

    /// <summary>
    /// A pointer to one or more evidences that support the veracity of this criterion.
    /// </summary>
    public EvidenceType[] TemplateEvidence { get; set; }

  }

}