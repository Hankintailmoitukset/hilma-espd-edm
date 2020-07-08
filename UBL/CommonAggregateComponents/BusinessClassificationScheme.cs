using Hilma.UBL.Attributes;

namespace Hilma.UBL.CommonAggregateComponents
{
    [Contract]
    public class BusinessClassificationScheme
    {
        /// <summary>
        /// The text describing one official classification assigned by an official list or (pre)qualification system to the economic operator.
        /// </summary>
        public string[] Description { get; set; }
    }
}