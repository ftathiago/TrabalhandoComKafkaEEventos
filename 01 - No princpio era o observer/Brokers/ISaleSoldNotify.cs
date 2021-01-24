using ObserverExample.Events;

namespace ObserverExample.Brokers
{
    public interface ISaleSoldConsumer
    {
        void Consume(SaleSold saleSold);
    }
}