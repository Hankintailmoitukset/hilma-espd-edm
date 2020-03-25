using System;

namespace Hilma.UBL.UnqualifiedDataTypes
{
  /// <summary>
  /// A particular point in the progression of time, together with relevant supplementary information.
  /// </summary>
  public class DateTimeType
  {
    public DateTimeType(DateTime value = default)
    {
      Value = value;
    }

    public DateTime Value { get; set; }

    public static implicit operator DateTime(DateTimeType d) => d.Value;
    public static implicit operator DateTimeType(DateTime d) => new DateTimeType(d);

    public override string ToString()
    {
      return $"{Value:CCYY-MM-DDThh:mm:ss}";
    }
  }
}