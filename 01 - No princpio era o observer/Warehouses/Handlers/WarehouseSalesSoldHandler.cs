using ObserverExample.Brokers;
using ObserverExample.Events;
using ObserverExample.Warehouses.Models;
using System.Collections.Generic;
using System.Linq;

namespace ObserverExample.Warehouses.Handlers
{
    public class WarehouseSalesSoldHandler : ISaleSoldConsumer
    {
        public void Consume(SaleSold saleSold)
        {
            var controller = new StockController();
            var movements = From(saleSold);
            foreach (var movement in movements)
            {
                controller.ExecuteMovement(movement);
            }
        }

        public static IEnumerable<StockMovement> From(SaleSold saleSold) => saleSold.SaleSoldItens.Select(item => new StockMovement
        {
            MovementKind = MovementKind.Out,
            Operation = "Sale",
            Product = item.ProductName,
            Quantity = item.Quantity,
        });
    }
}