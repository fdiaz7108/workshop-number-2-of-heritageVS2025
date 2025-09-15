namespace Geometry
{
    public class Trapeze : Triangle
    {
        public double D { get; set; }

        public Trapeze(string name, double a, double b, double c, double d, double h) : base(name, a, b, c, h)
        {
            D = d;
        }

        public override double GetArea()
        {
            return (B + D) * H / 2;
        }

        public override double GetPerimeter()
        {
            return A + B + C + D;
        }
    }
}