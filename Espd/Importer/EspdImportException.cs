namespace Hilma.Espd.EDM.Importer
{
    public class EspdImportException : System.Exception
    {
        public EspdImportException() { }
        public EspdImportException(string message) : base(message) { }
        public EspdImportException(string message, System.Exception inner) : base(message, inner) { }
        protected EspdImportException(
            System.Runtime.Serialization.SerializationInfo info,
            System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}