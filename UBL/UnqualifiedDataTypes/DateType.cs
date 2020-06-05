using System;
using Hilma.UBL.Attributes;

namespace Hilma.UBL.UnqualifiedDataTypes
{
  /// <summary>
  /// One calendar day according the Gregorian calendar.
  /// </summary>
  [Contract]
  public class DateType
  {
    protected bool Equals(DateType other)
    {
      return _value.Equals(other._value);
    }

    public override bool Equals(object obj)
    {
      if (ReferenceEquals(null, obj)) return false;
      if (ReferenceEquals(this, obj)) return true;
      if (obj.GetType() != this.GetType()) return false;
      return Equals((DateType) obj);
    }

    public override int GetHashCode()
    {
      return _value.GetHashCode();
    }

    private DateTime _value;

    public DateType()
    {
    }

    public DateType(DateTime value = default)
    {
      Value = value;
    }

    public DateTime Value
    {
      get => _value;
      set => _value = new DateTime(value.Year, value.Month, value.Day);
    }

    public static implicit operator DateTime(DateType d) => d.Value;
    public static implicit operator DateType(DateTime d) => new DateType(d);

    public override string ToString()
    {
      return $"{Value:CCYY-MM-DD}";
    }
  }
}