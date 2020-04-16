using System.Collections.Generic;
using System.Linq;
using Hilma.UBL.CommonAggregateComponents;

namespace Hilma.Espd.EDM.Localisation
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
                tenderingCriterion.Name = Translate(tenderingCriterion.Name);
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
                propertyGroup.Name = Translate(propertyGroup.Name);
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
                property.Name = Translate(property.Name);
            }
            if(property.Description != null)
            {
                property.Description = Translate(property.Description);
            }
        }

        private string[] Translate(string[] textTypes)
        {
          return textTypes?.Select(Translate).ToArray();
        }

        private string Translate(string translationKey)
        {
            var translation = _translations.ContainsKey(translationKey) ? _translations[translationKey] : translationKey;
            return translation;
        }

    }
}