using System;
using System.Collections.Generic;
using System.Text;

namespace BasedOnObservable
{
    class WeatherData : IObservable<WeatherMetrics>
    {
        private List<IObserver<WeatherMetrics>> Observers;
        private WeatherMetrics weatherMetrics;

        public WeatherData(WeatherMetrics weatherMetrics)
        {
            Observers = new List<IObserver<WeatherMetrics>>();
            this.weatherMetrics = new WeatherMetrics()
            {
                temperature = weatherMetrics.temperature,
                humidity = weatherMetrics.humidity,
                pressure = weatherMetrics.pressure
            };
        }

        public IDisposable Subscribe(IObserver<WeatherMetrics> observer)
        {
            if(!Observers.Contains(observer))
            {
                Observers.Add(observer);
            }
            return new Unsubscriber(Observers, observer);
        }

        public void NotifyObervers()
        {
            foreach(var observer in Observers)
            {
                observer.OnNext(this.weatherMetrics);
            }
        }

        public void UpdateMetrics(float temp, float humidity, float pressure)
        {
            this.weatherMetrics.temperature = temp;
            this.weatherMetrics.humidity = humidity;
            this.weatherMetrics.pressure = pressure;

            NotifyObervers();
        }

        private class Unsubscriber : IDisposable
        {
            private List<IObserver<WeatherMetrics>> _Observers;
            private IObserver<WeatherMetrics> _Observer;

            public Unsubscriber(List<IObserver<WeatherMetrics>> observers, IObserver<WeatherMetrics> observer)
            {
                this._Observers = observers;
                this._Observer = observer;
            }

            public void Dispose()
            {
                if(_Observer != null && _Observers.Contains(_Observer))
                    _Observers.Remove(_Observer);
            }
        }
    }
}
