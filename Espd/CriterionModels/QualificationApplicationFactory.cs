using Hilma.Espd.EDM.CriterionModels.v2_1_1.Identifiers;
using Hilma.UBL.CommonAggregateComponents;
using Hilma.UBL.UnqualifiedDataTypes;
using System;
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
                                                          : criterionFactory.V2_1_1.ExclusionGrounds.ToArray()
      };
    }

    public QualificationApplicationResponse CreateEspd2_1_1ExtendedResponse(QualificationApplicationRequest request, EconomicOperatorParty economicOperator, IdentifierType identifier, IdentifierType contractFolderId, Guid uuid, string[] lotIds, bool onlyMandatoryExclusionGrounds)
    {
      if (request == null) throw new ArgumentNullException(nameof(request));
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
      return new QualificationApplicationResponse()
      {
        ID = identifier,
        UUID = new EuComGrowId(uuid),
        QualificationApplicationTypeCode = QualificationApplicationType.Extended,
        ContractFolderID = contractFolderId,
        IssueDate = DateTime.UtcNow.Date,
        IssueTime = DateTime.UtcNow,
        ContractingParty = new ContractingParty(),
        ProcurementProject = new ProcurementProject(),
        ProcurementProjectLots = procurementProjectLots.ToArray(),
        AdditionalDocumentReferences = new AdditionalDocumentReference[0],
        TenderingCriteria = onlyMandatoryExclusionGrounds ? criterionFactory.V2_1_1.ExclusionGrounds.MandatoryCriteria.ToArray()
          : criterionFactory.V2_1_1.ExclusionGrounds.ToArray(),
        TenderingCriterionResponses = new TenderingCriterionResponse[]{}
      };
    }

    private QualificationApplicationResponse CreateEspd2_1_1ExtendedResponse(QualificationApplicationRequest request, EconomicOperatorParty economicOperator)
    {
      return new QualificationApplicationResponse
      {
        TenderingCriterionResponses = new TenderingCriterionResponse[0],
        TenderingCriteria = request.TenderingCriteria,
        ProcurementProjectLots = request.ProcurementProjectLots,
        ProcurementProject = request.ProcurementProject,
        EconomicOperatorParty = economicOperator,
        ContractingParty = request.ContractingParty,
        WeightingTypeCode = request.WeightingTypeCode,
        WeightScoringMethodologyNote = request.WeightScoringMethodologyNote,
        QualificationApplicationTypeCode = request.QualificationApplicationTypeCode,
        ProcedureCode = request.ProcedureCode,
        AdditionalDocumentReferences = request.AdditionalDocumentReferences,
        PreviousVersionID = request.PreviousVersionID,
        EconomicOperatorGroupName = new CodeType(),
        IssueTime = request.IssueTime,
        IssueDate = request.IssueDate,
        ContractFolderID = request.ContractFolderID,
        CopyIndicator = false,
        UBLVersionID = request.UBLVersionID,
        ID = request.ID,
        UUID = request.UUID,
        VersionID = request.VersionID,
        Evidences = new Evidence[0]
      };
    }

  }
}
