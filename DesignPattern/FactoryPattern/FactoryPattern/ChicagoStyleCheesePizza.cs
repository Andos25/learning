using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    class ChicagoStyleCheesePizza : Pizza
    {
        public ChicagoStyleCheesePizza()
        {
            Name = "Chicago Style Deep Dish Cheese Pizza";
            Dough = "Extra Thick Crust Dough";
            Sauce = "Plum Tomato Sauce";

            Toppings.Add("Shredded Mozzarella Cheese");
        }

        void Cut()
        {
            Console.Write("Cutting the pizza into square slices");
        }
    }
}
