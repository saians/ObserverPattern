using System;
using ObserverPattern.Observers.Classes;
using ObserverPattern.Subject.Class;

namespace ObserverPattern
{
    class WeatherStation
    {
        public static void Main(string[] args)
        {
            WeatherData weatherData =  new WeatherData();

            CurrentConditionsDisplay currentDisplay = new CurrentConditionsDisplay(weatherData);

            weatherData.setMeasurements(20,20,20);

            Console.ReadKey();
        }
    }
}
