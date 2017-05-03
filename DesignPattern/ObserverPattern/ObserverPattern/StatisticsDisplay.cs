using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObserverPattern
{

    class StatisticsDisplay : IObserver, IDisplayElement
    {
        List<float> HistoryTemperatures;
        List<float> HistoryHumidities;
        List<float> HistoryPressures;
        WeatherData weatherData;

        public StatisticsDisplay(WeatherData weatherData)
        {
            HistoryTemperatures = new List<float>();
            HistoryHumidities = new List<float>();
            HistoryPressures = new List<float>();

            this.weatherData = weatherData;
            weatherData.RegisterObserver(this);
        }

        public void display()
        {
            Console.WriteLine(
                string.Format("Statistics conditions: {0}C, {1}%, {2}Pa"
                , this.HistoryTemperatures.Average()
                , this.HistoryHumidities.Average()
                , this.HistoryPressures.Average()
                ));
        }

        public void update(float temp, float humidity, float pressure)
        {
            this.HistoryTemperatures.Add(temp);
            this.HistoryHumidities.Add(humidity);
            this.HistoryPressures.Add(pressure);

            display();
        }
    }
}
