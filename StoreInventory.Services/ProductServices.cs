using StoreInventory.Models.Data;
using StoreInventory.Models.ViewModel;
using StoreInventory.Services.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace StoreInventory.Services
{
    public class ProductServices : IProductServices
    {
        public List<ProductDetailsViewModel> getProducts()
        {
            List<ProductDetailsViewModel> inventoryViewDetails;
            using (ProductInventory db = new ProductInventory())
            {
                inventoryViewDetails = db.ProductData.ToArray()
                                        .OrderBy(x => x.Product)
                                        .Select(x => new ProductDetailsViewModel(x))
                                        .ToList();
            }
            return inventoryViewDetails;
        }

        public ProductDetailsViewModel getProducts(int Id)
        {
            ProductDetailsViewModel productVM;
            using (ProductInventory db = new ProductInventory())
            {
                ProductStoreDTO productdto = db.ProductData.Find(Id);

                if (productdto != null)
                {
                    productVM = new ProductDetailsViewModel(productdto);
                    productVM.Quantity = 0;
                }
                else
                {
                    return null;
                }
            }
            return productVM;

        }

        public decimal purchaseProducts(ProductDetailsViewModel purchasedItem)
        {
            decimal userCharge = 0; int itemCount = 0;
            using (ProductInventory db = new ProductInventory())
            {
                //GetPurchasedItems
                ProductStoreDTO productStoreDTO = db.ProductData.Find(purchasedItem.Id);

                //Compare the count for availability
                if (purchasedItem.Quantity < productStoreDTO.Quantity)
                {
                    //Reduce the count and update the DB
                    itemCount = productStoreDTO.Quantity - purchasedItem.Quantity;
                    productStoreDTO.Quantity = itemCount;
                    db.SaveChanges();
                    userCharge = purchasedItem.Quantity * productStoreDTO.Amount;
                }
            }
            return userCharge;
        }
    }
}
