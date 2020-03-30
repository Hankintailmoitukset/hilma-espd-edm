using System.ComponentModel.DataAnnotations;
using Hilma.UBL.Attributes;
using Hilma.UBL.PrimitiveTypes;

namespace Hilma.UBL.UnqualifiedDataTypes
{
  /// <summary>
  /// A numeric value determined by measuring an object using a specified unit of measure.
  /// </summary>
  [Contract]
  public class MeasureType : DecimalType
  {
    /// <summary>
    /// The unit of the quantity
    /// </summary>
    [MaxLength(3)]
    [Required]
    public string UnitCode { get; set; }

    /// <summary>
    /// The quantity unit code list.
    /// </summary>
    public string UnitCodeListID { get; set; }

    /// <summary>
    /// The name of the agency which maintains the quantity unit code list.
    /// </summary>
    public string UnitCodeListAgencyName { get; set; }

    public MeasureType()
    {
    }

    public MeasureType(decimal value, string unitCode)
    {
      UnitCode = unitCode;
      Value = value;
    }
    
  }
}