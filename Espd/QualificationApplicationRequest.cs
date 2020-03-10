using System.ComponentModel.DataAnnotations;
using UBL.CommonAggregateComponents;
using UBL.UnqualifiedDataTypes;

namespace Espd
{
  public class QualificationApplicationRequest
  {

    /// <summary>
    /// A character string to identify and distinguish uniquely, one instance of an object in an identification scheme from all other objects in the same scheme together with relevant supplementary information.
    /// </summary>
    public IdentifierType ID { get; set; }

    public IdentifierType ContractFolderID { get; set; }

    public DateType IssueDate { get; set; }

    [Required]
    public TimeType IssueTime { get; set; }
    
    public ContractingParty[] ContractingParties { get; set; }

    public ProcurementProject ProcurementProject { get; set; }

    public ProcurementProjectLot ProcurementProjectLot { get; set; }

    public TenderingCriterion[] TenderingCriteria { get; set; }

    public AdditionalDocumentReference[] AdditionalDocumentReferences { get; set; }

  }

}
