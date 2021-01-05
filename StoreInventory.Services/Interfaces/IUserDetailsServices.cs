using StoreInventory.Models.ViewModel;

namespace StoreInventory.Services.Interfaces
{
    public interface IUserDetailsServices
    {
        decimal UserDetailsAdd(UserDetailsViewModel userdetailsviewmodel, decimal purchaseAmount);
    }
}
