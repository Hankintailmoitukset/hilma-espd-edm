﻿using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Xml.Linq;
using Hilma.Espd.EDM.Serializers;
using Hilma.UBL.Attributes;
using Hilma.UBL.CommonAggregateComponents;
using Hilma.UBL.CommonExtensionComponents;
using Hilma.UBL.Serializers;
using Hilma.UBL.UnqualifiedDataTypes;

namespace Hilma.Espd.EDM.CriterionModels
{
  [Contract]
  public class QualificationApplicationResponse
  {

    /// <summary>
    /// Identifies the earliest version of the UBL 2 schema for this document type that defines all of the elements that might be encountered in the current instance.
    /// </summary>
    /// <remarks>Use the value "2.2". Use also "OASIS-UBL-TC" for the schemeAgencyID attribute.</remarks>
    [Required]
    public IdentifierType UBLVersionID { get; set; } = new IdentifierType("2.2") { SchemeAgencyID = "OASIS-UBL-TC" };

    /// <summary>
    /// Identifies a user-defined customization of UBL for a specific use.
    /// </summary>
    /// <remarks>For the ESPD we use the value “urn:www.cenbii.eu:transaction:biitrdm092:ver3.0”. Compulsory use of the value "CEN-BII" for the schemeAgencyID attribute.</remarks>
    [Required] 
    public IdentifierType CustomizationID { get; set; } = new IdentifierType("urn:www.cenbii.eu:transaction:biitrdm092:ver3.0") { SchemeAgencyID = "CEN-BII" };

    public XDocument Serialize()
    {
      return new XDocument(new XElement(EspdNames.Qarp + nameof(QualificationApplicationResponse),
        new XAttribute(XNamespace.Xmlns + "cbc", UblNames.Cbc),
        new XAttribute(XNamespace.Xmlns + "cac", UblNames.Cac),
        UBLVersionID.Serialize(nameof(UBLVersionID)),
        CustomizationID.Serialize(nameof(CustomizationID)),
        ProfileID.Serialize(nameof(ProfileID)),
        ID?.Serialize(nameof(ID)),
        CopyIndicator.Serialize(nameof(CopyIndicator)),
        UUID.Serialize(nameof(UUID)),
        ContractFolderID.Serialize(nameof(ContractFolderID)),
        IssueDate.Serialize(nameof(IssueDate)),
        IssueTime.Serialize(nameof(IssueTime)),
        EconomicOperatorGroupName.Serialize(nameof(EconomicOperatorGroupName)),
        VersionID.Serialize(nameof(VersionID)),
        PreviousVersionID.Serialize(nameof(PreviousVersionID)),
        ProcedureCode.Serialize(nameof(ProcedureCode)),
        QualificationApplicationTypeCode.Serialize(nameof(QualificationApplicationTypeCode)),
        WeightScoringMethodologyNote.Serialize(nameof(WeightScoringMethodologyNote)),
        WeightingTypeCode.Serialize(nameof(WeightingTypeCode)),
        ContractingParty?.Serialize(),
        EconomicOperatorParty?.Serialize(nameof(EconomicOperatorParty)),
        ProcurementProject?.Serialize(),
        ProcurementProjectLots?.Select(lot => lot.Serialize()),
        TenderingCriteria?.Select(c => c.Serialize()),
        TenderingCriterionResponses?.Select(r => r.Serialize()),
        AdditionalDocumentReferences?.Select(d => d.Serialize()),
        Evidences?.Select(e => e.Serialize())
        ));
      }

    /// <summary>
    /// An identification of the specification containing the total set of rules regarding semantic content, cardinalities and business rules to which the data contained in the instance document conforms. The identification may include the version of the specification as well as any customizations applied. 
    /// </summary>
    /// <remarks>Use the value "41". Use also "CEN-BII" for the scheme AgencyID attribute.</remarks>
    [Required]
    public IdentifierType ProfileID { get; set; } = new IdentifierType("4.1") { SchemeAgencyID = "CEN-BII" };

    /// <summary>
    /// An identifier for this document, normally generated by the system that creates the ESPD document, or the organisation responsible for the document
    /// (e.g. the buyer, e.g. a contracting authority, or the supplier, e.g. an economic operator).
    /// The identifier enables positive referencing the  document instance for various purposes including referencing between transactions that are part of the same process.
    /// </summary>
    /// <remarks>Compulsory use of schemeAgencyID attribute. Use it to identify the organisation responsible for the document.</remarks>
    [Required]
    public IdentifierType ID { get; set; }

    /// <summary>
    ///  It is a good practice to use the CopyIndicator component if the same document is forwarded several times to the same or to different destinations.
    /// Use it in combination with the UUID identifier: copies of an ESPD document should be identified with distinct UUIDs.
    /// </summary>
    public bool? CopyIndicator { get; set; }

    /// <summary>
    /// This UUID will be used to link the ESPD Response to its corresponding ESPD Request (thus its compulsoriness).
    /// Copies of a document must be identified with a different UUID. Compulsory use of schemeAgencyID attribute.
    /// </summary>
    [Required]
    public IdentifierType UUID { get; set; }

    /// <summary>
    /// An identifier that is specified by the buyer and used as a reference number for all documents in the procurement process.
    /// It is also known as procurement project identifier, procurement reference number or contract folder identifier.
    /// A reference to the procurement procedure to which a Qualification request document and the delivered response documents are associated.
    /// </summary>
    /// <remarks>
    /// Try always to use the reference number issued by the contracting authority.
    /// This number in combination with a registered contracting authority ID (e.g. the VAT number) results in a universally unique identifier of the procurement procedure.
    /// </remarks>
    [Required]
    public IdentifierType ContractFolderID { get; set; }

