using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    class NYPizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(string type)
        {
            if(type.Equals("cheese"))
            {
                return new NYStyleCheesePizza();
            }
            else
            {
                return null;
            }
        }
    }
}
