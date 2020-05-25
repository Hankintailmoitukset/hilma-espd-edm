using System.Collections.Generic;

namespace CodelistParser
{
    public class Codelist
    {
        public string ShortName { get; set; }
        public string LongName { get; set; }
        public List<Codes> Codes { get; set; }
    }
    public class Codes
    {
        public string Code { get; set; }
        public string Name { get; set; }
    }
}
