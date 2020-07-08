using Hilma.UBL.Attributes;

namespace Hilma.UBL.CommonAggregateComponents
{
    [Contract]
    public class CompletedTask
    {
        /// <summary>
        /// Text describing the works, supplies or services executed, delivered or performed in a procurement project (normally used as a reference for the classification of the economic operator.
        /// </summary>
        public string Description { get; set; }
    }
}