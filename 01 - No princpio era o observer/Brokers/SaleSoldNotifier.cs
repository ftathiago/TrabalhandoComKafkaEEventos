using System.Collections.Generic;
using ObserverExample.Events;

namespace ObserverExample.Brokers
{
    public class SaleSoldNotifier : ISaleSoldNotifier
    {
        private readonly List<ISaleSoldNotify> _listeners;

        public SaleSoldNotifier() =>
            _listeners = new List<ISaleSoldNotify>();

        public void Add(ISaleSoldNotify listener) =>
            _listeners.Add(listener);

        public void Remove(ISaleSoldNotify listener) =>
            _listeners.Remove(listener);

        public void Notify(SaleSold saleSold) =>
            _listeners.ForEach(listener => listener.Update(saleSold));
    }
}