using System;
using System.Collections;

namespace DesignPatterns
{
    public interface ISubject
    {
        void RegisterObserver(IObserver î);
        void RemoveObserver(IObserver î);
        void NotifyObservers();
    }

    public class WeatherData : ISubject
    {
        private ArrayList observers;
        private float temperature;
        private float humidity;
        private float pressure;

        public void RegisterObserver(IObserver o)
        {
            observers.Add(o);
        }

        public void RemoveObserver(IObserver o)
        {
            int i = observers.IndexOf(o);
            if (i >= 0)
            {
                observers.Remove(o);
            }
        }

        public WeatherData()
        {
            observers = new ArrayList();
        }

        public void SetMesurements(float temperature, float humidity, float pressure)
        {
            this.temperature = temperature;
            this.humidity = humidity;
            this.pressure = pressure;

            MeasurementsChanged();
        }

        public void MeasurementsChanged()
        {
            NotifyObservers();
        }

        public void NotifyObservers()
        {
            for (int i = 0; i < observers.Count; i++)
            {
                IObserver observer = (IObserver)observers[i];
                observer.Update(temperature, humidity, pressure);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            WeatherData weatherData = new WeatherData();

            CurrentConditionsDisplay currentDisplay = new CurrentConditionsDisplay(weatherData);
            StatisticsDisplay statisticsDisplay = new StatisticsDisplay(weatherData);
            ForecastDisplay forecastDisplay = new ForecastDisplay(weatherData);

            weatherData.SetMesurements(80, 65, 30.4f);
            weatherData.SetMesurements(82, 70, 29.2f);
            weatherData.SetMesurements(78, 90, 29.2f);

            Console.ReadKey();
        }
    }
}
