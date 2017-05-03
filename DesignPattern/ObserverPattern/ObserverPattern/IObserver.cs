using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern
{
    interface IObserver
    {
        void update(float temp, float humidity, float pressure);
    }
}
