using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern
{
    class CurrentConditionsDisplay : IObserver, IDisplayElement
    {
        private float temperature;
        private float humidity;
        private float pressure;
        private ISubject weatherData;

        public CurrentConditionsDisplay(ISubject weatherData)
        {
            this.weatherData = weatherData;
            weatherData.RegisterObserver(this);
        }

        public void display()
        {
            Console.WriteLine(
                string.Format("Current conditions: {0}C, {1}%, {2}Pa"
                , this.temperature
                , this.humidity
                , this.pressure));
        }

        public void update(float temp, float humidity, float pressure)
        {
            this.temperature = temp;
            this.humidity = humidity;
            this.pressure = pressure;
            display();
        }
    }
}
