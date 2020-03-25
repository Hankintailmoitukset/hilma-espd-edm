using System.ComponentModel.DataAnnotations;
using Hilma.UBL.PrimitiveTypes;

namespace Hilma.UBL.UnqualifiedDataTypes
{
  /// <summary>
  /// A number of monetary units specified using a given unit of currency.
  /// </summary>
  public class AmountType : DecimalType
  {
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
