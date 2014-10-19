namespace ObserverPattern.Observers.Interfaces
{
    public interface ISubscriber
    {
        void update(float temp, float humidity, float pressure);
    }
}
