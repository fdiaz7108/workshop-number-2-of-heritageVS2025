namespace Geometry
{
    public class Kite : Rhombus
    {
        public double B { get; set; }

        public Kite(string name, double a, double d1, double d2, double b) : base(name, a, d1, d2)
        {
            B = b;
        }

        public override double GetArea()
        {
            return (D1 * D2) / 2;
        }

        public override double GetPerimeter()
        {
            return 2 * (A + B);
        }
    }
}