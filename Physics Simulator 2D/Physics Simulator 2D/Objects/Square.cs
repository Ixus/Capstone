using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Physics_Simulator_2D.Objects
{
    class Square : PhysicalPoint
    {
        public Double Height;
        public Double Width;

        public Square() {}

        public Square(Double height, Double width)
        {
            Height = height;
            Width = width;
        }
    }
}
