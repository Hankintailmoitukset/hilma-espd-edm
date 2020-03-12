using System.ComponentModel.DataAnnotations;
using UBL.UnqualifiedDataTypes;

namespace UBL.CommonAggregateComponents
{
  public class ProcurementProjectLot
  {
    /// <summary>
    /// A reference to one or more lots the economic operator is applying for.
    /// The original lot definition is part of the call for tender document.
    /// The Qualification instance only references the corresponding IDs in order to establish the connection to the call for tender information.
    /// </summary>
    /// <remarks>Compulsory use of schemeAgencyID attribute. If several lots are present check that the type of the cbc:QualificationApplicationResponse element is set to SELFCONTAINED; otherwise a fatal exception should be thrown.
    /// As for the Regulated version,
    /// if only one Lot is specified its ID has to be set to '0' thus indicating that the procurement procedure is not divided into Lots.</remarks>
    [Required]
    public IdentifierType? ID { get; set; }
  }
}