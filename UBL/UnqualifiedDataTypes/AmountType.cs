using System.ComponentModel.DataAnnotations;
using Hilma.UBL.Attributes;
using Hilma.UBL.PrimitiveTypes;

namespace Hilma.UBL.UnqualifiedDataTypes
{
  /// <summary>
  /// A number of monetary units specified using a given unit of currency.
  /// </summary>
  [Contract]
  public class AmountType : DecimalType
  {
    protected bool Equals(AmountType other)
    {
      return base.Equals(other) && CurrencyID == other.CurrencyID && CurrencyCodeListVersionID == other.CurrencyCodeListVersionID;
    }

    public override bool Equals(object obj)
    {
      if (ReferenceEquals(null, obj)) return false;
      if (ReferenceEquals(this, obj)) return true;
      if (obj.GetType() != this.GetType()) return false;
      return Equals((AmountType) obj);
    }

    public override int GetHashCode()
    {
      unchecked
      {
        int hashCode = base.GetHashCode();
        hashCode = (hashCode * 397) ^ (CurrencyID != null ? CurrencyID.GetHashCode() : 0);
        hashCode = (hashCode * 397) ^ (CurrencyCodeListVersionID != null ? CurrencyCodeListVersionID.GetHashCode() : 0);
        return hashCode;
      }
    }

    /// <summary>
    /// The currency of the amount.
    /// </summary>
    /// <remarks>Reference UNECE Rec 9, using 3-letter alphabetic codes.</remarks>
    [MaxLength(3)]
    public string CurrencyID { get; set; }

    /// <summary>
    /// The VersionID of the UN/ECE Rec9 code list.
    /// </summary>
    public string CurrencyCodeListVersionID { get; set; }

    public AmountType()
    {
    }

    public AmountType(decimal value)
    {
      Value = value;
    }
    
    public static implicit operator AmountType(decimal a) => new AmountType(a);
    
  }
}
