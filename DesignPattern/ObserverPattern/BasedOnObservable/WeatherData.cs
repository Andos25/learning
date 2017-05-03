using System;
using System.Collections.Generic;
using System.Text;

namespace BasedOnObservable
{
    class WeatherData : IObservable<WeatherMetrics>
    {
        private List<IObserver<WeatherMetrics>> Observers;

        public WeatherData()
        {
            Observers = new List<IObserver<WeatherMetrics>>();
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

            }
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
