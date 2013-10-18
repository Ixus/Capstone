using Physics_Simulator_2D.Tools;
using System;
using System.Collections.Generic;
using System.Drawing;
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

        public Circle(Double diameter, Vector2D location, Vector2D velocity, Vector2D acceleration,
            Double mass, Color color)
        {
            Diameter = diameter;
            base.Location = location;
            base.Velocity = velocity;
            base.Acceleration = acceleration;
            base.Mass = mass;
            base.BasicColor = color;
        }

        public Circle(Double diameter, Double x, Double y, Double vX, Double vY, Double aX, Double aY, Double mass, Color color) {
            Diameter = diameter;
            base.Location = new Vector2D(x, y);
            base.Velocity = new Vector2D(vX, vY);
            base.Acceleration = new Vector2D(aX, vY);
            base.Mass = mass;
            base.BasicColor = color;
        }

        public override string Shape()
        {
            return "Circle";
        }
    }
}
