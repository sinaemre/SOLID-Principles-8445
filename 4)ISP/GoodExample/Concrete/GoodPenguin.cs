using _4_ISP.GoodExample.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_ISP.GoodExample.Concrete
{
    public class GoodPenguin : IWalkBird, ISwimBird
    {
        public void Swim()
        {
            Console.WriteLine("Penguenler yüzebilir!");
        }

        public void Walk()
        {
            Console.WriteLine("Penguenler yürüyebilir!");
        }
    }
}
