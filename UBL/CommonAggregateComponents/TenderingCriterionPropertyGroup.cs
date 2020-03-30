﻿using System.ComponentModel.DataAnnotations;
using Hilma.UBL.Attributes;
using Hilma.UBL.UnqualifiedDataTypes;

namespace Hilma.UBL.CommonAggregateComponents
{
  [Contract]
  public class TenderingCriterionPropertyGroup
  {
    /// <summary>
    /// Identifies a group of requirements uniquely.
    /// </summary>
    /// <remarks>
    /// Rule: Compulsory use of the UUIDs supplied by e-Certis. See also the spreadsheets Criteria Taxonomy (Regulated ESPD) and Criteria Taxonomy (Self-contained ESPD).
    /// </remarks>
    [Required]
    public IdentifierType Id { get; set; }

    /// <summary>
    /// The name of the group.
    /// </summary>
    public NameType[] Name { get; set; }

    /// <summary>
    /// The textual description for this group.
    /// </summary>
    public TextType[] Description { get; set; }

    /// <summary>
    /// Code addressed to control the behavior of the group of criteria.
    /// </summary>
    /// <remarks>
    /// Rule: Compulsory use of the Code List PropertyGroupType. See sections below about the 'criteria data structures' and the XML examples on exclusion and selection criteria to understand the use of this code. Beware that the first element inside a group of properties (after the group ID) is always a cac:TenderingCriterionProperty. In some occasions this might entail the use of an empty CAPTION element, for instance, to produce groups of subgroups where no property does really makes sense in the first group. See also the sub-section The ONTRUE/ONFALSE codes for GROUP and SUBGROUP control
    /// </remarks>
    [Required]
    public CodeType PropertyGroupTypeCode { get; set; }

    /// <summary>
    /// A code signifying how this group of criteria have been fulfilled.
    /// </summary>
    public CodeType FulfilmentIndicatorTypeCode { get; set; }

    /// <summary>
    /// Caption (i.e. a 'label'), specific MS or contracting authority requirement (e.g. 'Number of references expected: 5' or a question addressed to the economic operator (e.g. 'Your average yearly turnover for the past three years?'.
    /// </summary>
    /// <remarks>
    /// Rule: See the rules for the class in the tables below to see the rules related to criterion properties. See also the XML examples provided in sections about exclusion and selection criteria.
    /// </remarks>
    [Required]
    public TenderingCriterionProperty[] TenderingCriterionProperties { get; set; }

    /// <summary>
    /// A second, third or n-level group inside a first level group of properties.
    /// </summary>
    /// <remarks>
    /// Rule: subsidiary property groups 'are' property groups (i.e. it is the same component but qualified as 'subsidary'). Therefore all the rules applicable to property groups are also applicable to sub-groups: Compulsory use of the Code List PropertyGroupType. See sections below about the 'criteria data structures' and the XML examples on exclusion and selection criteria to understand the use of this code. Beware that the first element inside a group of properties (after the group ID) is always a cac:TenderingCriterionProperty. In some occasions this might entail the use of an empty CAPTION element, for instance, to produce groups of subgroups where no property does really makes sense in the first group.
    /// </remarks>
    public TenderingCriterionPropertyGroup[] SubsidiaryTenderingCriterionPropertyGroups { get; set; }

  }
}