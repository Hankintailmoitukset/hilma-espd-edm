using System.Collections.Generic;
using Hilma.UBL.Attributes;

namespace Hilma.Espd.EDM.CodeLists
{
    [Contract]
    public class CodeListContract
    {
        public string ShortName { get; set; }
        public string LongName { get; set; }
        public List<CodeContract> Codes { get; set; }
        public string Identifier { get; set; }
        public string Version { get; set; }
    }
}
