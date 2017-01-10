using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    public interface IMovable
    {
        void MoveBy(float dx, float dy, float dz);
        void MoveTo(float x, float y, float z);
        void MoveTo(Point3D pt);

    }
}
