using StoreInventory.Models.ViewModel;
using StoreInventory.Services.Interfaces;
using System;

namespace StoreInventory.Services
{
    public class UserDetailsServices : IUserDetailsServices
    {
        public decimal UserDetailsAdd(UserDetailsViewModel userdetailsviewmodel, decimal purchaseAmount)
        {
            if(ChargePayment(userdetailsviewmodel.CardNumber, purchaseAmount)) {
                sentEmail(userdetailsviewmodel.Email, purchaseAmount);
                return ((purchaseAmount * Convert.ToDecimal(0.035))+purchaseAmount);
            }
            else {
                return purchaseAmount;
            }
        }

        private void sentEmail(string email, decimal purchaseAmount)
        {
            throw new NotImplementedException();
        }

        public bool ChargePayment(string creditCardNumber, decimal amount)
        {
            return string.IsNullOrWhiteSpace(creditCardNumber) ? false : true;
        }


    }
}
