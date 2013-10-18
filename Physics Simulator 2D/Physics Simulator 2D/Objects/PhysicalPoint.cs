using Physics_Simulator_2D.Tools;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Physics_Simulator_2D.Objects
{
    class PhysicalPoint
    {
        public Vector2D Location;
        public Vector2D Velocity;
        public Vector2D Acceleration;
        public Double Mass;
        public Double Elasticity = 0.7;
        public Color BasicColor;

        public PhysicalPoint() {}

        public PhysicalPoint(Vector2D location, Vector2D velocity, Vector2D acceleration, Double mass, Color color)
        {
            Location = location;
            Velocity = velocity;
            Acceleration = acceleration;
            Mass = mass;
            BasicColor = color;
        }

        public PhysicalPoint(Double x, Double y, Double vX, Double vY, Double aX, Double aY, Double mass, Color color) {
            Location = new Vector2D(x, y);
            Velocity = new Vector2D(vX, vY);
            Acceleration = new Vector2D(aX, vY);
            Mass = mass;
            BasicColor = color;
        }

        public virtual string Shape()
        {
            return "Point";
        }

        public double GetAngle()
        {
            return Math.Atan2(Velocity.Y, Velocity.X);
        }

        public double GetAngleDegrees()
        {
            return GetAngle() * 100/Math.PI;
        }
    }
}
