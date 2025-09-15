namespace Geometry
{
    public class Parallelogram : Rectangle
    {
        private double h;
        public double H {
            get { return h; }
            set {
                ValidateH(value);
                h = value; } }

        public Parallelogram(string name, double a, double b, double h) : base(name, a, b)
        {
            ValidateH(h);
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

        private void ValidateH(double h)
        {
            if (h <= 0)
                throw new ArgumentException("La altura del paralelogramo debe ser mayor que cero.");
            if (double.IsNaN(h) || double.IsInfinity(h))
                throw new ArgumentException("La altura del paralelogramo debe ser un número válido.");
        }
    }

}