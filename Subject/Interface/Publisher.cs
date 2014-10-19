using ObserverPattern.Observers.Classes;
using ObserverPattern.Observers.Interfaces;

namespace ObserverPattern.Subject.Interface
{
    public interface IPublisher
    {
        void registerObserver(ISubscriber subscriber);
        void removeObserver(ISubscriber subscriber);
        void notifyObservers();
    }
}
