using ObserverExample.Brokers;
using ObserverExample.Events;
using ObserverExample.Sales.Model;
using ObserverExample.Sales.Repositories;
using System.Linq;

namespace ObserverExample.Sales.Handlers
{
    public class SaleSoldHandler : ISaleSoldConsumer
    {
        public void Consume(SaleSold saleSold)
        {
            var sale = new Sale
            {
                Customer = new Customer
                {
                    Name = saleSold.CustomerName,
                    Document = saleSold.CustomerDocument,
                },
                SaleItens = saleSold.SaleSoldItens.Select(item => new SaleItem
                {
                    ProductName = item.ProductName,
                    Quantity = item.Quantity,
                    Value = item.Value,
                }),
            };

            var repository = new SalesRepository();
            repository.Persist(sale);
        }
    }
}