﻿using System.Collections.Generic;
using Hilma.UBL.Attributes;

namespace Hilma.Espd.EDM.CodeLists
{
    [Contract]
    public class CodeListContract
    {
        public string ShortName { get; set; }
        public string LongName { get; set; }
        public CodeContract[] Codes { get; set; }
        public string AgencyId { get; set; }
        public string Version { get; set; }
    }
}
