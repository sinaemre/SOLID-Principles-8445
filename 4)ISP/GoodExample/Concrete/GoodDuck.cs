using _4_ISP.GoodExample.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_ISP.GoodExample.Concrete
{
    public class GoodDuck : IWalkBird, ISwimBird, IFlyBird
    {
        public void Fly()
        {
            Console.WriteLine("Ördekler uçabilir!");
        }

        public void Swim()
        {
            Console.WriteLine("Ördekler yüzebilir!");
        }

        public void Walk()
        {
            Console.WriteLine("Ördekler yürüyebilir!");
        }
    }
}
