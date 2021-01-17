using System;
using ObserverExample.Sales.Model;

namespace ObserverExample.Sales.Repositories
{
    public class SalesRepository
    {
        public void Persist(Sale sale)
        {
            Console.WriteLine("-> SalesRepository BEGIN");
            Console.WriteLine($"-> SalesRepository Sale persisted to customer {sale.Customer}");
            Console.WriteLine("-> SalesRepository END");
        }
    }
}