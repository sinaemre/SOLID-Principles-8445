using _4_ISP.BadExample.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_ISP.BadExample.Concrete
{
    public class Duck : IBird
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
