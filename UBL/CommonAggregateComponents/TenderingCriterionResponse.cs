using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Xml.Linq;
using Hilma.UBL.Attributes;
using Hilma.UBL.Serializers;
using Hilma.UBL.UnqualifiedDataTypes;

namespace Hilma.UBL.CommonAggregateComponents
{
    [Contract]
    public class TenderingCriterionResponse
    {
       /// <summary>
       /// A language-independent token, e.g., a number, that allows to identify a criterion response uniquely as well as allows to reference the criterion response in other documents. A criterion response describes how an economic operators fulfills an specific criterion.
       /// </summary>
       public IdentifierType ID { get; set; }

       /// <summary>
       /// A cross-reference to the criterion propertys which is validated thorugh this response expressed as an identifier.
       /// </summary>
       [Required]
       public IdentifierType ValidatedCriterionPropertyID { get; set; }

       /// <summary>
       /// A code specifying the confidentiality level of the given response for this criterion.
       /// </summary>
       public CodeType ConfidentialityLevelCode { get; set; }

       /// <summary>
       /// A class to describe the criterion property response value.
       /// </summary>
       public ResponseValue[] ResponseValue { get; set; }

       /// <summary>
       /// A class for the economic operator to specify the start date and the end-date when the expected answer to a criterion property is a lapse of time.
       /// </summary>
       public Period ApplicablePeriod { get; set; }

       /// <summary>
       /// A reference to the evidence supporting this criterion property response.
       /// </summary>
       public EvidenceSupplied EvidenceSupplied { get; set; }

    public XElement Serialize() {
      return new XElement(UblNames.Cac + nameof (TenderingCriterionResponse),
        ID.Serialize(nameof (ID)),
        ValidatedCriterionPropertyID.Serialize(nameof (ValidatedCriterionPropertyID)),
        ConfidentialityLevelCode.Serialize(nameof (ConfidentialityLevelCode)),
        ResponseValue?.Select( v => v.Serialize()),
        ApplicablePeriod?.Serialize(nameof (ApplicablePeriod)),
        EvidenceSupplied?.Serialize(nameof (EvidenceSupplied))
        );
    }
  }
}