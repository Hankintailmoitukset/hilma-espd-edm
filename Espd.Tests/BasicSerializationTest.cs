using System;
using Espd.Serializers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using UBL.CommonAggregateComponents;
using UBL.UnqualifiedDataTypes;

namespace Espd.Tests
{
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
                                  Name = new [] { "Ryhmä 1." },
                                  Description = new [] { "Foo" },
                                  PropertyGroupTypeCode = "C0",
                                  TenderingCriterionProperties = new []{ new TenderingCriterionProperty()
                                  {
                                    Id = "221",
                                    Name = new [] { "Kysymys x" },
                                    Description = new []{ "Kuvaus"},
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
