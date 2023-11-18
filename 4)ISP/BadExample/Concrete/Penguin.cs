using _4_ISP.BadExample.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_ISP.BadExample.Concrete
{
    public class Penguin : IBird
    {
        public void Fly()
        {
            Console.WriteLine("Penguenler uçamaz!");
        }

        public void Swim()
        {
            Console.WriteLine("Penguenler yüzer!");
        }

        public void Walk()
        {
            Console.WriteLine("Penguenler yürür!");
        }
    }
}
