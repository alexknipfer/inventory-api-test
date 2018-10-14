using System;
using System.Threading.Tasks;
using Microsoft.Extensions.Options;
using InventoryService.Models;
using InventoryService.Interfaces;

namespace InventoryService.Data
{
    public class InventoryItemRepository : IInventoryItemRepository
    {
        private readonly InventoryItemContext _context = null;

        public InventoryItemRepository(IOptions<Settings> settings)
        {
            _context = new InventoryItemContext(settings);
        }

        public async Task AddInventoryItem(InventoryItem item)
        {
            try
            {
                await _context.InventoryItems.InsertOneAsync(item);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}