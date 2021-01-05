using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StoreInventory.Services.Test
{
    [TestClass]
    public class UserDetailsServicesTest
    {
        [TestMethod]
        public void CreditCardNumberIsNull()
        {
            string creditCardNumber = string.Empty;
            int id = 1;
            UserDetailsServices userDetailsServices = new UserDetailsServices();
            bool bCard = userDetailsServices.ChargePayment(creditCardNumber, id);
            Assert.AreEqual(bCard,false);
        }

        [TestMethod]
        public void CreditCardNumberIsNotNull()
        {
            string creditCardNumber = "1233452342342345";
            int id = 1;
            UserDetailsServices userDetailsServices = new UserDetailsServices();
            bool bCard = userDetailsServices.ChargePayment(creditCardNumber, id);
            Assert.AreEqual(bCard, true);
        }

        [TestMethod]
        public void CreditCardNumberLength16()
        {
            string creditCardNumber = "1233452342342345";            
            Assert.AreEqual(creditCardNumber.Length, 16);
        }

    }
}
