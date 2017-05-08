using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace BasedOnObservable
{
    class StatisticsConditionDisplay : ConditionsDisplay
    {
        private List<float> historyTemp;
        private List<float> historyHumidies;
        private List<float> historyPressue;

        public StatisticsConditionDisplay(IObservable<WeatherMetrics> provider): base(provider)
        {
            this.historyTemp = new List<float>();
            this.historyHumidies = new List<float>();
            this.historyPressue = new List<float>();
        }

        public override void print()
        {
            Console.WriteLine(string.Format("Avg temp: {0}C, humidity: {1}%, pressure: {2}"
                , this.historyTemp.Average()
                , this.historyHumidies.Average()
                , this.historyPressue.Average()));
        }

        public override void UpdateMetrics(WeatherMetrics weatherMetrics)
        {
            if (weatherMetrics != null)
            {
                this.historyTemp.Add(weatherMetrics.temperature);
                this.historyHumidies.Add(weatherMetrics.humidity);
                this.historyPressue.Add(weatherMetrics.pressure);
            }
        }
    }
}
