using System.Threading.Tasks;
using System.Collections.Generic;
using InventoryService.Models;

namespace InventoryService.Interfaces
{
    public interface IInventoryItemRepository
    {
        Task<IEnumerable<InventoryItem>> GetAllInventoryItems();
        Task AddInventoryItem(InventoryItem item);
    }
}