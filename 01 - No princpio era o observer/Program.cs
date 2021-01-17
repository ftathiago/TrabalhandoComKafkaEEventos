using System;
using System.Collections.Generic;
using ObserverExample.Brokers;
using ObserverExample.Events;
using ObserverExample.Financials.Handlers;
using ObserverExample.Sales.Handlers;
using ObserverExample.Warehouses.Handlers;

namespace ObserverExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var broker = RetornarBrokerConfigurado();

            var saleSold = VendaEfetuadaNoControllerDaApp();

            broker.Notify(saleSold);
            Console.ReadLine();
        }

        private static SaleSold VendaEfetuadaNoControllerDaApp() => new()
        {
            CustomerName = "Francisco Thiago de Almeida",
            CustomerDocument = "999.999.999-99",
            SaleSoldItens = new List<SaleSoldItem>
                {
                    new SaleSoldItem
                    {
                        ProductName = "Feijão",
                        Quantity = 1,
                        Value = 4,
                    },
                    new SaleSoldItem
                    {
                        ProductName = "Arroz",
                        Quantity = 2,
                        Value = 23.50M,
                    }
                },
        };

        private static SaleSoldNotifier RetornarBrokerConfigurado()
        {
            var broker = new SaleSoldNotifier();
            broker.Add(new WarehouseSalesSoldHandler());
            broker.Add(new FinancialSaleSoldHandler());
            broker.Add(new SaleSoldHandler());
            return broker;
        }
    }
}
