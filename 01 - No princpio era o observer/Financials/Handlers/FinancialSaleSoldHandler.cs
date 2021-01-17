using System.Linq;
using ObserverExample.Events;
using ObserverExample.Financials.Models;

namespace ObserverExample.Financials.Handlers
{
    public class FinancialSaleSoldHandler : ISaleSoldNotify
    {
        public void Update(SaleSold saleSold)
        {
            var authorizable = new Transaction
            {
                ClientName = saleSold.CustomerName,
                Value = saleSold.SaleSoldItens.Sum(item => item.Quantity * item.Value),
            };

            var authorizer = new Authorizer();
            authorizer.Authorize(authorizable);
        }
    }
}