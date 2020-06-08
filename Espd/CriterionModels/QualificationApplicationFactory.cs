using Hilma.Espd.EDM.CriterionModels.v2_1_0.Identifiers;
using Hilma.UBL.CommonAggregateComponents;
using Hilma.UBL.UnqualifiedDataTypes;
using System;
using System.Linq;

namespace Hilma.Espd.EDM.CriterionModels
{
  public class QualificationApplicationFactory
  {
    public QualificationApplicationRequest CreateEspd2_1_0SelfContainedRequest(IdentifierType identifier, IdentifierType contractFolderId, Guid uuid, string[] lotIds )
    {
      var procurementProjectLots = lotIds.Any()
        ? lotIds.Select(l => new ProcurementProjectLot()
        {
          ID = new IdentifierType(l)
        }) : 
        new[] {new ProcurementProjectLot()
        {
          ID = new IdentifierType("0")
        }};  

      var criterionFactory = new CriterionFactory();
      return new QualificationApplicationRequest()
      {
        ID = identifier,
        UUID = new EuComGrowId(uuid),
        ProfileExecutionID = ProfileExecutionId.Espd2_1_0SelfContained,
        QualificationApplicationTypeCode = QualificationApplicationType.SelfContained,
        ContractFolderID = contractFolderId,
        IssueDate = DateTime.UtcNow.Date,
        IssueTime = DateTime.UtcNow,
        ContractingParty = new ContractingParty(),
        ProcurementProject = new ProcurementProject(),
        ProcurementProjectLots = procurementProjectLots.ToArray(),
        AdditionalDocumentReferences = new AdditionalDocumentReference[0],
        TenderingCriteria = criterionFactory.V2_1_0.ExclusionGrounds.ToArray()
      };
    }
    
  }
}
