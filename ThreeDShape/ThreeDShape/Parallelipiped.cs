namespace ThreeDShape
{
    class Parallelipiped : ThreeDShapes
    {
        double a;
        double b;
        double c;

        public Parallelipiped(double A, double B, double C)
        {
            a = A;
            b = B;
            c = C;
        }

        public override double Area
        {
            get
            {
                return 2 * (a * b + a * c + b * c);
            }
        }

        public override double Volume
        {
            get
            {
                return a * b * c;
            }
        }
    }
}
