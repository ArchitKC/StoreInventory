using System.Data.Entity;

namespace StoreInventory.Models.Data
{
    public class ProductInventory: DbContext
    {
        public DbSet<ProductStoreDTO> ProductData { get; set; }
    }
}