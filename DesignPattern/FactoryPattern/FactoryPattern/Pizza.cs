using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    public abstract class Pizza
    {
        public string Name { get; set; }
        public string Dough { get; set; }
        public string Sauce { get; set; }

        public List<string> Toppings = new List<string>();
        public void Prepare()
        {
            Console.WriteLine("Preparing" + this.Name);
            Console.WriteLine("Tossing dough...");
            Console.WriteLine("Adding sauce...");
            Console.WriteLine("Adding toppings: ");
            foreach(var topping in this.Toppings)
            {
                Console.WriteLine("  " + topping);
            }
        }

        public void Bake()
        {
            Console.WriteLine("Place pizza in official PizzaStore box");
        }

        public void Cut()
        {
            Console.WriteLine("Cutting the pizza into diagonal slices");
        }

        public void Box()
        {
            Console.WriteLine("Place pizza in official PizzaStore box");
        }

        public string GetName()
        {
            return Name;
        }
    }


}
