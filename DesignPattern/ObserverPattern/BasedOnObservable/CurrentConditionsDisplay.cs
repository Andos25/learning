using System;
using System.Collections.Generic;
using System.Text;

namespace BasedOnObservable
{
    class CurrentConditionsDisplay : ConditionsDisplay
    {
        public CurrentConditionsDisplay(IObservable<WeatherMetrics> provider)
        {
            if (provider != null)
                provider.Subscribe(this);
        }

        public override void print()
        {
            Console.WriteLine(string.Format("Current temp: {0}C, humidity: {1}%, pressure: {2}"
                , weatherMetrics.temperature
                , weatherMetrics.humidity
                , weatherMetrics.pressure));
        }

        public override void UpdateMetrics(WeatherMetrics weatherMetrics)
        {
            throw new NotImplementedException();
        }
    }
}
