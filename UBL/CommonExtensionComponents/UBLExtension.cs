using System;
using Hilma.UBL.Attributes;
using Hilma.UBL.UnqualifiedDataTypes;

namespace Hilma.UBL.CommonExtensionComponents
{
  /// <summary>
  ///  A single extension for private use.
  /// </summary>
  [Contract]
  public class UBLExtension
  {
    /// <summary>
    /// An identifier for the Extension assigned by the creator of the extension.
    /// </summary>
    public IdentifierType ID { get; set; }

    /// <summary>
    ///  A name for the Extension assigned by the creator of the extension.
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// An agency that maintains one or more Extensions.
    /// </summary>
    public IdentifierType ExtensionAgencyID { get; set; }

    /// <summary>
    ///  The name of the agency that maintains the Extension.
    /// </summary>
    public string ExtensionAgencyName { get; set; }

    /// <summary>
    /// The version of the Extension.
    /// </summary>
    public IdentifierType ExtensionVersionID { get; set; }

    /// <summary>
    /// A URI for the Agency that maintains the Extension.
    /// </summary>
    public IdentifierType ExtensionAgencyURI { get; set; }

    /// <summary>
    /// A code for reason the Extension is being included.
    /// </summary>
    public CodeType ExtensionReasonCode { get; set; }

    /// <summary>
    /// A description of the reason for the Extension.
    /// </summary>
    public string ExtensionReason { get; set; }

    /// <summary>
    /// The definition of the extension content.
    /// </summary>
    public Object ExtensionContent { get; set; }
  }
}