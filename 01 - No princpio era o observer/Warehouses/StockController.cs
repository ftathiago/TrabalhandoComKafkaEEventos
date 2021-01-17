using ObserverExample.Warehouses.Models;
using System;

namespace ObserverExample.Warehouses
{
    public class StockController
    {
        public void ExecuteMovement(StockMovement movement)
        {
            Console.WriteLine("-> StockMovement BEGIN");
            Console.WriteLine($"-> StockMovement Executing {movement.MovementKind} of '{movement.Product}' product with {movement.Quantity} units");
            Console.WriteLine("-> StockMovement END");
        }
    }
}