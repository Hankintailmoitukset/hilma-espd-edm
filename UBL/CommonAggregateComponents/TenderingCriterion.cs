using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Xml.Linq;
using Hilma.UBL.Attributes;
using Hilma.UBL.Serializers;
using Hilma.UBL.UnqualifiedDataTypes;
using UBL.Enums;

namespace Hilma.UBL.CommonAggregateComponents
{
  [Contract]
  public class TenderingCriterion
  {
      /// <summary>
      /// tells is the criterion set to mandatory.
      /// </summary>
      public bool _mandatory { get; set; } = false;
      /// <summary>
      /// A language-independent token, e.g., a number, that allows to identify a criterion uniquely as well as allows to reference the criterion in other documents.
      /// </summary>
      /// <remarks>
      /// Each Criterion is defined in e-Certis and must use the UUID supplied by e-Certis. See also the spreadsheets Criteria Taxonomy (Regulated ESPD) and Criteria Taxonomy (Self-contained ESPD).
      /// </remarks>
      [Required]
      public IdentifierType ID { get; set; }
      /// <summary>
      /// A classification code defined by the ESPD-EDM to represent the criterion in the ESPD taxonomy of criteria.
      /// </summary>
      /// <remarks>
      /// Rule: Compulsory use of codes coming from e-Certis, which are also used in the spreadsheets Criteria Taxonomy (Regulated ESPD) and Criteria Taxonomy (Self-contained ESPD), e.g. CRITERION.EXCLUSION.CONVICTIONS.PARTICIPATION_IN_CRIMINAL_ORGANISATION, CRITERION.EXCLUSION.SOCIAL.ENVIRONMENTAL_LAW, CRITERION.SELECTION.ECONOMIC_FINANCIAL_STANDING.FINANCIAL_RATIO, etc.).
      /// </remarks>
      [Required]
      public CodeType CriterionTypeCode { get; set; }
      /// <summary>
      /// A short and descriptive name for a criterion.
      /// </summary>
      /// <remarks>
      /// Rule: The name should match the one from e-Certis, which should be the same as in the in the spreadsheets Criteria Taxonomy (Regulated ESPD) and Criteria Taxonomy (Self-contained ESPD), e.g. 'Convictions', 'Corruption', 'Fraud', 'Financial ratio', 'Subcontracting proportion', 'Allowance of checks', etc.).
      /// </remarks>
      [Required]
      public string Name { get; set; }
      /// <summary>
      /// An extended description of the criterion.
      /// </summary>
      /// <remarks>
      /// The description should match the one from e-Certis, which should be the same as in the in the spreadsheets Criteria Taxonomy (Regulated ESPD) and Criteria Taxonomy (Self-contained ESPD), e.g. 'Has the economic operator itself or any person who is a member of its administrative, management or supervisory body or has powers of representation, decision or control therein been the subject of a conviction by final judgment for participation in a criminal organisation, by a conviction rendered at the most five years ago or in which an exclusion period set out directly in the conviction continues to be applicable? As defined in Article 2 of Council Framework Decision 2008/841/JHA of 24 October 2008 on the fight against organised crime (OJ L 300, 11.11.2008, p. 42).'.
      /// Note: The UBL specification allows always multiple lines of text for the component cbc:Description. This feature can be used to split long descriptions into multiple lines, specially when the description contains enumerations (see the criterion "Misinterpretation" for an example).
      /// </remarks>
      [Required]
      public string[] Description { get; set; }
      /// <summary>
      /// A weighting to provide for automatic scoring of the Criterion (normally a percentage, e.g. 0.1, 0.5)
      /// </summary>
      /// <remarks>
      /// Rule: Used only in Self-contained ESPDs namely for ability and professional selection criteria in procedures organised in two stages.
      /// </remarks>
      public decimal? WeightNumeric { get; set; }
      /// <summary>
      /// A code to inform about the type of Evaluation, namely for transparency purposes (e.g. PASSFAIL, WEIGHTED)
      /// </summary>
      /// <remarks>
      /// Rule: Compulsory use of the Code List “EvaluationMethodType”.
      /// </remarks>
      public CodeType EvaluationMethodTypeCode { get; set; }
      /// <summary>
      /// Additional information, comments or considerations about the weighting and the evaluation method, namely for transparency purposes; e.g. '0 Points 0 IT specialists, 30 Points 1 IT specialists, 60 Points 2 IT specialists'. See section about Selection Criteria and sub-section on 'Weighting', for more details.
      /// </summary>
      /// <remarks>
      /// Rule: Used only in Self-contained ESPDs namely for ability and professional selection criteria in procedures organised in two stages.
      /// </remarks>
      public string WeightingConsiderationDescription { get; set; }

      /// <summary>
      /// One or more descendant criteria used namely to define a national exclusion criterion that specialises a more generic criterion like a EU exclusion criterion defined in the Directive.
      /// </summary>
      /// <remarks>
      /// Rule: None. Beware that a sub-criterion 'is a' criterion, therefore no need to list these elements at new. See XML examples in the section about exclusion criteria about how to define a sub-criterion.
      /// </remarks>
      public TenderingCriterion[] SubTenderingCriteria { get; set; }

      /// <summary>
      /// A reference to the legislation related to the Criterion.
      /// </summary>
      /// <remarks>
      /// Rule: None. See table below with the elements of this class.
      /// </remarks>
      public Legislation[] Legislations { get; set; }
      /// <summary>
      /// The first level group of properties and sub-groups of properties in the structure of a criterion.
      /// </summary>
      /// <remarks>
      /// Rule: None. Beware that in previous versions of the ESPD-EDM this was termed “RequirementGroup”.
      /// </remarks>
      [Required]
      public TenderingCriterionPropertyGroup[] TenderingCriterionPropertyGroups { get; set; } = new TenderingCriterionPropertyGroup[0];

      public bool FulfilmentIndicator { get; set; }

      public string FulfilmentIndicatorTypeCode { get; set; }
      
      /// <summary>
      /// This criterion is relevant only if the contract type matches
      /// </summary>
      public ContractType ApplicableContractType { get; set; }

      public XElement Serialize( string name = null)
      {
        return new XElement(UblNames.Cac + (name ?? nameof(TenderingCriterion)),
          ID.Serialize(nameof(ID)),
          CriterionTypeCode.Serialize(nameof(CriterionTypeCode)),
          Name.Serialize(nameof(Name)), 
          Description.Serialize(nameof(Description)),
          WeightNumeric.Serialize(nameof(WeightNumeric)),
          FulfilmentIndicator.Serialize(nameof(FulfilmentIndicator)),
          FulfilmentIndicatorTypeCode?.Serialize(nameof(FulfilmentIndicatorTypeCode)),
          EvaluationMethodTypeCode.Serialize(nameof(EvaluationMethodTypeCode)),
          WeightingConsiderationDescription.Serialize(nameof(WeightingConsiderationDescription)),
          SubTenderingCriteria?.Select( criterion => criterion.Serialize("SubTenderingCriterion")),
          Legislations?.Select( lex => lex.Serialize()),
          TenderingCriterionPropertyGroups?.Select(g => g.Serialize())
        );
      }

  }

  //public static class TenderingCriterionSerializer
  //{
  //  public static XElement ToXml( this TenderingCriterion value )
  //  { 
  //      return new XElement( UblNames.Cbc + nameof(TenderingCriterion),

  //        new XmlElement( value.)
  //        );
  //  }
  //}
}