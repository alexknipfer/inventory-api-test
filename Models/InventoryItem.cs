using System;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace InventoryService.Models
{
    public class InventoryItem
    {
        [BsonId]
        public ObjectId InternalId { get; set; }

        public string Id { get; set; }
        public string ItemName { get; set; }
        public double Price { get; set; }
    }
}
