using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern
{
    class HouseBlend : Beverage
    {
        public HouseBlend()
        {
            description = "HouseBlend";
        }

        public override double cost()
        {
            return 0.89;
        }
    }
}
