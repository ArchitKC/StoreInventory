using System;
using System.Collections.Generic;
using System.Data.Entity;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using StoreInventory.Models.ViewModel;
using StoreInventory.Services.Interfaces;

namespace StoreInventory.Services.Test
{
    [TestClass]
    public class ProductServicesTest
    {
        [TestInitialize]
        public void getProductView()
        {
            List<ProductDetailsViewModel> inventoryExpected = new List<ProductDetailsViewModel> {
                    new ProductDetailsViewModel
                    {
                        Id= 1,
                        Product = "Shirt"
                    },
                    new ProductDetailsViewModel
                    {
                        Id=2,
                        Product = "Pant"
                    }
                };
        }
        [TestMethod]
        public void GetMethodwithNull()
        {
            int Id = 1;

            Mock<IProductServices> mockItem = new Mock<IProductServices>();
            mockItem.Setup(t =>t.getProducts(It.IsAny<int>())).
                    Returns(new ProductDetailsViewModel() { Id = 1, Product = "Shirt" });

            ProductServices productServices = new ProductServices();
            var getItem = productServices.getProducts();

            Assert.IsTrue(getItem.Count == 0);
        }
    }
}
