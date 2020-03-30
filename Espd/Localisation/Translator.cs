using System;
using Hilma.UBL.CommonAggregateComponents;
using Hilma.Espd.EDM.Localisation;
using System.Collections.Generic;
using Hilma.UBL.UnqualifiedDataTypes;

namespace espd.service.Controllers
{
    public class Translator : IModelTranslator
    {
        private readonly IDictionary<string, string> _translations;

        public Translator(IDictionary<string, string> translations)
        {
            _translations = translations;
        }

        public TenderingCriterion TranslateCriterion(TenderingCriterion tenderingCriterion)
        {
            if(tenderingCriterion.Name != null)
            {
                tenderingCriterion.Name.Value = Translate(tenderingCriterion.Name);
            }
            
            if(tenderingCriterion.Description != null)
            {
                tenderingCriterion.Description = Translate(tenderingCriterion.Description);
            }
            
            if(tenderingCriterion.SubTenderingTenderingCriteria != null)
            {
                foreach (var subCriteria in tenderingCriterion.SubTenderingTenderingCriteria)
                {
                    TranslateCriterion(subCriteria);
                }
            }
            
            if(tenderingCriterion.TenderingCriterionPropertyGroups != null)
            {
                foreach (var propertyGroup in tenderingCriterion.TenderingCriterionPropertyGroups)
                {
                    TranslateCriterionPropertryGroup(propertyGroup);
                }
            }

            return tenderingCriterion;
        }

        private void TranslateCriterionPropertryGroup(TenderingCriterionPropertyGroup propertyGroup)
        {
            if(propertyGroup.Name != null)
            {
                propertyGroup.Name.Value = Translate(propertyGroup.Name);
            }

            if(propertyGroup.Description !=null && propertyGroup.Description.Length > 0)
            {
                propertyGroup.Description = Translate(propertyGroup.Description);
            }

            foreach (var property in propertyGroup.TenderingCriterionProperties)
            {
                TranslateProperty(property);
            }

            if(propertyGroup.SubsidiaryTenderingCriterionPropertyGroups != null)
            {
                foreach (var subPropertyGroup in propertyGroup.SubsidiaryTenderingCriterionPropertyGroups)
                {
                    TranslateCriterionPropertryGroup(subPropertyGroup);
                }
            }
        }

        private void TranslateProperty(TenderingCriterionProperty property)
        {
            if(property.Name != null)
            {
                property.Name.Value = Translate(property.Name);
            }
            if(property.Description != null)
            {
                property.Description = Translate(property.Description.Value);
            }
        }

        private TextType[] Translate(TextType[] textTypes)
        {
            foreach (var text in textTypes)
            {
                text.Value = Translate(text);
            }

            return textTypes;
        }

        private string Translate(string translationKey)
        {
            var translation = _translations.ContainsKey(translationKey) ? _translations[translationKey] : translationKey;
            return translation;
        }

    }
}