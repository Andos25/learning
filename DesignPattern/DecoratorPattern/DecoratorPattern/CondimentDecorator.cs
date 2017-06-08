using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern
{
    abstract class CondimentDecorator : Beverage
    {
        protected Beverage beverage;
        public abstract string getDescription();
    }
}
