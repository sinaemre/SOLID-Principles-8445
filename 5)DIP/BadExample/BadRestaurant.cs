using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_DIP.BadExample
{
    //Kümes Hayvanları Yemek Listesi - Tavuk Külbastı

    public class BadRestaurant
    {
        BadChicken chicken = new BadChicken();
        BadPoultry poultry = new BadPoultry();
        public string GetCooking() => $"{poultry.GetPoultryIntroduction()} - {chicken.GetChickenIntroduction()}";
    }
}
