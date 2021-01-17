namespace ObserverExample.Events
{
    public interface ISaleSoldNotify
    {
        void Update(SaleSold saleSold);
    }
}