using ObserverExample.Events;
using System.Collections.Generic;

namespace ObserverExample.Brokers
{
    public class SaleSoldEventBus : ISaleSoldEventBus
    {
        private readonly List<ISaleSoldConsumer> _listeners;

        public SaleSoldEventBus() =>
            _listeners = new List<ISaleSoldConsumer>();

        public ISaleSoldEventBus Subscribe(ISaleSoldConsumer listener)
        {
            _listeners.Add(listener);
            return this;
        }

        public ISaleSoldEventBus Unsubscribe(ISaleSoldConsumer listener)
        {
            _listeners.Remove(listener);
            return this;
        }

        public void Publish(SaleSold saleSold) =>
            _listeners.ForEach(listener => listener.Consume(saleSold));
    }
}