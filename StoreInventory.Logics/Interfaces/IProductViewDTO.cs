  
namespace StoreInventory.Logics.Interfaces
{
    public interface IProductViewDTO
    {  
        bool CheckInventoryQuantity(int Id, int quantity);
    }
}
