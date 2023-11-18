using _4_ISP.GoodExample.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_ISP.GoodExample.Concrete
{
    public class GoodChicken : IWalkBird
    {
        public void Walk()
        {
            Console.WriteLine("Tavuklar yürüyebilir!");
        }
    }
}
