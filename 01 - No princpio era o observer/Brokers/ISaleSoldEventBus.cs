using ObserverExample.Events;

namespace ObserverExample.Brokers
{
    public interface ISaleSoldEventBus
    {
        ISaleSoldEventBus Subscribe(ISaleSoldConsumer notify);

        ISaleSoldEventBus Unsubscribe(ISaleSoldConsumer notify);

        void Publish(SaleSold saleSold);
    }
}