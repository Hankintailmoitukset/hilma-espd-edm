using System.Xml.Linq;
using Hilma.UBL.UnqualifiedDataTypes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Hilma.UBL.Serializers;

namespace Hilma.Espd.Tests {
  [TestClass]
  public class CommonBasicComponentExtensionTests {

    [TestMethod] 
    public void QuantityType_WithUnitAndValue_CorrectElementReturned() {
      // Arrange
      var quantityType = new QuantityType(0.3m) { UnitCode = "m" };

      // Act
      XElement element = quantityType.Serialize("Quantity");

      // Assert
      Assert.IsNotNull(element, $"{nameof(element)} was null");
      Assert.AreEqual(UblNames.Cbc+"Quantity", element.Name, "element.name was wrong");
      Assert.AreEqual("0.3", element.Value, "element.value was wrong");
      var unitCode = element.Attribute("unitCode");
      Assert.IsNotNull(unitCode, "unitCode attribute was not null");
      Assert.AreEqual("m", unitCode.Value);
    }

    [TestMethod]
    public void QuantityType_WithNull_ReturnsNull() {
      // Arrange
      QuantityType quantity = null;

      // Act
      XElement element = quantity.Serialize("Quantity");

      // Assert
      Assert.IsNull(element, "element should be null when quantitytype is null");
    }
  }
}
