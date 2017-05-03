using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern
{
    class ForecastDisplay : IObserver, IDisplayElement
    {
        private float ForecastTemperature;
        private float ForecastHumidity;
        private float ForecastPressure;
        WeatherData weatherData;

        public ForecastDisplay(WeatherData weatherData)
        {
            this.weatherData = weatherData;
            weatherData.RegisterObserver(this);
        }

        public void display()
        {
            Console.WriteLine(
                string.Format("Forecast conditions: {0}C, {1}%, {2}Pa"
                , this.ForecastTemperature
                , this.ForecastHumidity
                , this.ForecastPressure));
        }

        public void update(float temp, float humidity, float pressure)
        {
            var random = new Random();
            this.ForecastTemperature = temp + random.Next();
            this.ForecastHumidity = humidity + random.Next();
            this.ForecastPressure = pressure + random.Next();
            display();
        }
    }
}
