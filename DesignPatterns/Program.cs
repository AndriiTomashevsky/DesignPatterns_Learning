using System;

namespace DesignPatterns
{
    public class WeatherData
    {
        public float GetTemperature() { return 20; }
        public float GetHumidity() { return 85; }
        public float GetPressure() { return 752; }

        public void MeasurementsChanged()
        {
            float temp = GetTemperature();
            float humidity = GetHumidity();
            float pressure = GetPressure();

            CurrentConditionsDisplay.Update(temp, humidity, pressure);
            StatisticDisplay.Update(temp, humidity, pressure);
            ForecastDisplay.Update(temp, humidity, pressure);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.ReadKey();
        }
    }
}
