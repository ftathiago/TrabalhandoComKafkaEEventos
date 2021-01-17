using System.Linq;
using ObserverExample.Events;
using ObserverExample.Sales.Model;
using ObserverExample.Sales.Repositories;

namespace ObserverExample.Sales.Handlers
{
    public class SaleSoldHandler : ISaleSoldNotify
    {
        public void Update(SaleSold saleSold)
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