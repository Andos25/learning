using System;

namespace ObserverPattern
{
    class WeatherStation
    {
        static void Main(string[] args)
        {
            var weatherData = new WeatherData();
            var currentConditionsDisplay = new CurrentConditionsDisplay(weatherData);
            var statisticsDisplay = new StatisticsDisplay(weatherData);
            var forecastDisplay = new ForecastDisplay(weatherData);

            weatherData.SetMeasurement(27, 65, 30.4f);
            weatherData.SetMeasurement(32, 70, 32f);
            weatherData.SetMeasurement(35, 63, 35f);
            weatherData.SetMeasurement(29, 67, 33.4f);
            weatherData.SetMeasurement(31, 71, 32.5f);
        }
    }
}