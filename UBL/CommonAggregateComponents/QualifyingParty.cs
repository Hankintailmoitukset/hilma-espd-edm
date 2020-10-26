using System.Xml.Linq;
using Hilma.UBL.Attributes;
using Hilma.UBL.Serializers;
using Hilma.UBL.UnqualifiedDataTypes;

namespace Hilma.UBL.CommonAggregateComponents
{
    [Contract]
    public class QualifyingParty
    {
        /// <summary>
        /// The number of people employed by the economic operator participating in the tender.
        /// </summary>
        public QuantityType EmployeeQuantity { get; set; }

        /// <summary>
        /// The text describing one official classification assigned by an official list or (pre)qualification system to the economic operator.
        /// </summary>
        public BusinessClassificationScheme BusinessClassificationScheme { get; set; }


        /// <summary>
        /// Turnover: For statistical purposes the ESPD-EDM asks this datum to reflect the financial capability of the economic operator.
        /// </summary>
        /// <value></value>
        public FinancialCapability FinancialCapability{ get; set; }

                /// <summary>
        /// Text describing the works, supplies or services executed, delivered or performed in a procurement project (normally used as a reference for the classification of the economic operator.
        /// </summary>
        public CompletedTask CompletedTask { get; set; }

        /// <summary>
        /// The qualifying party itself.
        /// </summary>
        /// <value></value>
        public Party Party { get; set; }

    public XElement Serialize() {
      return new XElement(UblNames.Cac + nameof(QualifyingParty),
         EmployeeQuantity.Serialize(nameof (EmployeeQuantity)),
         BusinessClassificationScheme?.Serialize(),
         FinancialCapability?.Serialize(),
         CompletedTask?.Serialize(),
         Party?.Serialize(nameof (Party))
       );
     }
    }
  }