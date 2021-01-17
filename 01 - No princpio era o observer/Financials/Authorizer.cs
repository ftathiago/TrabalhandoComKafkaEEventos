using ObserverExample.Financials.Models;
using System;
using System.Threading.Tasks;

namespace ObserverExample.Financials
{
    public class Authorizer
    {
        public async Task Authorize(Transaction authorizable)
        {
            Console.WriteLine("-> Authorizer BEGIN");
            await Task.Delay(5000);
            Console.WriteLine($"-> Authorizer AUTHORIZED to {authorizable.ClientName}, value: {authorizable.Value}");
            Console.WriteLine("-> Authorizer END");
        }
    }
}