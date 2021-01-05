
using StoreInventory.Models.ViewModel;
using System.Collections.Generic;

namespace StoreInventory.Services.Interfaces
{
    public interface IProductServices
    {
        List<ProductDetailsViewModel> getProducts();
        ProductDetailsViewModel getProducts(int Id);

        decimal purchaseProducts(ProductDetailsViewModel purchasedItem);
    }
}
