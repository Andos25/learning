using System;

namespace BasedOnObservable
{
    class WeatherStation
    {
        static void Main(string[] args)
        {
            var init = new WeatherMetrics()
            {
                temperature = 28,
                humidity = 82,
                pressure = 34.1f
            };
            var weatherData = new WeatherData(init);

            var currentConditionsDisplay = new CurrentConditionsDisplay(weatherData);
            var statisticsDisplay = new StatisticsConditionDisplay(weatherData);
            var forecastDisplay = new ForecastConditionDisplay(weatherData);

            weatherData.NotifyObervers();
            weatherData.UpdateMetrics(27, 65, 30.4f);
            weatherData.UpdateMetrics(32, 70, 32f);
            weatherData.UpdateMetrics(35, 63, 35f);
            weatherData.UpdateMetrics(29, 67, 33.4f);
            weatherData.UpdateMetrics(31, 71, 32.5f);
        }
    }
}