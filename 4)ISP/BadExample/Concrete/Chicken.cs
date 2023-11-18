using _4_ISP.BadExample.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_ISP.BadExample.Concrete
{
    public class Chicken : IBird
    {
        //IBird sınıfından kalıtım yoluyla gereksiz yetenek kazanan Chicken.cs sınıfı ISP prensibine ters düşmüştür. 
        public void Fly()
        {
            Console.WriteLine("Bütün tavuklar uçamaz!");
        }

        public void Swim()
        {
            Console.WriteLine("Tavuklar yüzemez!");
        }

        public void Walk()
        {
            Console.WriteLine("Tavuklar yürüyebilir!");
        }
    }
}
