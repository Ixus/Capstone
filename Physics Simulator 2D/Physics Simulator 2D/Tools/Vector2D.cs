using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Physics_Simulator_2D.Tools
{
    class Vector2D
    {
        public double X { get; set; }
        public double Y { get; set; }

        public Vector2D() { }

        public Vector2D(double x, double y)
        {
            SetXY(x, y);
        }

        public void SetXY(double x, double y)
        {
            X = x;
            Y = y;
        }

        public override String ToString()
        {
            return "(" + X + "," + Y + ")";
        }

        // STATIC

        public static Vector2D Add(Vector2D u, Vector2D v)
        {
            return new Vector2D(u.X + v.X, u.Y + v.Y);
        }

        public static double DotProduct(Vector2D u, Vector2D v)
        {
            return (u.X * v.X) + (u.Y * v.Y);
        }

        public static double Magnitude(Vector2D v, int dec = 4)
        {
            return Math.Round(Math.Sqrt(DotProduct(v, v)), dec);
        }

        public static String Magnitude_String(Vector2D v)
        {
            return "√" + DotProduct(v, v);
        }

        public static String Normalization(Vector2D v)
        {
            var m = Vector2D.Magnitude_String(v);
            return "<" + v.X + "/" + m + ", " + v.Y + "/" + m + ">";
        }

        public static Vector2D ScalarMultiplication(Vector2D v, double scalar)
        {
            return new Vector2D(scalar * v.X, scalar * v.Y);
        }
    }
}
