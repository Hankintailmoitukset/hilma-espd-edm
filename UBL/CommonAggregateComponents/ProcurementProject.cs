﻿using System.Linq;
using System.Xml.Linq;
using Hilma.UBL.Attributes;
using Hilma.UBL.Serializers;
using Hilma.UBL.UnqualifiedDataTypes;

namespace Hilma.UBL.CommonAggregateComponents
{

  /// <summary>
  /// An overall description of the procurement procedure.
  /// </summary>
  [Contract]
  public class ProcurementProject
  {
    /// <summary>
    /// An overall description of the procurement procedure.
    /// </summary>
    /// <remarks>Use the same name that will be used for the Contract Notice.</remarks>
    public string Name { get; set; }

    /// <summary>
    /// A descriptive text for the procurement procedure.
    /// </summary>
    public string Description { get; set; }

    /// <summary>
    /// A code to describe the object of the project (e.g. works, supplies, services, public work concessions, service concessions, other).
    /// </summary>
    /// <remarks>Compulsory use of the Code List ProjectType.</remarks>
    public CodeType ProcurementTypeCode { get; set; }

    /// <summary>
    /// A class to classify the works, services or supplies. The Self-contained ESPD uses it to assign CPV codes to works and services.
    /// </summary>
    /// <remarks>Use the element cbc:ItemClassificationCode for the specification of the CPV code. Beware that the cardinality of the basic element is 0..1 but the cardinality of the class is 0..n, thus allowing for multiple CPVs.</remarks>
    public CommodityClassification[] MainCommodityClassifications { get; set; }

    public XElement Serialize()
    {
      return new XElement(UblNames.Cac + nameof(ProcurementProject),
        Name.Serialize(nameof(Name)),
        Description.Serialize(nameof(Description)),
        ProcurementTypeCode.Serialize(nameof(ProcurementTypeCode)),
        MainCommodityClassifications?.Select( cpv => cpv?.Serialize("MainCommodityClassification"))
        );
    }
  }
}