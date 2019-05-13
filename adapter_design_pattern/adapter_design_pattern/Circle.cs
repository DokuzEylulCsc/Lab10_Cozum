using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter_design_pattern
{
    class Circle:Shape
    {
        public void draw()
        {
            Console.WriteLine("Drawing Circle");
        }
    }
}
