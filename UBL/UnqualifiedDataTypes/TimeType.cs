using System;
using System.ComponentModel.DataAnnotations;

namespace Hilma.UBL.UnqualifiedDataTypes
{
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

    /// <summary>
    /// Hour part
    /// </summary>
    [Range(0,24)]
    public int Hour { get; set; }

    /// <summary>
    /// Minute part
    /// </summary>
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