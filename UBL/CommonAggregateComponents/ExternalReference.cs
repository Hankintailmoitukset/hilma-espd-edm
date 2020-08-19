using System.Xml.Linq;
using Hilma.UBL.Attributes;
using Hilma.UBL.Serializers;
using Hilma.UBL.UnqualifiedDataTypes;

namespace Hilma.UBL.CommonAggregateComponents
{
  [Contract]
  public class ExternalReference
  {
    /// <summary>
    ///The Uniform Resource Identifier(URI) that identifies where the document is located.
    /// </summary>
    public IdentifierType URI { get; set; }
    
    public string DocumentHash { get; set; }
    public string HashAlgorithmMethod { get; set; }
    public DateType ExpiryDate { get; set; }
    public TimeType ExpiryTime { get; set; }
    public CodeType MimeCode { get; set; }
    public CodeType FormatCode { get; set; }
    public CodeType EncodingCode { get; set; }

    public CodeType CharacterSetCode { get; set; }

    /// <summary>
    /// The title of the document. 
    /// </summary>
    /// <remarks>Originally this field is the placeholder for the name of the file (e.g. PLACE-ContractNotice-2017-12452.xml.
    /// However, as the UBL component does not have a placeholder for a name or title, the ESPD documents use it for a short descriptive title of the document being referenced.
    /// </remarks>
    public string FileName { get; set; }

    /// <summary>
    /// Short description of the document.
    /// </summary>
    /// <remarks> If the document being referenced is a Notice being published on TED, use two description lines. Use the second description line to place therein the temporary number received from TED.
    /// See example and comments below.</remarks>
    /// <example>
    /// <cbc:Description>Repair and maintenance services. Real estate services.</cbc:Description> 
    /// <cbc:Description>293520-2017</cbc:Description>
    /// </example>
    public string[] Description { get; set; }

    public XElement Serialize()
    {
      return new XElement( UblNames.Cac + nameof(ExternalReference),
        URI.Serialize(nameof(URI)),
        DocumentHash.Serialize(nameof(DocumentHash)),
        HashAlgorithmMethod.Serialize(nameof(HashAlgorithmMethod)),
        ExpiryDate.Serialize(nameof(ExpiryDate)),
        ExpiryTime.Serialize(nameof(ExpiryTime)),
        MimeCode.Serialize(nameof(MimeCode)),
        FormatCode.Serialize(nameof(FormatCode)),
        EncodingCode.Serialize(nameof(EncodingCode)),
        CharacterSetCode.Serialize(nameof(CharacterSetCode)),
        FileName.Serialize(nameof(FileName)),
        Description.Serialize(nameof(Description))
        );
    }

  }

}