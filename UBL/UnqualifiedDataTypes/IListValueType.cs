using System;

namespace Hilma.UBL.UnqualifiedDataTypes
{
  public interface IListValueType
  {
    /// <summary>
    /// The identification of a list of codes.
    /// </summary>
    string ListID { get; set; }

    /// <summary>
    /// The name of a list of codes.
    /// </summary>
    string ListName { get; set; }

    /// <summary>
    /// An agency that maintains one or more lists of codes.
    /// </summary>
    /// <remarks>Defaults to the UN/EDIFACT data element 3055 code list.</remarks>
    string ListAgencyID { get; set; }

    /// <summary>
    /// The name of the agency that maintains the list of codes.
    /// </summary>
    string ListAgencyName { get; set; }

    /// <summary>
    /// The version of the list of codes.
    /// </summary>
    string ListVersionID { get; set; }

    /// <summary>
    /// he Uniform Resource Identifier that identifies where the code list is located.
    /// </summary>
    Uri ListURI { get; set; }

    /// <summary>
    /// The Uniform Resource Identifier that identifies where the code list scheme is located.
    /// </summary>
    Uri ListSchemeURI { get; set; }
  }
}