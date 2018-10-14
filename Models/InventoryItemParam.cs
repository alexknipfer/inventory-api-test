namespace InventoryService.Models
{
    public class InventoryItemParam
    {
        public string Id { get; set; } = string.Empty;
        public string ItemName { get; set; } = string.Empty;
        public double Price { get; set; } = 0.0;
    }
}