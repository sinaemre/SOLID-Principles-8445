using _3_LSP.GoodExample.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_LSP.GoodExample.Concrete
{
    public class Retangle : BaseShape
    {
        public int Width { get; set; }

        public override int Calculate() => Edge * Width;
    }
}
