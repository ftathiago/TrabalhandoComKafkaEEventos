namespace ObserverExample.Events
{
    public class SaleSoldItem
    {
        public string ProductName { get; init; }

        public decimal Quantity { get; init; }

        public decimal Value { get; init; }
    }
}