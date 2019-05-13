using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter_design_pattern
{
    class Triangle : GeometricShape
    {
        private  double a;
        private  double b;
        private  double c;
      
        public Triangle(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public double area()
        {
            
            double s = (a + b + c) / 2;
            return Math.Sqrt(s * (s - a) * (s - b) * (s - c));
        }

        public void drawShape()
        {
           Console.WriteLine("Drawing Triangle with area: " + area() );
        }


    }
}
