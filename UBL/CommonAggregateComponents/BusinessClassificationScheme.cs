﻿using System;
using System.Xml.Linq;
using Hilma.UBL.Attributes;
using Hilma.UBL.Serializers;
using Hilma.UBL.UnqualifiedDataTypes;

namespace Hilma.UBL.CommonAggregateComponents
{
    [Contract]
    public class BusinessClassificationScheme
    {
        public IdentifierType ID { get; set; }
        
        /// <summary>
        /// The text describing one official classification assigned by an official list or (pre)qualification system to the economic operator.
        /// </summary>
        public string[] Description { get; set; }

        public ClassificationCategory ClassificationCategory { get; set; }

        public XElement Serialize() {
          return new XElement(UblNames.Cac + nameof(BusinessClassificationScheme),
            ID.Serialize(nameof(ID)),
            Description.Serialize(nameof (Description)),
            ClassificationCategory?.Serialize()
            );
        }
    }
}