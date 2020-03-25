using System;

namespace Hilma.UBL.UnqualifiedDataTypes
{
  /// <summary>
  /// One calendar day according the Gregorian calendar.
  /// </summary>
  public class DateType
  {
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