using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern
{
    abstract class Beverage
    {
        public string description = "Unknown Beverage";

        public string getDescription()
        {
            return description;
        }

        public abstract double cost();
    }
}
