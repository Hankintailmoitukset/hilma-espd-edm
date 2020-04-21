namespace Hilma.UBL.CommonAggregateComponents
{
    public static class CardinalityMetadata {
        /// <summary>
        /// Element must occur once and only once
        /// </summary>
        public const string ExactlyOne = "1";

        /// <summary>
        /// Element may exist once and only once, and is not required
        /// </summary>
        public const string Optional = "0..1";

        /// <summary>
        /// Element is optional and may be repeated n times
        /// </summary>
        public const string ZeroOrMore = "0..n";

        /// <summary>
        /// Element must appear one or more times
        /// </summary>
        public const string OneOrMore = "1..n";

  }
}