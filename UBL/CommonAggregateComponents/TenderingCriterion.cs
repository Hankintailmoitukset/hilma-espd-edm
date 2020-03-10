using System.ComponentModel.DataAnnotations;
using UBL.UnqualifiedDataTypes;

namespace UBL.CommonAggregateComponents
{
  public class TenderingCriterion
  {
      public IdentifierType Id { get; set; }
    
      public CodeType CriterionTypeCode { get; set; }

      public NameType Name { get; set; }

      public TextType[] Description { get; set; }

      public Legislation[] Legislations { get; set; }
      
      public TenderingCriterion[] SubTenderingTenderingCriteria { get; set; }

      [Required]
      public TenderingCriterionPropertyGroup[] TenderingCriterionPropertyGroups { get; set; } = new TenderingCriterionPropertyGroup[0];
  }

  //public static class TenderingCriterionSerializer
  //{
  //  public static XElement ToXml( this TenderingCriterion value )
  //  { 
  //      return new XElement( UblNames.Cbc + nameof(TenderingCriterion),
          
  //        new XmlElement( value.)
  //        );
  //  }
  //}
}