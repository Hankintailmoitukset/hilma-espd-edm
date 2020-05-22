using Hilma.UBL.Attributes;

namespace Hilma.UBL.PrimitiveTypes
{
  [Contract]
  public class DecimalType
  {
    public DecimalType()
    {
    }

    public DecimalType(decimal value)
    {
      Value = value;
    }

    public decimal Value { get; set; }

    public static implicit operator decimal(DecimalType a) => a.Value;
   
    /// <summary>
    /// The default string formatting for decimal value 
    /// </summary>
    /// <returns></returns>
    public override string ToString()
    {
      return $"{Value:F}";
    }
  }
}