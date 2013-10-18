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
        Double BorderElasticity;
        bool BorderEnabled = true;
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
                if (o.Location.X < 0) o.Velocity.X *= -1 * o.Elasticity;
                if (o.Location.X > Width) o.Velocity.X *= -1 * o.Elasticity;
                if (o.Location.Y < 0) o.Velocity.Y *= -1 * o.Elasticity;
                if (o.Location.Y > Height) o.Velocity.Y *= -1 * o.Elasticity;
            }
        }

        public void AddObject(PhysicalPoint physicalObject) {
            ObjectList.Add(physicalObject);
        }

        public List<PhysicalPoint> GetObjectList()
        {
            return ObjectList;
        }
    }
}
