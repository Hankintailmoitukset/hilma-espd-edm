﻿using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Xml.Linq;
using Hilma.UBL.Attributes;
using Hilma.UBL.Serializers;
using Hilma.UBL.UnqualifiedDataTypes;

namespace Hilma.UBL.CommonAggregateComponents
{
  [Contract]
  public class Legislation
  {
    /// <summary>
    /// An identifier to refer to the legislation.
    /// </summary>
    public IdentifierType ID { get; set; }

    /// <summary>
    /// Title of the legislation.
    /// </summary>
    /// <remarks>
    /// Rule: The complete title of the legislation provided as in the original legal text. At a later stage it might be provided by e-CERTIS (e.g.'DIRECTIVE 2014/24/EU OF THE EUROPEAN PARLIAMENT AND OF THE COUNCIL of 26 February 2014 on public procurement and repealing Directive 2004/18/EC'). Can be provided in several languages, but if LanguageID`not specified it defaults to `en (English).
    /// </remarks>
    [Required]
    public string Title { get; set; }

    /// <summary>
    /// Textual short description of the legislation.
    /// </summary>
    /// <remarks>
    /// Rule: The description of the legislation provided in the original legal text SHOULD be provided. At a later stage they might be provided by e-CERTIS. Can be provided in several languages, but if LanguageID`not specified it defaults to `en (English).
    /// </remarks>
    public string Description { get; set; }

    /// <summary>
    /// Jurisdictional level of a particular legislation.
    /// </summary>
    /// <remarks>
    /// Rule: Although this is a text, use the description in Code List LegislationType. Can be provided in several languages, but if LanguageID`not specified it defaults to `en (English).
    /// </remarks>
    public string JurisdictionLevel { get; set; }

    /// <summary>
    /// Textual description of the article of the legislation.
    /// </summary>
    /// <remarks>
    /// Rule: Other articles where the Criterion is referred to SHOULD also be provided. At a later stage they might be provided by eCERTIS. Can be provided in several languages, but if LanguageID`not specified it defaults to `en (English).
    /// </remarks>
    public string Article { get; set; }

    /// <summary>
    /// URI that points to a legislation related to this criterion.
    /// </summary>
    /// <remarks>
    /// Rule: In the case of European legislation, the URL MUST point at the multilingual EUR-LEX web-page; e.g. Directive 2014/24/EU.
    /// </remarks>
    public IdentifierType URI { get; set; } 

    /// <summary>
    /// The language of the legislation.
    /// </summary>
    public Language[] Languages { get; set; }

    /// <summary>
    /// The geopolitical region in which this legislation applies.
    /// </summary>
    public Address JurisdictionRegionAddress { get; set; }

    public XElement Serialize()
    {
      return new XElement(UblNames.Cac + nameof(Legislation),
        ID.Serialize(nameof(ID)),
        Title.Serialize(nameof(Title)),
        Description.Serialize(nameof(Description)),
        Article.Serialize(nameof(Article)),
        URI.Serialize(nameof(URI)),
        Languages?.Select( lang => lang.Serialize()),
        JurisdictionRegionAddress?.Serialize(nameof(JurisdictionRegionAddress))
      );
    }

  }
}