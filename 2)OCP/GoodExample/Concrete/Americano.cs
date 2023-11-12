using _2_OCP.GoodExample.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_OCP.GoodExample.Concrete
{
    public class Americano : GoodCoffeeShop
    {
        public override double GetTotalPrice(int quantity)
        {
            return 110 * quantity;
        }
    }
}
