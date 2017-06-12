using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    class SimplePizzaFactory
    {
        public Pizza createPizza(string type)
        {
            Pizza pizza = null;

            switch(type)
            {
                case "cheese":
                    pizza = new CheesePizza
            }
        }
    }
}
