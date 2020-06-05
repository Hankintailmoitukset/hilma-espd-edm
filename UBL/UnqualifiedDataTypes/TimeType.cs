using System;
using System.ComponentModel.DataAnnotations;
using Hilma.UBL.Attributes;

namespace Hilma.UBL.UnqualifiedDataTypes
{
  /// <summary>
  /// An instance of time that occurs every day.
  /// </summary>
  [Contract]
  public class TimeType
  {
    protected bool Equals(TimeType other)
    {
      return Hour == other.Hour && Minute == other.Minute && Second == other.Second;
    }

    public override bool Equals(object obj)
    {
      if (ReferenceEquals(null, obj)) return false;
      if (ReferenceEquals(this, obj)) return true;
      if (obj.GetType() != this.GetType()) return false;
      return Equals((TimeType) obj);
    }

    public override int GetHashCode()
    {
      unchecked
      {
        var hashCode = Hour;
        hashCode = (hashCode * 397) ^ Minute;
        hashCode = (hashCode * 397) ^ Second;
        return hashCode;
      }
    }

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