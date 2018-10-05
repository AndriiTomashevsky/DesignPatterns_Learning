using System;

namespace DesignPatterns.Observers
{
    public class StatisticsDisplay : IObserver, IDisplayElement
    {
        private float maxTemp = 0.0f;
        private float minTemp = 200;
        private float tempSum = 0.0f;
        private int numReadings;
        private ISubject weatherData;

        public StatisticsDisplay(WeatherData weatherData)
        {
            this.weatherData = weatherData;
            weatherData.RegisterObserver(this);
        }

        public void Display()
        {
            Console.WriteLine($"Avg/Max/Min temperature = {tempSum / numReadings} / {maxTemp} / {minTemp}");
        }

        public void Update(float temp, float humidity, float pressure)
        {
            tempSum += temp;
            numReadings++;

            if (temp > maxTemp)
            {
                maxTemp = temp;
            }
            if (temp < minTemp)
            {
                minTemp = temp;
            }
            Display();
        }
    }
}
