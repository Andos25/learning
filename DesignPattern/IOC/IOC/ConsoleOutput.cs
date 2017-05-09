using System;
using System.Collections.Generic;
using System.Text;

namespace IOC
{
    public class ConsoleOutput : IOutput
    {
        public void Write(string content)
        {
            Console.WriteLine(content);
        }
    }
}
