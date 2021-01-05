namespace StoreInventory
{
    public class Models
    {
        public class Data
        {
            public class ProductStoreDTO
            {
                public int Id { get; set; }
                public string Product { get; set; }
                public int Quantity { get; set; }
                public decimal Amount { get; set; }
            }
        }
    }
}