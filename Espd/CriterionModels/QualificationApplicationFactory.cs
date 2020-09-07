using Hilma.Espd.EDM.CriterionModels.v2_1_1.Identifiers;
using Hilma.UBL.CommonAggregateComponents;
using Hilma.UBL.UnqualifiedDataTypes;
using System;
using System.Linq;

namespace Hilma.Espd.EDM.CriterionModels
{
  public class QualificationApplicationFactory
  {
    public QualificationApplicationRequest CreateEspd2_1_0SelfContainedRequest(IdentifierType identifier, IdentifierType contractFolderId, Guid uuid, string[] lotIds, bool onlyMandatoryExclusionGrounds)
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
        QualificationApplicationTypeCode = QualificationApplicationType.SelfContained,
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
    
  }
}
