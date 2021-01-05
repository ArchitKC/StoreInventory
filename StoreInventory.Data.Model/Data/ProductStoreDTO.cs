using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StoreInventory.Models.Data
{
    [Table("tblProductInventory")]
    public class ProductStoreDTO
    {
        [Key]
        public int Id { get; set; }
        public string Product { get; set; }
        public int Quantity { get; set; }
        public  decimal Amount { get; set; }
    }
}