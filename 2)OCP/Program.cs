using _2_OCP.BadExample;
using _2_OCP.GoodExample.Concrete;

namespace _2_OCP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("5 adet Lattenin fiyatı => " + BadCoffee.GetTotalPrice(5, CoffeeType.Latte));

            Espresso espresso = new Espresso();
            Console.WriteLine("5 adet expresso'nun fiyatı => " + espresso.GetTotalPrice(5)); 
        }
    }
}