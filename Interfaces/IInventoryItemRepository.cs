using System.Threading.Tasks;
using InventoryService.Models;

namespace InventoryService.Interfaces
{
    public interface IInventoryItemRepository
    {
        Task AddInventoryItem(InventoryItem item);
    }
}