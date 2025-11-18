namespace InventoryWebApp.Models
{
    public class UpdateInventoryRequest
    {
        public string ProductId { get; set; }
        public int QuantityChanges { get; set; }
        public string WarehouseLocation { get; set; }


    }
}
