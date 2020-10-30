using System;
using Espd.Test.Common;
using Hilma.Espd.EDM.CriterionModels;
using Hilma.Espd.EDM.CriterionModels.v2_1_1.Identifiers;
using Hilma.UBL.CommonAggregateComponents;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Espd.Tests
{
    [TestClass]
    public class QualificatonApplicationResponseTests
    {
        [TestMethod]
        public void CreateResponseFromRequest() {

            var model = new CriterionFactory();
            var request = Create.CriteriaTaxonomyExtendedV2_1_1;

            var factory = new QualificationApplicationFactory();
            var espdUrl = "http://localhost/espd/";
            var response = factory.CreateEspd2_1_1ExtendedResponse(
                request, 
                Create.EconomicOperatorParty(),
                new EuComGrowId(Guid.NewGuid()),
                Guid.NewGuid(),
                espdUrl, 
                "FI"
            );
            
            // Test references
            Assert.AreEqual(2, response.AdditionalDocumentReferences.Length, "Should have 2 references" );   
            var reference = response.AdditionalDocumentReferences[1];
        
            Assert.AreEqual(request.ID.Value, reference.ID.Value);
            Assert.AreEqual(request.UUID.Value, reference.UUID.Value);
            Assert.AreEqual("ESPD_REQUEST", reference.DocumentTypeCode.Value);
            Assert.AreEqual(request.IssueDate.Value, reference.IssueDate.Value);
            Assert.AreEqual(request.IssueTime.ToString(), reference.IssueTime.ToString());

            // Test Lot responses init
            Assert.AreEqual(1, response.TenderingCriterionResponses.Length, "Should have one response initialized");
            var criterionResponse = response.TenderingCriterionResponses[0];
            Assert.AreEqual( "0", criterionResponse.ResponseValue?[0].ResponseID.Value, "Lot id should be set to 0" );
        }

        [TestMethod]
        public void CreateResponseFromRequest_WithLots() {

            var model = new CriterionFactory();
            var request = Create.CriteriaTaxonomyExtendedV2_1_1;
            request.ProcurementProjectLots = new [] {
                new ProcurementProjectLot() { 
                    ID = new Hilma.UBL.UnqualifiedDataTypes.IdentifierType("1"),
                },
                new ProcurementProjectLot() { 
                    ID = new Hilma.UBL.UnqualifiedDataTypes.IdentifierType("2"),
                }
            };
            var factory = new QualificationApplicationFactory();
            var espdUrl = "http://localhost/espd/";
            var response = factory.CreateEspd2_1_1ExtendedResponse(
                request, 
                Create.EconomicOperatorParty(),
                new EuComGrowId(Guid.NewGuid()),
                Guid.NewGuid(),
                espdUrl, 
                "FI"
            );
                       
            // Test Lot responses no init
            Assert.AreEqual(0, response.TenderingCriterionResponses.Length, "Should have no responses initialized because of lots");
        }
    }
}