    /// <summary>
    /// Date when the document was issued by the contracting authority.
    /// </summary>
    [Required]
    public DateType IssueDate { get; set; }
 
    /// <summary>
    /// Time when the document was issued by the contracting authority.
    /// </summary>
    /// <value>Format "hh:mm:ss".</value>
    public TimeType IssueTime { get; set; }

    /// <summary>
    /// The name of the group that presents a tender to which this economic operator belongs (e.g. the name of a consortium, a joint venture, etc.).
    /// </summary>
    /// <remarks>
    /// The leader of the group must take care of ensuring that the name of the group is identical in all the ESPDs of the tender.
    /// </remarks>
    public CodeType EconomicOperatorGroupName { get; set; }

    /// <summary>
    /// The version identifying the content of this document.
    /// </summary>
    /// <remarks>Changes in content should entail the modification of the version identifier and a reference to the previous version.</remarks>
    public IdentifierType VersionID { get; set; }

    /// <summary>
    /// The version identifying the previous modification of the content of this document.
    /// </summary>
    public IdentifierType PreviousVersionID { get; set; }

    /// <summary>
    /// The type of the procurement administrative procedure according to the EU Directives.
    /// </summary>
    /// <remarks>
    /// Compulsory use of attributes listID, listAgencyName and listVersionID.
    /// Compulsory use of the code list ProcedureType (values: Open, Restricted, Accelerated, Competitive dialogue, etc.).
    /// Do not confound with the object of the procurement project (code list ProjectType: Works, Supplies, Services).
    /// </remarks>
    public CodeType ProcedureCode { get; set; }

    /// <summary>
    /// The type of European Single Procurement Document (ESPD).
    /// </summary>
    /// <remarks>
    /// Compulsory use of the code list QualificationApplicationType. Compulsory use of attributes listID, listAgencyName and listVersionID.
    /// </remarks>
    [Required]
    public CodeType QualificationApplicationTypeCode { get; set; }

    /// <summary>
    /// Free-form text to describing information about Weight Scoring Methodology.
    /// </summary>
    /// <remarks>Used for transparency motives. Provide a text explaining clearly the method that will be used to select those selection criteria that will be weighted.</remarks>
    public string[] WeightScoringMethodologyNote { get; set; }

    /// <summary>
    /// A code specifying the type of the Weighting.
    /// </summary>
    /// <remarks>Compulsory use of the code list WeightingType. If this element it is not instantiated and one or more selection criteria are weighted the type defaults to NUMERIC.</remarks>
    public CodeType WeightingTypeCode { get; set; }

    /// <summary>
    /// The contracting authority or contracting entity who is buying supplies, services or public works using a tendering procedure as described in the applicable directive (Directives 2014/24/EU, 2014/25/EU).
    /// </summary>
    /// <remarks> UBL-2.2 defines multiple cardinality ContractingParties presumably to allow joint procurements. However the ESPD only expects data about one buyer. The decision was made that in case of joint procurement the data collected in the ESPD would be about the leader of the joint procurement procedure.</remarks>
    [Required]
    public ContractingParty ContractingParty { get; set; }

    /// <summary>
    /// Any natural or legal person or public entity which offers the execution of works and/or a work, the supply of products or the provision of services on the market. Information about the party submitting the qualification.
    /// </summary>
    public EconomicOperatorParty EconomicOperatorParty { get; set; }

    /// <summary>
    /// An overall definition of the procurement procedure.
    /// </summary>
    /// <remarks>
    /// Use this component in case the ESPD is SELF-CONTAINED and the procedure is divided into lots.
    /// In this case use the ProcurementProjectLot component to provide details
    /// specific to the lot and reserve the ProcurementProject component to describe the global characteristics of the procedure.
    /// </remarks>
    [Required]
    public ProcurementProject ProcurementProject { get; set; }

    /// <summary>
    /// One of the procurement project lots into which this contract can be divided.
    /// </summary>
    /// <remarks> If there is only one single procurement project lot specified, the ESPD refers then to a procurement procedure without lots.</remarks>
    [Required]
    public ProcurementProjectLot[] ProcurementProjectLots { get; set; }

    /// <summary>
    /// A tendering criterion describes a rule or a condition that is used by the contracting body to evaluate and compare tenders by economic operators and which will be used for the exclusion and the selection of candidates to the award decision.
    /// </summary>
    /// <remarks>See detailed documentation online</remarks>
    [Required]
    public TenderingCriterion[] TenderingCriteria { get; set; }

    /// <summary>
    /// Response of the economic operator to the requirements and questions issued by the contracting authority in the ESPD Request.
    /// </summary>
    /// <remarks>
    public TenderingCriterionResponse[] TenderingCriterionResponses { get; set; }

    /// <summary>
    /// A reference to an additional document associated with this document.
    /// </summary>
    /// <remarks>For procurement procedures above the threshold it is compulsory to make reference to the Contract Notice of the procedure published in TED. See section "Reference to the Contract Notice" for a complete example.</remarks>
    public AdditionalDocumentReference[] AdditionalDocumentReferences { get; set; }
    
    public Evidence[] Evidences { get; set; }

  }
}
