using Hilma.UBL.Attributes;

namespace Hilma.UBL.PrimitiveTypes
{
  [Contract]
  public class DecimalType
  {
    protected bool Equals(DecimalType other)
    {
      return Value == other.Value;
    }

    public override bool Equals(object obj)
    {
      if (ReferenceEquals(null, obj)) return false;
      if (ReferenceEquals(this, obj)) return true;
      if (obj.GetType() != this.GetType()) return false;
      return Equals((DecimalType) obj);
    }

    public override int GetHashCode()
    {
      return Value.GetHashCode();
    }

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