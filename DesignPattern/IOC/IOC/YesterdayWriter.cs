using System;
using System.Collections.Generic;
using System.Text;

namespace IOC
{
    class YesterdayWriter: IDateWriter
    {
        private IOutput _output;
        public YesterdayWriter(IOutput output)
        {
            this._output = output;
        }

        public void WriteDate()
        {
            this._output.Write(DateTime.Today.AddDays(-1).ToString());
        }
    }
}
