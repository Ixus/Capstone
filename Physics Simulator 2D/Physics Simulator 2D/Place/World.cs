using Physics_Simulator_2D.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Physics_Simulator_2D.Place
{
    class World
    {
        Double Width;
        Double Height;
        Double Gravity;
        public Double BorderElasticity = 1;
        public bool BorderEnabled = true;
        public bool Play = true;
        List<PhysicalPoint> ObjectList = new List<PhysicalPoint>();
        // future: time intervals for update

        public World() {}

        public World(Double width, Double height, Double gravity = -9.8)
        {
            Width = width;
            Height = height;
            Gravity = gravity;
        }

        public void Update(Double time)
        {
            if (!Play) return;
            foreach(PhysicalPoint o in ObjectList) {
                o.Location.X += (o.Velocity.X * time);
                o.Location.Y += (o.Velocity.Y * time);
                o.Velocity.Y = o.Velocity.Y + (Gravity * time);
            }
            WorldBorderCollision(time);
        }

        public void WorldBorderCollision(Double time)
        {
            foreach (PhysicalPoint o in ObjectList)
            {
                if (o.Shape().Equals("Point"))
                {
                    if (o.Location.X < 0) o.Velocity.X *= -1 * o.Elasticity;
                    if (o.Location.X > Width) o.Velocity.X *= -1 * o.Elasticity;
                    if (o.Location.Y < 0) o.Velocity.Y *= -1 * o.Elasticity;
                    if (o.Location.Y > Height) o.Velocity.Y *= -1 * o.Elasticity;
                }
                else if (o.Shape().Equals("Circle"))
                {
                    Circle o2 = (Circle)o;
                    if (o.Location.X - o2.Diameter < 0) o.Velocity.X *= -1 * o.Elasticity;
                    if (o.Location.X + o2.Diameter > Width) o.Velocity.X *= -1 * o.Elasticity;
                    if (o.Location.Y - o2.Diameter < 0) o.Velocity.Y *= -1 * o.Elasticity;
                    if (o.Location.Y + o2.Diameter > Height) o.Velocity.Y *= -1 * o.Elasticity;
                }
                
            }
        }

        public void AddObject(PhysicalPoint physicalObject) {
            ObjectList.Add(physicalObject);
        }

        public List<PhysicalPoint> GetObjectList()
        {
            return ObjectList;
        }

        public void Clear()
        {
            ObjectList.Clear();
        }
    }
}
