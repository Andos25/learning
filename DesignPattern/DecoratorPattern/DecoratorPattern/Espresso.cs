using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern
{
    class Espresso : Beverage
    {
        public Espresso()
        {
            description = "Espresso";
        }

        public override double cost()
        {
            return 1.99;
        }
    }
}
