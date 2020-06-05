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
    protected bool Equals(QuantityType other)
    {
      return base.Equals(other) && UnitCode == other.UnitCode && UnitCodeListID == other.UnitCodeListID && UnitCodeListAgencyName == other.UnitCodeListAgencyName;
    }

    public override bool Equals(object obj)
    {
      if (ReferenceEquals(null, obj)) return false;
      if (ReferenceEquals(this, obj)) return true;
      if (obj.GetType() != this.GetType()) return false;
      return Equals((QuantityType) obj);
    }

    public override int GetHashCode()
    {
      unchecked
      {
        int hashCode = base.GetHashCode();
        hashCode = (hashCode * 397) ^ (UnitCode != null ? UnitCode.GetHashCode() : 0);
        hashCode = (hashCode * 397) ^ (UnitCodeListID != null ? UnitCodeListID.GetHashCode() : 0);
        hashCode = (hashCode * 397) ^ (UnitCodeListAgencyName != null ? UnitCodeListAgencyName.GetHashCode() : 0);
        return hashCode;
      }
    }

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