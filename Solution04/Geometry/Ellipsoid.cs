using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    class Ellipsoid : Shape3D, IMovable
    {
        protected float a;
        protected float b;
        protected float c;


        public override float Area
        {
            get
            {
                float p = 1.6075f;
                return (float)(4 * Math.PI * Math.Pow((Math.Pow(a * b, p) + Math.Pow(a * c, p) + Math.Pow(b * c, p)) / 3, 1f / 1.6));
            }
        }

        public override float Volume
        {
            get
            {
                return 4f / 3f * (float)Math.PI * a * b * c;
            }
        }

        public void MoveBy(float dx, float dy, float dz)
        {
            var p = new Point3D();
            p.X = this.Location.X + dx;
            p.Y = this.Location.Y + dy;
            p.Z = Location.Z + dz;

            Location = p; 
        }

        public void MoveTo(Point3D pt)
        {
            this.Location = pt;
        }

        public void MoveTo(float x, float y, float z)
        {
            this.Location = new Point3D(x, y, z);
        }
    }
}
