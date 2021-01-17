using ObserverExample.Events;

namespace ObserverExample.Brokers
{
    public interface ISaleSoldNotifier
    {
        void Add(ISaleSoldNotify notify);

        void Remove(ISaleSoldNotify notify);

        void Notify(SaleSold saleSold);
    }
}