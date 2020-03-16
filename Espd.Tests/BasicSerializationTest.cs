using System;
using Espd.Serializers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using UBL.CommonAggregateComponents;
using UBL.UnqualifiedDataTypes;

namespace Espd.Tests
{

  public class EspdDocumentHelper
  {
    public static QualificationApplicationRequest SimpleTest =>
      new QualificationApplicationRequest()
      {
        ID = "12345",
        TenderingCriteria = new[] { new TenderingCriterion()
          {
            Id = "12323",
            CriterionTypeCode = "FOO",
            Description = new TextType[] { "Kuvaus" },
            Legislations = new [] {
              new Legislation()
              {
                ID = new IdentifierType("ecertis guid"),
                Descriptions = new TextType[]{ "Lakijuttuja"},
                Titles = new TextType[] { "Lakiperuste x." },

              }
            },
            TenderingCriterionPropertyGroups = new []
            {
              new TenderingCriterionPropertyGroup()
              {
                Id = "123",
                Name = new NameType[] { "Ryhmä 1." },
                Description = new TextType [] { "Foo" },
                PropertyGroupTypeCode = "C0",
                TenderingCriterionProperties = new []{ new TenderingCriterionProperty()
                {
                  Id = "221",
                  Name = "Kysymys x",
                  Description = "Kuvaus",
                  TypeCode = "F",
                }}
              }
            }
          }
        }
      };

    public static QualificationApplicationRequest SCAbilitiesStaffSelfContainedRequest =>

      new QualificationApplicationRequest() { };

  }

  [TestClass]
  public class EspdSerializerTest
  {
    [TestMethod]
    public void TestSimpleRequest()
    {

      var request = new QualificationApplicationRequest()
      {
        ID = "12345",
        TenderingCriteria = new[] { new TenderingCriterion()
                            {
                              Id = "12323",
                              CriterionTypeCode = "FOO",
                              Description = new TextType[] { "Kuvaus" },
                              Legislations = new [] { 
                                new Legislation()
                                {
                                  ID = new IdentifierType("ecertis guid"),
                                  Descriptions = new TextType[]{ "Lakijuttuja"},
                                  Titles = new TextType[] { "Lakiperuste x." },
                                  
                                }
                              },
                              TenderingCriterionPropertyGroups = new []
                              {
                                new TenderingCriterionPropertyGroup()
                                {
                                  Id = "123",
                                  Name = new NameType[] { new NameType() { Value= "Ryhm� 1." }  },
                                  Description = new TextType [] { "Foo" },
                                  PropertyGroupTypeCode = "C0",
                                  TenderingCriterionProperties = new []{ new TenderingCriterionProperty()
                                  {
                                    Id = "221",
                                    Name = new NameType(){Value = "Kysymys x" },
                                    Description = new TextType(){Value= "Kuvaus" },
                                    TypeCode = "F",
                                  }}
                                }
                              }
                            }
        }
      };
      var result = request.Serialize();


      Assert.IsNotNull(result);

      Console.WriteLine(result);

      Console.WriteLine( JsonConvert.SerializeObject(request, Formatting.Indented, new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, DateFormatHandling = DateFormatHandling.IsoDateFormat }));

    }
  }
}
