using ObserverExample.Brokers;
using ObserverExample.Events;
using ObserverExample.Financials.Models;
using System.Linq;

namespace ObserverExample.Financials.Handlers
{
    public class FinancialSaleSoldHandler : ISaleSoldConsumer
    {
        public void Consume(SaleSold saleSold)
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