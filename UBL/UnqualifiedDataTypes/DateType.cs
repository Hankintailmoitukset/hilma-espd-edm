using System;
using System.ComponentModel.DataAnnotations;

namespace UBL.UnqualifiedDataTypes
{
  /// <summary>
  /// One calendar day according the Gregorian calendar.
  /// </summary>
  public class DateType
  {
    public DateType()
    {
    }

    public DateType(DateTime value = default)
    {
      Value = value;
    }

    public DateTime Value
    {
      get => Value;
      set => value = new DateTime(value.Year, value.Month, value.Day);
    }

    public static implicit operator DateTime(DateType d) => d.Value;
    public static implicit operator DateType(DateTime d) => new DateType(d);

    public override string ToString()
    {
      return $"{Value:CCYY-MM-DD}";
    }
  }

  /// <summary>
  /// An instance of time that occurs every day.
  /// </summary>
  public class TimeType
  {
    public TimeType(int hour, int minute, int second)
    {
      Hour = hour;
      Minute = minute;
      Second = second;
    }

    public TimeType()
    {
    }

    [Range(0,24)]
    public int Hour { get; set; }
    [Range(0, 60)]
    public int Minute { get; set; }

    [Range(0, 60)]
    public int Second { get; set; }
    
    public static implicit operator TimeType(DateTime d) => new TimeType(d.Hour, d.Minute, d.Second );

    public override string ToString()
    {
      return $"{Hour:00}:{Minute:00}:{Second:00}";
    }
  }
}