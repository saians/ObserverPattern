using System;
using ObserverPattern.Observers.Interfaces;
using ObserverPattern.Subject.Interface;

namespace ObserverPattern.Observers.Classes
{
    class CurrentConditionsDisplay : ISubscriber, IDisplayElement
    {
        private float temperature;
        private float humidity;
        private IPublisher weatherData;

        public CurrentConditionsDisplay(IPublisher weatherData)
        {
            this.weatherData = weatherData;
            weatherData.registerObserver(this);
        }

        public void update(float temp, float humidity, float pressure)
        {
            this.temperature = temp;
            this.humidity = humidity;
            display();
        }

        public void display()
        {
            Console.WriteLine("Current conditions: " + temperature + "F Degree and " + humidity + " % humidity");
        }
    }
}
