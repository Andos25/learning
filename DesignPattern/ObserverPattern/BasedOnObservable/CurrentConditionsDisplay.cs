using System;
using System.Collections.Generic;
using System.Text;

namespace BasedOnObservable
{
    class CurrentConditionsDisplay : IObserver<WeatherMetrics>
    {
        private WeatherMetrics weatherMetrics;

        public CurrentConditionsDisplay()

        public void OnCompleted()
        {
            throw new NotImplementedException();
        }

        public void OnError(Exception error)
        {
            throw new NotImplementedException();
        }

        public void OnNext(WeatherMetrics value)
        {
            throw new NotImplementedException();
        }
    }
}
