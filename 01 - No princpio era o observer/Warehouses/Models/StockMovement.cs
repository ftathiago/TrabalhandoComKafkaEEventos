namespace ObserverExample.Warehouses.Models
{
    public class StockMovement
    {
        public string Product { get; set; }

        public decimal Quantity { get; set; }

        public string Operation { get; set; }

        public MovementKind MovementKind { get; set; }
    }
}