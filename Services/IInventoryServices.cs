using InventoryService.Models;
using System.Collections.Generic;

namespace InventoryService.Services
{
    public interface IInventoryServices
    {
        InventoryItem AddInventoryItems(InventoryItem items);

        Dictionary<string, InventoryItem> GetInventoryItems();
    }
}
