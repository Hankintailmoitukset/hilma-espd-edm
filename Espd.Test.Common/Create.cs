using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Hilma.Espd.EDM.CriterionModels;
using Hilma.Espd.EDM.CriterionModels.v2_1_1.Examples;
using Hilma.Espd.EDM.CriterionModels.v2_1_1.Identifiers;
using Hilma.UBL.CommonAggregateComponents;
using Hilma.UBL.UnqualifiedDataTypes;

namespace Espd.Test.Common
{
  public class Create
  { 


    public static QualificationApplicationResponse QualificationApplicationResponse()
    {
      var request = EspdDocumentHelper.ScAbilitiesStaffSelfContainedRequest;
      var factory = new QualificationApplicationFactory();

      var response = factory.CreateEspd2_1_1ExtendedResponse(request, EconomicOperatorParty(),
        new EuComGrowId(Guid.NewGuid()),
        new IdentifierType("TEST-REF-111") { SchemeAgencyID = "TEST" },
        Guid.NewGuid());

      var evidences = new [] { 
        new Evidence()
        {
          ID = EuComGrowId.Random(),
          Description = new[] {"Evidence stuff"},
          DocumentReference = new DocumentReference[]
          {
            new DocumentReference()
            {
              ID = EuComGrowId.Random(),
              IssuerParty = new Party()
              {
                PartyName = new PartyName()
                {
                  Name = "Issuer"
                }
              }
            }
          }
        }
      };
      response.Evidences = evidences;
      response.TenderingCriterionResponses = CreateResponses(response).ToArray();
     
      return response;
    }

    public static EconomicOperatorParty EconomicOperatorParty()
    {
      return new EconomicOperatorParty
      {
        QualifyingParty = new QualifyingParty()
        {
          BusinessClassificationScheme = new BusinessClassificationScheme()
          { 
            ID = EuComGrowId.Random(),
            Description = new string[] { "My description" },
            ClassificationCategory = new ClassificationCategory()
          },
          EmployeeQuantity = new QuantityType() { Value = 10 },
          FinancialCapability = new FinancialCapability()
          {
            ValueAmount = new AmountType(1000000m) { CurrencyID = "EUR", CurrencyCodeListVersionID = "1.0" }
          },
          Party = new Party()
          {
            IndustryClassificationCode = new CodeType(),
            PartyIdentification = new PartyIdentification
            {
              ID = new IdentifierType("FI1234560") { SchemeID = "VAT", SchemeAgencyID = "VIES" }
            }
          }
        },
        EconomicOperatorRole = new EconomicOperatorRole()
        {
          RoleCode = new EuComGrowCodeType("SCLE") { ListID = "EORoleType" },
          RoleDescription = new string[0]
        },
        Party = new Party
        {
          PartyIdentification = new PartyIdentification
          {
            ID = new IdentifierType("FI1234560") { SchemeID = "VAT", SchemeAgencyID = "VIES" }
          },
          WebsiteURI = new IdentifierType("http://foo.fi"),
          PartyName = new PartyName
          {
            Name = "Foo business"
          },
          PostalAddress = new Address
          {
            AddressLines = new[] { "Foo str 1" },
            CityName = "Foocity",
            PostalZone = "00100",
            Country = new Country
            {
              IdentificationCode = new EuComGrowCodeType
              {
                ListVersionID = "1.0",
                ListAgencyID = "ISO",
                ListName = "CountryCodeIdentifier",
                ListID = "CountryCodeIdentifier",
                Value = "FI"
              },
              Name = "Finland"
            }
          },
          Contact = new Contact
          {
            Name = "Mr. Foo",
            ElectronicMail = "info@foo.fi",
            Telephone = "+3580441234455"
          },
          PowerOfAttorneys = new PowerOfAttorney[]
          {
            new PowerOfAttorney()
            {
              AgentParty = new Party()
              {
                Person = new Person()
                {
                  FirstName = "Foo",
                  FamilyName = "Foobar",
                  ResidenceAddress = new Address()
                  {
                    AddressLines = new[] {"Fooavenue 1"},
                    CityName = "Foocity",
                    Country = new Country()
                  }

                }
              },
            }
          }
        }
      };
    }

    public static IEnumerable<TenderingCriterionResponse> CreateResponses(QualificationApplicationResponse response)
    {
      foreach (var property in response.TenderingCriteria.SelectMany(c => c.DescendantProperties().Where(p => p.TypeCode.Equals(CriterionElementType.Question))))
      {
        var isPeriod = property.ValueDataTypeCode.Equals(ResponseDataTypeCode.Period);
        yield return new TenderingCriterionResponse()
        {
          ID = EuComGrowId.Random(),
          ValidatedCriterionPropertyID = property.ID,
          EvidenceSupplied = new EvidenceSupplied()
          {
            ID = new IdentifierType( response.Evidences[0].ID.Value )
          },
          ApplicablePeriod = isPeriod ? new Period() { StartDate = new DateTime(2020, 1, 1), EndDate = new DateTime(2020, 12, 31) } : null,
          ResponseValue = !isPeriod ? new[] { CreateResponseValue(property) } : new ResponseValue[0]
        };
      }
    }

    public static ResponseValue CreateResponseValue(TenderingCriterionProperty property)
    {
      var responseValue = new ResponseValue() { ID = EuComGrowId.Random() };

      switch (property.ValueDataTypeCode.Value)
      {
        case "AMOUNT":
          responseValue.ResponseAmount = new AmountType(100m);
          break;
        case "QUANTITY":
          responseValue.ResponseQuantity = new QuantityType(200m);
          break;
        case "CODE":
          responseValue.ResponseCode = new CodeType("FOO");
          break;
        case "MEASURE":
          responseValue.ResponseMeasure = new MeasureType(123, "m");
          break;
        case "DATE":
          responseValue.ResponseDate = new DateType(new DateTime(2020, 1, 1));
          break;
        case "INDICATOR":
          responseValue.ResponseIndicator = true;
          break;
        default:
          responseValue.Description = new[] { "Some description" };
          break;
      }

      return responseValue;
    }
  }
}