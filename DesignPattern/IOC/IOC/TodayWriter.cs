using System;
using System.Collections.Generic;
using System.Text;

namespace IOC
{
    class TodayWriter : IDateWriter
    {
        private IOutput _output;
        public TodayWriter(IOutput output)
        {
            this._output = output;
        }

        public void WriteDate()
        {
            this._output.Write(DateTime.Today.ToString());
        }
    }
}
