using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StoreInventory.Controllers;

namespace StoreInventory.Tests.Controllers
{
    [TestClass]
    public class ProductControllerTest
    {
        [TestMethod]
        public void Index()
        {
            // Arrange
            ProductController controller = new ProductController();

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

         
    }
}
