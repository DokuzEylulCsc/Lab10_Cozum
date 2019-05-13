using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter_design_pattern
{
    class GeometricShapeObjectAdapter : Shape
    {
        private GeometricShape adaptee;
        public GeometricShapeObjectAdapter(GeometricShape adaptee)
        {
            this.adaptee = adaptee;
        }
        public void draw()
        {
            adaptee.drawShape();
        }
    }
}
