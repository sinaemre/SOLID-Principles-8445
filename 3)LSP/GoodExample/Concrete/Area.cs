using _3_LSP.GoodExample.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_LSP.GoodExample.Concrete
{
    public class Area : BaseShape
    {
        public override int Calculate() => Edge * Edge;
    }
}
