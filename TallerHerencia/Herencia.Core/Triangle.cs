namespace Geometry
{
    public class Triangle : Rectangle
    {
        private double c;
        private double h;
        public double C
        {
            get { return c; }
            set
            {
                ValidateC(value);
                c = value;
            }
        }
        public double H
        {
            get { return h; }
            set
            {
                ValidateH(value);
                h = value;
            }
        }

        public Triangle(string name, double a, double b, double c, double h) : base(name, a, b)
        {
            ValidateC(c);
            ValidateH(h);
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
        private void ValidateC(double c)
        {
            if (c <= 0)
                throw new ArgumentException("El lado C del triángulo debe ser mayor que cero.");
            if (double.IsNaN(c) || double.IsInfinity(c))
                throw new ArgumentException("El lado C del triángulo debe ser un número válido.");
        }

        private void ValidateH(double h)
        {
            if (h <= 0)
                throw new ArgumentException("La altura del triángulo debe ser mayor que cero.");
            if (double.IsNaN(h) || double.IsInfinity(h))
                throw new ArgumentException("La altura del triángulo debe ser un número válido.");
        }
    }
}