using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;
using Hilma.UBL.Attributes;
using Hilma.UBL.Serializers;
using Hilma.UBL.UnqualifiedDataTypes;

namespace Hilma.UBL.CommonAggregateComponents
{
  [Contract]
  public class EconomicOperatorParty
  {
        /// <summary>
        /// The distinctive features or characteristics qualifying an economic operator to be a party in a tendering process (e.g., number of employees, number of operating units, type of business, technical and financial capabilities, completed projects).
        /// </summary>
        public QualifyingParty QualifyingParty { get; set; }

        /// <summary>
        /// The function of the economic operator when bidding from a consortium (Sole contractor / Lead entity, member of a group, etc.).
        /// </summary>
        public EconomicOperatorRole EconomicOperatorRole { get; set; }

        /// <summary>
        /// Main set of data used to identify and contact the economic operator, such as official identifiers, name, address, contact person, representatives, etc.
        /// </summary>
        public Party Party { get; set; }

        public XElement Serialize(string name)
        {
          return new XElement(UblNames.Cac + name,
            null, // TODO: Serialize other properties  
            QualifyingParty.Serialize(),
            EconomicOperatorRole.Serialize(),
            Party.Serialize(nameof(Party))
            );
        }
        
    }
}