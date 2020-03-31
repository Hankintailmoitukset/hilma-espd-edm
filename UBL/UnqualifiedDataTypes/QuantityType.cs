using System.ComponentModel.DataAnnotations;
using Hilma.UBL.Attributes;
using Hilma.UBL.PrimitiveTypes;

namespace Hilma.UBL.UnqualifiedDataTypes
{
  /// <summary>
  /// A number of monetary units specified using a given unit of currency.
  /// </summary>
  [Contract]
  public class QuantityType : DecimalType
  {
    /// <summary>
    /// The unit of the quantity
    /// </summary>
    [MaxLength(3)]
    public string UnitCode { get; set; }

    /// <summary>
    /// The quantity unit code list.
    /// </summary>
    public string UnitCodeListID { get; set; }

    /// <summary>
    /// The name of the agency which maintains the quantity unit code list.
    /// </summary>
    public string UnitCodeListAgencyName { get; set; }
    
    public QuantityType()
    {
    }

    public QuantityType(decimal value)
    {
      Value = value;
    }

    public static implicit operator QuantityType(decimal a) => new QuantityType(a);
    
  }
}