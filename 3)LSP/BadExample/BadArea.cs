using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_LSP.BadExample
{
    public class BadArea : BadRetangle
    {
        int _width;
        public override int Width 
        {
            get => _width;
            set => _width = value; 
        }

        int _length;
        public override int Length 
        {
            get => _length;
            set => _length = value;
        }
    }
}
