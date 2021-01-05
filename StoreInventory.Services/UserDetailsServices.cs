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
                return ((purchaseAmount * Convert.ToDecimal(0.035))+purchaseAmount);
            }
            else {
                return purchaseAmount;
            }
        }

        public bool ChargePayment(string creditCardNumber, decimal amount)
        {
            return string.IsNullOrWhiteSpace(creditCardNumber) ? false : true;
        }


    }
}
