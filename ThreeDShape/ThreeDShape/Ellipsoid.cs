using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreeDShape
{
    class Ellipsoid : ThreeDShapes
    {
        double a;
        double b;
        double c;
        const double p = 1.6075;

        public Ellipsoid(double A, double B, double C)
        {
            a = A;
            b = B;
            c = C;
       }

        public override double Area
         {
            get
            {
                return (4 * Math.PI * Math.Pow(Math.Pow(a, p)* Math.Pow(b, p)
                                                        +Math.Pow(a, p) * Math.Pow(c, p)
                                                        +Math.Pow(b, p) * Math.Pow(c, p) /3.0, 1.0 / p));
            }
        }

        public override double Volume
        {
            get
            {
                return 4.0 / 3.0 * Math.PI * a * b * c;
            }
        }
    }
}
