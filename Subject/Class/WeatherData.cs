using System.Collections;
using System.Collections.Generic;
using ObserverPattern.Observers.Classes;
using ObserverPattern.Observers.Interfaces;
using ObserverPattern.Subject.Interface;

namespace ObserverPattern.Subject.Class
{
    class WeatherData : IPublisher
    {
        private List<ISubscriber> observers;
        private float temp;
        private float humidity;
        private float pressure;

        public WeatherData()
        {
            observers = new List<ISubscriber>();
        }

        public void registerObserver(ISubscriber subscriber)
        {
            observers.Add(subscriber);
        }

        public void removeObserver(ISubscriber subscriber)
        {
            observers.Remove(subscriber);
        }

        public void notifyObservers()
        {
            for (int i = 0; i < observers.Count; i++)
            {

                observers.ForEach(x => x.update(temp, humidity, pressure));

            }

        }
        public void measurementsChanged()
        {
            notifyObservers();
        }

        public void setMeasurements(float tempa, float humida, float pressa)
        {
            this.temp = tempa;
            this.humidity = humida;
            this.pressure = pressa;
            measurementsChanged();
        }
    }
}
