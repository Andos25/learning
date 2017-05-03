using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern
{
    class WeatherData : ISubject
    {
        private List<IObserver> Observers;
        private float temperature;
        private float humidity;
        private float pressure;

        public WeatherData()
        {
            Observers = new List<IObserver>();
        }

        public void NotifyObservers()
        {
            foreach(var observer in Observers)
            {
                observer.update(this.temperature, this.humidity, this.pressure);
            }
        }

        public void RegisterObserver(IObserver observer)
        {
            Observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            Observers.Remove(observer);
        }

        public void MeasurementChanged()
        {
            NotifyObservers();
        }

        public void SetMeasurement(float temp, float humidity, float pressure)
        {
            this.temperature = temp;
            this.humidity = humidity;
            this.pressure = pressure;

            MeasurementChanged();
        }
    }
}
