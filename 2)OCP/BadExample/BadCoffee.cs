using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_OCP.BadExample
{
    public enum CoffeeType { Latte = 1, Espresso = 2, Mocha = 3, Americano = 4 }
    public class BadCoffee
    {
        public static double GetTotalPrice(int quantity, CoffeeType coffeeType)
        {
            double totalPrice = 0;

            if (coffeeType == CoffeeType.Latte)
            {
                totalPrice += 120;
            }
            else if (coffeeType == CoffeeType.Mocha)
            {
                totalPrice += 115;
            }
            else if (coffeeType == CoffeeType.Espresso)
            {
                totalPrice += 85;
            }
            else if (coffeeType == CoffeeType.Americano)
            {
                totalPrice += 100;
            }
            return totalPrice * quantity;
        }
    }
}
