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
    protected bool Equals(MeasureType other)
    {
      return base.Equals(other) && UnitCode == other.UnitCode && UnitCodeListID == other.UnitCodeListID && UnitCodeListAgencyName == other.UnitCodeListAgencyName;
    }

    public override bool Equals(object obj)
    {
      if (ReferenceEquals(null, obj)) return false;
      if (ReferenceEquals(this, obj)) return true;
      if (obj.GetType() != this.GetType()) return false;
      return Equals((MeasureType) obj);
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