using Microsoft.Extensions.Options;
using MongoDB.Driver;
using InventoryService.Models;

namespace InventoryService.Data
{
    public class InventoryItemContext
    {
        private readonly IMongoDatabase _database = null;

        public InventoryItemContext(IOptions<Settings> settings)
        {
            var client = new MongoClient(settings.Value.ConnectionString);
            if (client != null)
            {
                _database = client.GetDatabase(settings.Value.Database);
            }
        }

        public IMongoCollection<InventoryItem> InventoryItems
        {
            get
            {
                return _database.GetCollection<InventoryItem>("InventoryItem");
            }
        }
    }
}