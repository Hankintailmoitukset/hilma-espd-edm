using System;
using System.Collections.Generic;
using System.Linq;
using Espd.Test.Common;
using Hilma.Espd.EDM.Serializers;
using Hilma.UBL.CommonAggregateComponents;
using Hilma.UBL.Serializers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;

namespace Hilma.Espd.Tests
{
  
  [TestClass]
  public class SerializationTests
  {

    [TestInitialize]
    public void Initialize()
    {
    }
    
    [TestMethod]
    public void TestSimpleRequest()
    {
      var request = Create.SimpleQualificationApplicationRequest;
      var result = request.Serialize();

      Assert.IsNotNull(result);
      Console.WriteLine(result);
      Console.WriteLine( JsonConvert.SerializeObject(request, Formatting.Indented, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore, DateFormatHandling = DateFormatHandling.IsoDateFormat }));

    }

    [TestMethod]
    public void TestScAbilitiesStaffSelfContainedRequest()
    {
      var request = Create.ScAbilitiesStaffSelfContainedRequest;
      var result = request.Serialize();

      Assert.IsNotNull(result);
      Console.WriteLine(result);
      Console.WriteLine( JsonConvert.SerializeObject(request, Formatting.Indented, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore, DateFormatHandling = DateFormatHandling.IsoDateFormat }));

    }

    [TestMethod]
    public void TestResponse()
    {
      // Arrange
      var response = Create.QualificationApplicationResponse();

      // Act
      var result = response.Serialize();

      // Assert
      Assert.IsNotNull(result, "Document was null");
      Assert.IsNotNull(result.Root, "Document root was null");
      Console.WriteLine(result);
      Assert.AreEqual(EspdNames.Qarp+"QualificationApplicationResponse", result.Root.Name, "Root element name incorrect");
    }
    

    [TestMethod]
    public void TestRequest()
    {
        var request = Create.CriteriaTaxonomyExtendedV2_1_1;
        var result = request.Serialize();

        Assert.IsNotNull(result);
        Console.WriteLine(result);
        Console.WriteLine(JsonConvert.SerializeObject(request, Formatting.Indented, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore, DateFormatHandling = DateFormatHandling.IsoDateFormat }));

    }

    [TestMethod]

    public void TestAddressLinesSerialize() 
    {
      /* <AddressLine xmlns="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2">
           <Line xmlns="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2">Osoitetie 23B</Line>
         </AddressLine>
      */

      var address = new Address() {
        AddressLines = new string[] {
          "Osoitetie 23B"
        }
      };

      var result = address.SerializeAddressLines();
      PrintResult(result);

      Assert.IsNotNull(result, "Result is null");
      
      var elements = result.ToList();
      Assert.AreEqual(1, elements.Count, "Should have one element");
      Assert.AreEqual(UblNames.Cac+"AddressLine", elements[0].Name, "Element name");
      var line = elements[0].Element(UblNames.Cbc + "Line");
      Assert.IsNotNull(line, "Line is null");
      Assert.AreEqual("Osoitetie 23B", line.Value, "Address line value");
    }

    [TestMethod]
    public void TestAddressLinesSerialize_ArrayWithMultipleValues() {
      /* <AddressLine xmlns="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2">
            <Line xmlns="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2">Osoitekatu 12</Line>
         </AddressLine>
        <AddressLine xmlns="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2">
            <Line xmlns="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2">5. kerros</Line>
         </AddressLine>
        <AddressLine xmlns="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2">
            <Line xmlns="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2">Asunto 123</Line>
         </AddressLine>
      */
      var address = new Address() {
        AddressLines = new string[] {
          "Osoitekatu 12", "5. kerros", "Asunto 123"
        }
      };

      var result = address.SerializeAddressLines();
      PrintResult(result);

      Assert.IsNotNull(result, "Result is null");
      
      var elements = result.ToList();
      Assert.AreEqual(3, elements.Count, "Should have three elements");
      // Test first line
      Assert.AreEqual(UblNames.Cac + "AddressLine", elements[0].Name, "Element name");
      var line1 = elements[0].Element(UblNames.Cbc + "Line");
      Assert.IsNotNull(line1, "Line 1");
      Assert.AreEqual("Osoitekatu 12", line1.Value, "Address line value");
      // Test second line
      Assert.AreEqual(UblNames.Cac + "AddressLine", elements[1].Name, "Element name");
      var line2 = elements[1].Element(UblNames.Cbc + "Line");
      Assert.IsNotNull(line2, "Line 2");
      Assert.AreEqual("5. kerros", line2.Value, "Address line value");
      // Test third line 
      Assert.AreEqual(UblNames.Cac + "AddressLine", elements[2].Name, "Element name");
      var line3 = elements[2].Element(UblNames.Cbc + "Line");
      Assert.IsNotNull(line3, "Line 3");
      Assert.AreEqual("Asunto 123", line3.Value, "Address line value");
    }

    [TestMethod]
    public void TestAddressLinesSerialize_ArrayWithSingleEmptyLineValues() {
      /* <AddressLine xmlns="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2">
            <Line xmlns="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2">Osoitekatu 12</Line>
         </AddressLine>
        <AddressLine xmlns="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2">
            <Line xmlns="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2">Asunto 123</Line>
         </AddressLine>
      */
      var address = new Address() {
        AddressLines = new string[] {
          "Osoitekatu 12", "", "Asunto 123"
        }
      };

      var result = address.SerializeAddressLines();
      PrintResult(result);
      
      Assert.IsNotNull(result, "Result is null");
      
      var elements = result.ToList();
      Assert.AreEqual(2, elements.Count, "Should have two elements");
      
      // Test first line
      Assert.AreEqual(UblNames.Cac + "AddressLine", elements[0].Name, "Element name");
      var line1 = elements[0].Element(UblNames.Cbc + "Line");
      Assert.IsNotNull(line1, "Line 1");
      Assert.AreEqual("Osoitekatu 12", line1.Value, "Address line value");
     
      // Test third line 
      Assert.AreEqual(UblNames.Cac + "AddressLine", elements[1].Name, "Element name");
      var line3 = elements[1].Element(UblNames.Cbc + "Line");
      Assert.IsNotNull(line3, "Line 3");
      Assert.AreEqual("Asunto 123", line3.Value, "Address line value");
    }

    private void PrintResult(IEnumerable<System.Xml.Linq.XElement> result) {
      Console.WriteLine("Result:");
      if (result == null) {
        Console.WriteLine("null");
        return;
      }
      foreach(var element in result ) {
        Console.WriteLine(element.ToString());
      }
    }

    [TestMethod]
    public void TestAddressLinesSerialize_ArrayWithEmptyString() {
      var address = new Address() {
        AddressLines = new string[] {
          ""
        }
      };

      var result = address.SerializeAddressLines();

      PrintResult(result);
      Assert.IsNotNull(result, "Result is null");

      Assert.AreEqual(0, result.Count(), "Result should be empty");
    }

    [TestMethod]
    public void TestAddressLinesSerialize_ArrayWithMultipleEmptyStrings() {
      var address = new Address() {
        AddressLines = new string[] {
          "", "", ""
        }
      };

      var result = address.SerializeAddressLines();

      PrintResult(result);
      Assert.IsNotNull(result, "Result is null");

      Assert.AreEqual(0, result.Count(), "Result should be empty");
    }

    [TestMethod]
    public void TestAddressLinesSerialize_EmptyArray() {
      var address = new Address() {
        AddressLines = new string[] {
        }
      };

      var result = address.SerializeAddressLines();


      PrintResult(result);
      Assert.IsNotNull(result, "Result is null");

      Assert.AreEqual(0, result.Count(), "Result should be empty");
    }

    [TestMethod]
    public void TestAddressLinesSerialize_AddressLinesNull() {
      var address = new Address() {
        AddressLines = null
      };

      var result = address.SerializeAddressLines();


      PrintResult(result);
      Assert.IsNotNull(result, "Result is null");

      Assert.AreEqual(0, result.Count(), "Result should be empty");
    }

    [TestMethod]
    public void TestAddressLinesSerialize_ArrayWithNullValue() {
      var address = new Address() {
        AddressLines = new string[] {
          null
        }
      };

      var result = address.SerializeAddressLines();


      PrintResult(result);
      Assert.IsNotNull(result, "Result is null");

      Assert.AreEqual(0, result.Count(), "Result should be empty");
    }

    [TestMethod]
    public void TestPartyNameSerialize() {
      var name = new PartyName() {
        Name = "Porukkanimi"
      };

      var result = name.Serialize();

      Assert.IsNotNull(result, "Result is null");
    }

    [TestMethod]
    public void TestPartyNameSerialize_isNull() {
      var name = new PartyName() {
        Name = null
      };

      var result = name.Serialize();

      Assert.IsNull(result, "Result is not null");
    }

    [TestMethod]
    public void TestPartyNameSerialize_isEmpty() {
      var name = new PartyName() {
        Name = ""
      };

      var result = name.Serialize();

      Assert.IsNull(result, "Result is not null");
    }
  }
}
