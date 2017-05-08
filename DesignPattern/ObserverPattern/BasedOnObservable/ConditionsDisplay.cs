using System;
using System.Collections.Generic;
using System.Text;

namespace BasedOnObservable
{
    abstract class ConditionsDisplay : IObserver<WeatherMetrics>
    {
        public WeatherMetrics weatherMetrics;
        public IDisposable unsubscriber;

        public ConditionsDisplay(IObservable<WeatherMetrics> provider)
        {
            this.Subscribe(provider);
            weatherMetrics = new WeatherMetrics();
        }

        public virtual void Subscribe(IObservable<WeatherMetrics> provider)
        {
            if (provider != null)
                unsubscriber = provider.Subscribe(this);
        }

        public void OnCompleted()
        {
            unsubscriber.Dispose();
        }

        public void OnError(Exception error)
        {
            throw new NotImplementedException();
        }

        public void OnNext(WeatherMetrics value)
        {
            UpdateMetrics(value);
            print();
        }

        public abstract void UpdateMetrics(WeatherMetrics weatherMetrics);

        public abstract void print();
    }
}
