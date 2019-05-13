using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter_design_pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Drawing drawing = new Drawing();

            drawing.addShape(new Rectangle());
            drawing.addShape(new Circle());
            drawing.addShape(new GeometricShapeObjectAdapter(new Triangle(2,4,5)));
            drawing.draw();
           
          
        }
    }
}
