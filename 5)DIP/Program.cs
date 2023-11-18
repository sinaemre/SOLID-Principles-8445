using _5_DIP.BadExample;
using _5_DIP.GoodExample.Concrete;

namespace _5_DIP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BadRestaurant restaurant = new BadRestaurant();
            Console.WriteLine(restaurant.GetCooking());

            Restaurant restaurantChicken = new Restaurant(new Chicken());
            Restaurant restaurantFish = new Restaurant(new Fish());
            Console.WriteLine(restaurantChicken.GenerateCookingIntroduction());
            Console.WriteLine(restaurantFish.GenerateCookingIntroduction());
        }
    }
}