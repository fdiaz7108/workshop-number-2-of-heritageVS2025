namespace Geometry
{
    public class Triangle : Rectangle
    {
        public double C { get; set; }
        public double H { get; set; }

        public Triangle(string name, double a, double b, double c, double h) : base(name, a, b)
        {
            C = c;
            H = h;
        }

        public override double GetArea()
        {
            return (B * H) / 2;
        }

        public override double GetPerimeter()
        {
            return A + B + C;
        }
    }
}