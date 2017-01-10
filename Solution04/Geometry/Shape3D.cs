using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    public abstract class Shape3D
    {
        public Shape3D()
        {
            this.Location = new Point3D();
        }

        public Shape3D(Point3D p)
        {
            this.Location = p;
        }

        public Shape3D(float x, float y, float z)
        {
            Location = new Point3D(x, y , z);
            
        }

        protected Point3D Location { get; set; }
        public abstract float Volume { get; }
        public abstract float Area { get;  }
    }
}
