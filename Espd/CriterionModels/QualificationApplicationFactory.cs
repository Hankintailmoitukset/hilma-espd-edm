  using System;
using System.Collections.Generic;
  using System.Linq;
  using System.Text;
  using Hilma.Espd.EDM.CriterionModels.v2_1_0;
  using Hilma.Espd.EDM.CriterionModels.v2_1_0.Identifiers;
  using Hilma.UBL.CommonAggregateComponents;
  using Hilma.UBL.UnqualifiedDataTypes;

  namespace Hilma.Espd.EDM.CriterionModels
{
  public class QualificationApplicationFactory
  {
    public QualificationApplicationRequest CreateEspd2_1_0SelfContainedRequest(IdentifierType identifier, IdentifierType contractFolderId, Guid uuid)
    {
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
        ProcurementProjectLots = new ProcurementProjectLot[0],
        AdditionalDocumentReferences = new AdditionalDocumentReference[0],
        TenderingCriteria = new CriterionSpecification().AllCriteria.ToArray()
      };
    }
    
  }
}
