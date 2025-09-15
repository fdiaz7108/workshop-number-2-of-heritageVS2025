namespace Geometry
{
    public class Parallelogram : Rectangle
    {
        public double H { get; set; }

        public Parallelogram(string name, double a, double b, double h) : base(name, a, b)
        {
            H = h;
        }

        public override double GetArea()
        {
            return B * H;
        }

        public override double GetPerimeter()
        {
            return 2 * (A + B);
        }

    }

}