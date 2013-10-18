using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Physics_Simulator_2D.Objects
{
    class Circle : PhysicalPoint
    {
        public Double Diameter;

        public Circle() {}

        public Circle(Double diameter)
        {
            Diameter = diameter;
        }
    }
}
