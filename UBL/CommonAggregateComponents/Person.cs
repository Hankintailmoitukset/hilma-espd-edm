using System.Xml.Linq;
using Hilma.UBL.Attributes;
using Hilma.UBL.Serializers;
using Hilma.UBL.UnqualifiedDataTypes;

namespace Hilma.UBL.CommonAggregateComponents
{   
    /// <summary>
    /// Class decribing a person
    /// </summary>
    [Contract]
    public class Person
    {   
        /// <summary>
        /// This person's given name.
        /// </summary>
        /// <value></value>
        public string FirstName { get; set; }
            
        /// <summary>
        /// This person's family name.<
        /// </summary>
        /// <value></value>
        public string FamilyName { get; set; }
        
        /// <summary>
        /// This person's date of birth.
        /// </summary>
        /// <value></value>
        public DateType BirthDate { get; set; }

        /// <summary>
        /// The name of the place where this person was born, expressed as text.
        /// </summary>
        /// <value></value>
        public string BirthPlaceName { get; set; }

        /// <summary>
        /// Contact information for this person.
        /// </summary>
        /// <value></value>
        public Contact Contact { get; set; }

        /// <summary>
        /// This person's address of residence.
        /// </summary>
        /// <value></value>
        public Address ResidenceAddress { get; set; }

        public XElement Serialize()
        {
            return new XElement(UblNames.Cac + nameof(Person),
                FirstName.Serialize(nameof(FirstName)),
                FamilyName.Serialize(nameof(FamilyName)),
                BirthPlaceName.Serialize(nameof(BirthPlaceName)),
                Contact?.Serialize(),
                ResidenceAddress?.Serialize(nameof(ResidenceAddress))
            );
        }
    }
}