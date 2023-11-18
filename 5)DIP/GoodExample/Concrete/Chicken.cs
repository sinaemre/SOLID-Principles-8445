using _5_DIP.GoodExample.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_DIP.GoodExample.Concrete
{
    public class Chicken : IProduct
    {
        public string GetCookingIntroduction() => "Tavuk Izgara";
    }
}
