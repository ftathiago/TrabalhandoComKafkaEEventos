using ObserverExample.Brokers;
using ObserverExample.Events;
using ObserverExample.Financials.Handlers;
using ObserverExample.Sales.Handlers;
using ObserverExample.Warehouses.Handlers;
using System;
using System.Collections.Generic;

namespace ObserverExample
{
    public static class Program
    {
        private static void Main()
        {
            var eventBus = RetornarEventBusConfigurado();

            var saleSold = VendaEfetuadaNoControllerDaApp();

            eventBus.Publish(saleSold);
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

        private static ISaleSoldEventBus RetornarEventBusConfigurado() =>
            new SaleSoldEventBus()
                .Subscribe(new WarehouseSalesSoldHandler())
                .Subscribe(new FinancialSaleSoldHandler())
                .Subscribe(new SaleSoldHandler());
    }
}
