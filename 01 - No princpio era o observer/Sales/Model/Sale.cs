using System.Collections.Generic;

namespace ObserverExample.Sales.Model
{
    public class Sale
    {
        public Customer Customer { get; set; }

        public IEnumerable<SaleItem> SaleItens { get; set; }
    }
}