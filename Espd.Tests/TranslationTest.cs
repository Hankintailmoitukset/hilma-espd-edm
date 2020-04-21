using System.Collections.Generic;
using System.Linq;
using Hilma.Espd.EDM.CriterionModel;
using Hilma.Espd.EDM.Localisation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Hilma.Espd.Tests
{

    [TestClass]
    public class TranslationTest
    {
        [TestMethod]
        public void TestTranslationHelper()
        {
            //returns defult translations
            var translationDictionary = LocalisationHelper.ParseDefaultLocalisation();
            Assert.IsNotNull(translationDictionary);

        }
        [TestMethod]
        public void TestTranslationHelperWithValue()
        {
            var json = "{\"key1\":\"value1\",\"key2\":\"value2\",\"key3\":\"value3\",}";
            //returns given translation
            var translationDictionary = LocalisationHelper.ParseLocalisation(json);

            Assert.IsNotNull(translationDictionary);
        }

        [TestMethod]
        public void TestTranslationCriteria()
        {

            var translationDictionary = new Dictionary<string, string>()
            {
                {"convictions.participationInCriminalOrganisation.name","Participation in a criminal organisation"},
                {"convictions.participationInCriminalOrganisation.description","Has the economic operator breached its obligations relating to the payment of taxes, both in the country in which it is established and in Member State of the contracting authority or contracting entity if other than the country of establishment?" }
            };

            var translator = new Translator(translationDictionary);
            var criterionSpecificaton = new CriterionSpecification();
            var criterion = criterionSpecificaton.ExclusionGrounds.Convictions.First();
            var translatedCriterion = translator.TranslateCriterion(criterion);

            Assert.AreEqual("Participation in a criminal organisation", translatedCriterion.Name);
            Assert.AreEqual("Has the economic operator breached its obligations relating to the payment of taxes, both in the country in which it is established and in Member State of the contracting authority or contracting entity if other than the country of establishment?", translatedCriterion.Description.First());

        }

        [TestMethod]
        public void TestExclusionCriteria()
        {
            var translationDictionary = LocalisationHelper.ParseDefaultLocalisation();
            var translator = new Translator(translationDictionary);

            var criterionSpecificaton = new CriterionSpecification();
            var criterion = criterionSpecificaton.ExclusionGrounds.Contributions.First();

            var translatedCriterion = translator.TranslateCriterion(criterion);

            Assert.AreEqual("Payment of taxes", criterion.Name);
            AssertDescription("Has the economic operator breached its obligations relating to the payment of taxes, both in the country in which it is established and in Member State of the contracting authority or contracting entity if other than the country of establishment?",  translatedCriterion.Description);
            
            Assert.AreEqual("Threshold", criterion.TenderingCriterionPropertyGroups.First().TenderingCriterionProperties.First().Description);


            Assert.AreEqual("Your answer", criterion.TenderingCriterionPropertyGroups.First().SubsidiaryTenderingCriterionPropertyGroups.First().TenderingCriterionProperties.First().Description);
            Assert.AreEqual("Country or member state concerned", criterion.TenderingCriterionPropertyGroups.First().SubsidiaryTenderingCriterionPropertyGroups.First().SubsidiaryTenderingCriterionPropertyGroups.First().TenderingCriterionProperties.First().Description);

        }

        [TestMethod]
        public void TestExclusionCriteriaMisinterpretation()
        {
            var translationDictionary = LocalisationHelper.ParseDefaultLocalisation();
            var translator = new Translator(translationDictionary);

            var criterionSpecificaton = new CriterionSpecification();
            var criterion = criterionSpecificaton.ExclusionGrounds.Misinterpretation.First();

            var translatedCriterion = translator.TranslateCriterion(criterion);

            Assert.AreEqual("Guilty of misinterpretation, withheld information, unable to provide required documents and obtained confidential information of this procedure", criterion.Name);
            AssertDescription(new[] {"Can the economic operator confirm that:",
                                     "a) It has been guilty of serious misrepresentation in supplying the information required for the verification of the absence of grounds for exclusion or the fulfilment of the selection criteria,",
                                     "b) It has withheld such information,",
                                     "c) It has not been able, without delay, to submit the supporting documents required by a contracting authority or contracting entity, and"
                                    }, translatedCriterion.Description);

        }

        private void AssertDescription(string excpectedValue, string[] textTypes)
        {
            AssertDescription(new[] { excpectedValue }, textTypes);
        }

        private void AssertDescription(string[] excpectedValue, string[] textTypes)
        {
            Assert.AreEqual(excpectedValue.Length, textTypes.Length,"List length not match");
            CollectionAssert.AreEqual(excpectedValue, (from o in textTypes select o.ToString()).ToArray());
        }


    }
}
