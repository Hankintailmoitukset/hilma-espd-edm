using Hilma.Espd.EDM.CriterionModels.v2_1_1.Identifiers;
using Hilma.UBL.CommonAggregateComponents;
using Hilma.UBL.UnqualifiedDataTypes;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Hilma.Espd.EDM.CriterionModels
{
  public class QualificationApplicationFactory
  {
    public QualificationApplicationRequest CreateEspd2_1_1ExtendedRequest(IdentifierType identifier, IdentifierType contractFolderId, Guid uuid, string[] lotIds, bool onlyMandatoryExclusionGrounds)
    {
      if (identifier == null) throw new ArgumentNullException(nameof(identifier));
      if (contractFolderId == null) throw new ArgumentNullException(nameof(contractFolderId));
      if (lotIds == null) throw new ArgumentNullException(nameof(lotIds));

      var procurementProjectLots = lotIds.Any()
        ? lotIds.Select(l => new ProcurementProjectLot()
        {
          ID = new EuComGrowId(l)
        }) : 
        new[] {new ProcurementProjectLot()
        {
          ID = new EuComGrowId("0")
        }}; 

      var criterionFactory = new CriterionFactory();
      return new QualificationApplicationRequest()
      {
        ID = identifier,
        UUID = new EuComGrowId(uuid),
        QualificationApplicationTypeCode = QualificationApplicationType.Extended,
        ProfileExecutionID = ProfileExecutionId.Espd2_1_1Extended,
        ContractFolderID = contractFolderId,
        IssueDate = DateTime.UtcNow.Date,
        IssueTime = DateTime.UtcNow,
        ContractingParty = new ContractingParty(),
        ProcurementProject = new ProcurementProject(),
        ProcurementProjectLots = procurementProjectLots.ToArray(),
        AdditionalDocumentReferences = new AdditionalDocumentReference[0],
        TenderingCriteria = onlyMandatoryExclusionGrounds ? criterionFactory.V2_1_1.ExclusionGrounds.MandatoryCriteria.ToArray()
                                                          : criterionFactory.V2_1_1.ExclusionGrounds.ToArray(),
      };
    }

    public QualificationApplicationResponse CreateEspd2_1_1ExtendedResponse(QualificationApplicationRequest request, EconomicOperatorParty economicOperator, IdentifierType identifier, Guid uuid, string espdReferenceUrl)
    {
      if (request == null) throw new ArgumentNullException(nameof(request));
      if (identifier == null) throw new ArgumentNullException(nameof(identifier));

      var documentReferences = request.AdditionalDocumentReferences?.ToArray() ?? new AdditionalDocumentReference[0];
      var response = new QualificationApplicationResponse()
      {
        ID = identifier,
        UUID = new EuComGrowId(uuid),
        QualificationApplicationTypeCode = request.QualificationApplicationTypeCode,
        ContractFolderID = request.ContractFolderID,
        IssueDate = DateTime.UtcNow.Date,
        IssueTime = DateTime.UtcNow,
        ContractingParty = request.ContractingParty,
        EconomicOperatorParty = economicOperator,
        ProcurementProject = request.ProcurementProject,
        ProcurementProjectLots = request.ProcurementProjectLots,
        WeightingTypeCode = request.WeightingTypeCode,
        WeightScoringMethodologyNote = request.WeightScoringMethodologyNote,
        ProcedureCode = request.ProcedureCode,
        AdditionalDocumentReferences = documentReferences.Union( new []{ MapReferenceToEspdRequest(request, espdReferenceUrl ) }).ToArray(),
        PreviousVersionID = request.PreviousVersionID,
        EconomicOperatorGroupName = new CodeType(),
        CopyIndicator = false,
        UBLVersionID = request.UBLVersionID,
        VersionID = request.VersionID,
        Evidences = new Evidence[0],
        TenderingCriteria = request.TenderingCriteria,
        TenderingCriterionResponses = new TenderingCriterionResponse[]{},
      };

      var procurementHasLots = request.IsProcurementDividedIntoLots;
      
      if( !procurementHasLots) {
        PrePopulateNoLotResponses(response);
      }

      return response;
    }

    private void PrePopulateNoLotResponses( QualificationApplicationResponse response ) {

      var groups = response.TenderingCriteria.SelectMany( c=> c.TenderingCriterionPropertyGroups);
      var responses = groups.SelectMany( g => PrePopulateNoLotResponses(g));
      response.TenderingCriterionResponses = responses.ToArray();
    }
  
    private IEnumerable<TenderingCriterionResponse> PrePopulateNoLotResponses(TenderingCriterionPropertyGroup propertyGroup )
    {
      foreach(var lotProp in propertyGroup.TenderingCriterionProperties.Where( p => p.TypeCode.Equals( CriterionElementType.Question ) && p.ValueDataTypeCode.Equals(ResponseDataTypeCode.LotIdentifier)) )
      {
          yield return new TenderingCriterionResponse() {
            ID = EuComGrowId.Random(),
            ResponseValue = new ResponseValue[] { 
              new ResponseValue() { 
                ResponseID = new IdentifierType("0")
              }
            },
            ValidatedCriterionPropertyID = lotProp.ID,

          };
      }
      if( propertyGroup.SubsidiaryTenderingCriterionPropertyGroups != null ) {
        var subEvidences = propertyGroup.SubsidiaryTenderingCriterionPropertyGroups.SelectMany(PrePopulateNoLotResponses);
        foreach( var evidence in subEvidences) {
          yield return evidence;
        }
      }
    }

    public AdditionalDocumentReference MapReferenceToEspdRequest(QualificationApplicationRequest request, string espdRequestUrl)
    {
        return new AdditionalDocumentReference
        {
            ID = request.ID,
            UUID = request.UUID,
            DocumentTypeCode = new EuComGrowCodeType("ESPD_REQUEST"){ ListID = "DocRefContentType" },
            IssueDate = request.IssueDate,
            IssueTime = request.IssueTime,
            Attachment = new Attachment
            {
                ExternalReference = new ExternalReference
                {
                    URI = new IdentifierType(espdRequestUrl)
                }
            },
        };
    }
  }

 

}
