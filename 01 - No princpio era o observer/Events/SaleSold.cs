using System.Collections.Generic;

namespace ObserverExample.Events
{
    public struct SaleSold
    {
        public string CustomerName { get; init; }

        public string CustomerDocument { get; init; }

        public IEnumerable<SaleSoldItem> SaleSoldItens { get; init; }
    }
}