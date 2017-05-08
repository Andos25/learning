using System;
using System.Collections.Generic;
using System.Text;

namespace BasedOnObservable
{
    class ForecastConditionDisplay : ConditionsDisplay
    {
        public ForecastConditionDisplay(IObservable<WeatherMetrics> provider):base(provider)
        {
        }

        public override void print()
        {
            Console.WriteLine("Forecast temp: {0}C, humidity: {1}%, pressure: {2}"
                , weatherMetrics.temperature
                , weatherMetrics.humidity
                , weatherMetrics.pressure);
        }

        public override void UpdateMetrics(WeatherMetrics weatherMetrics)
        {
            var random = new Random();
            this.weatherMetrics.temperature = weatherMetrics.temperature + random.Next();
            this.weatherMetrics.humidity = weatherMetrics.humidity + random.Next();
            this.weatherMetrics.pressure = weatherMetrics.pressure + random.Next();
        }
    }
}
