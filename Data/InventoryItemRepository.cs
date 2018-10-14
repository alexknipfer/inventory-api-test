using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.Extensions.Options;
using InventoryService.Models;
using InventoryService.Interfaces;
using MongoDB.Driver;


namespace InventoryService.Data
{
    public class InventoryItemRepository : IInventoryItemRepository
    {
        private readonly InventoryItemContext _context = null;

        public InventoryItemRepository(IOptions<Settings> settings)
        {
            _context = new InventoryItemContext(settings);
        }

        public async Task<IEnumerable<InventoryItem>> GetAllInventoryItems()
        {
            try
            {
                return await _context.InventoryItems.Find(_ => true).ToListAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
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