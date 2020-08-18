﻿using Hilma.UBL.Attributes;
using Hilma.UBL.UnqualifiedDataTypes;

namespace Hilma.UBL.CommonAggregateComponents
{
    [Contract]
    public class QualifyingParty
    {
        /// <summary>
        /// The number of people employed by the economic operator participating in the tender.
        /// </summary>
        public QuantityType EmployeeQuantity { get; set; }

        /// <summary>
        /// The text describing one official classification assigned by an official list or (pre)qualification system to the economic operator.
        /// </summary>
        public BusinessClassificationScheme BusinessClassificationScheme { get; set; }

        /// <summary>
        /// A monetary amount as a measure of this capability.
        /// </summary>
        public AmountType ValueAmount { get; set; }

        /// <summary>
        /// Text describing the works, supplies or services executed, delivered or performed in a procurement project (normally used as a reference for the classification of the economic operator.
        /// </summary>
        public CompletedTask CompletedTask { get; set; }

        /// <summary>
        /// The identifier of the economic operator in an official list, register or (pre)qualification system.
        /// </summary>
        public PartyIdentification ID { get; set; }
    }
}